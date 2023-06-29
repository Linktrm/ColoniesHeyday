using System;
using System.Collections.Generic;
using UnityEngine;

public class Mayor : ParentRole {
	
	public void DistributeColonists(Player playerRole, UIColonistShip UIColonistShip) {
		Debug.Log("Alcalde repartirColonos()");

		if(GameData.colonistShip > 0) { // En principio siempre tendría que haber alguno aquí
			int playerAcc = playerRole.position-1; // Comienza a repartir a partir del jugador que ha cogido el Role
			// Hasta que no se vacíe el barco, reparte
			Debug.Log("Vamos a repartir");
			while(GameData.colonistShip > 0) {
				Debug.Log("Jugador " + GameData.players[playerAcc].nickname + " colonos " + GameData.players[playerAcc].playerBoard.extraColonists + " -> " + (GameData.players[playerAcc].playerBoard.extraColonists+1));
				Debug.Log("barcoColonos " + GameData.colonistShip + " -> " + (GameData.colonistShip-1));
				GameData.players[playerAcc].playerBoard.extraColonists++;
				GameData.players[playerAcc].playerBoard.totalColonists++;
				GameData.colonistShip--;

				// UI
				GameData.players[playerAcc].UIPlayerBoard.GetComponent<UIPlayerBoard>().UIExtraColonist.text = GameData.players[playerAcc].playerBoard.extraColonists.ToString();
				
				// Siguiente jugador
				playerAcc++;
				if(playerAcc == GameData.totalPlayers) {
					playerAcc = 0;
				}
			}
			
			// *** BONUS ROLE
			// Si quedan colonos en la reserva, da el colono extra al que tenga el bonus de Role
			Debug.Log("BONUS ROLE");
			if(GameData.colonistReserve > 0) {
				Debug.Log("Cojo de la reserva");
				Debug.Log("Jugador " + (playerAcc+1) + " colonos " + GameData.players[playerAcc].playerBoard.extraColonists + " -> " + (GameData.players[playerAcc].playerBoard.extraColonists+1));
				playerRole.playerBoard.extraColonists++;
				playerRole.playerBoard.totalColonists++;
				GameData.colonistReserve--;
				// UI
				playerRole.UIPlayerBoard.GetComponent<UIPlayerBoard>().UIExtraColonist.text = playerRole.playerBoard.extraColonists.ToString();
				UIColonistShip.UIColonistReservation.text = GameData.colonistReserve.ToString();
			} else {
				Debug.Log("No quedan colonos en la reserva, te quedas sin");
			}
		}
		Debug.Log("Alcalde FIN repartirColonos()");
	}
	
	public ActionResult FulfillColonistsShip() {
		Debug.Log("Alcalde rellenarColonos()");
		
		// Primer control preventivo, si no hay al menos el mismo número de colonos que de jugadores, ya no hace falta calcular nada
		if(GameData.colonistReserve >= GameData.totalPlayers) {
			int emptySlots = CalculateEmptySlots();
			
			// Si hay menos huecos que número de jugadores, el mínimo es el número de jugadores
			if(emptySlots < GameData.totalPlayers) {
				Debug.Log("Hay menos huecos ("+emptySlots+") que jugadores ("+GameData.totalPlayers+"), ponemos " + GameData.totalPlayers);
				emptySlots = GameData.totalPlayers;
			}
			
			// Si se necesitan rellenar más colonos de los que quedan en la reserva
			if(emptySlots > GameData.colonistReserve) {
				Debug.Log("Hay más huecos ("+emptySlots+") que colonos en la reserva ("+GameData.colonistReserve+"), añado los que hay");
				// Se rellena el barco con los colonos restantes (si hay)
				GameData.colonistShip = GameData.colonistReserve;
				GameData.colonistReserve = 0;
				Debug.Log("TRIGGER RONDA FINAL - No hay suficientes colonos en la reserva como jugadores");
				Debug.Log("Alcalde FIN rellenarColonos()");
				return ActionResult.COLONIST_RESERVE_EMPTY; // NOS HEMOS QUEDADO SIN COLONOS EN LA RESERVA - RONDA FINAL
			}
			
			Debug.Log("barcoColonos = " + emptySlots);
			GameData.colonistShip = emptySlots;
			Debug.Log("colonosReserva " + GameData.colonistReserve + " -> " + (GameData.colonistReserve-GameData.colonistShip));
			GameData.colonistReserve -= GameData.colonistShip;
		} else {
			// Se rellena el barco con los colonos restantes (si hay)
			GameData.colonistShip = GameData.colonistReserve;
			GameData.colonistReserve = 0;
			Debug.Log("TRIGGER RONDA FINAL - No hay suficientes colonos en la reserva como jugadores");
			Debug.Log("Alcalde FIN rellenarColonos()");
			return ActionResult.COLONIST_RESERVE_EMPTY;
		}
		Debug.Log("Alcalde FIN rellenarColonos()");
		return ActionResult.OK;
	}

	public int CalculateEmptySlots() {
		int emptySlots = 0;
		// Bucle de recorrido de huecos vacíos
		Debug.Log("Recuento de huecos de edificios");
		foreach(Player player in GameData.players) {
			Debug.Log("Jugador " + player.nickname);
			int slotsBefore = emptySlots;
			player.playerBoard.emptySlots = 0; // Control Alcalde

			foreach(Building edificio in player.playerBoard.buildings.FindAll(i => i.colonists < i.maximumColonists)) {
				emptySlots += (edificio.maximumColonists - edificio.colonists);
				player.playerBoard.emptySlots += (edificio.maximumColonists - edificio.colonists);
			}
			Debug.Log("Huecos: " + (emptySlots - slotsBefore));

			// Los huecos de plantaciones no se suman al total retornado, es para actualizar el total del jugador por un control del Alcalde
			player.playerBoard.emptySlots += player.playerBoard.plantations.FindAll(i => i.colonist == 0).Count;
		}
		return emptySlots;
	}
}