using System;
using System.Collections.Generic;
using UnityEngine;

public class Settler : ParentRole {
	
	public bool activeConstructionHut { get; set; }
	public bool activeHacienda { get; set; }
	public bool activeHospice { get; set; }
	
	public bool canPickQuarry { get; set; }
	public bool canPickExtraPlantation { get; set; }
	
	private void RebootBools() {
		activeConstructionHut = false;
		activeHacienda = false;
		activeHospice = false;
		
		canPickQuarry = false;
		canPickExtraPlantation = false;
	}
	
	public bool CheckPlantations(Player player) {
		Debug.Log("Colonizador comprobarPlantaciones()");
		RebootBools();
		
		// Mira si tiene la Caseta de obra activa
		if(player.playerBoard.buildings.Find(i => i.type == BuildingType.CONSTRUCTION_HUT && i.colonists > 0) != null) {
			Debug.Log("Aviso previo, tiene Caseta de obra activa");
			activeConstructionHut = true;
		}
		// Mira si tiene la Hacienda activa
		if(player.playerBoard.buildings.Find(i => i.type == BuildingType.HACIENDA && i.colonists > 0) != null) {
			Debug.Log("Aviso previo, tiene Hacienda activa");
			activeHacienda = true;
		}
		// Mira si tiene el Hospicio activo
		if(player.playerBoard.buildings.Find(i => i.type == BuildingType.HOSPICE && i.colonists > 0) != null) {
			Debug.Log("Aviso previo, tiene Hospicio activo");
			activeHospice = true;
		}
		
		// Comprueba que tenga sitio en el tablero
		if(player.playerBoard.plantations.Count < player.playerBoard.plantations.Capacity) {
			// Control para coger Canteras
			if(GameData.quarryReserve.Count > 0 && (player.playerBoard.roleBonus || activeConstructionHut)) {
				Debug.Log("Puede coger cantera");
				canPickQuarry = true;
			}
			//
			// Mira si tiene la Hacienda activa para coger Plantación extra
			if(activeHacienda && GameData.plantationReserve.Count > 0) {
				// ***** ALERTA!!!! Ha de coger la extra ANTES de la plantación descubierta/cantera
				canPickExtraPlantation = true;
				Debug.Log("Puede coger plantación extra, si quiere");
			}

			if((canPickQuarry && GameData.quarryReserve.Count > 0) || GameData.plantationsShowed.Count > 0) {
				Debug.Log("Colonizador FIN comprobarPlantaciones()");
				return true; // OK - Puede elegir
			}

			Debug.Log("No hay canteras elegibles OR plantaciones descubiertas");
			Debug.Log("Colonizador FIN comprobarPlantaciones()");
			return false; // ERROR - No tiene espacio
		}
		Debug.Log("El jugador tiene el tablero lleno");
		Debug.Log("Colonizador FIN comprobarPlantaciones()");
		return false; // ERROR - No tiene espacio
	}
	
	public void PickPlantations(Player player, Plantation plantation, UIPlantationBoard UIPlantationBoard5P, UIColonistShip UIColonistsBoard) {
		Debug.Log("Colonizador cogerPlantaciones()");
		Debug.Log("Se va a añadir " + plantation.type + " al Jugador " + player.nickname);
		// Si el jugador tiene el Hospicio activo, la plantación viene con colono
		if(activeHospice && (GameData.colonistReserve > 0 || GameData.colonistShip > 0)) {
			Debug.Log("El jugador tiene Hospicio y puede coger colono");
			plantation.colonist++;
			player.playerBoard.totalColonists++;
			
			// Resta un colono de la reserva, o del barco si no hubiese
			if(GameData.colonistReserve > 0) {
				Debug.Log("Cojo colono de la reserva (" + GameData.colonistReserve + "->" + (GameData.colonistReserve-1) + ")");
				GameData.colonistReserve--;
				// UI
				UIColonistsBoard.UIColonistReservation.text = GameData.colonistReserve.ToString();
			} else if(GameData.colonistShip > 0) {
				Debug.Log("Cojo colono del barco de colonos (" + GameData.colonistShip + "->" + (GameData.colonistShip-1) + ")");
				GameData.colonistShip--;
				// UI
				UIColonistsBoard.SubstractFromShip(GameData.colonistShip);
			} 
		}
		
		// Añade la plantación al tablero del jugador
		player.playerBoard.plantations.Add(plantation);
		// UI
		player.UIPlayerBoard.GetComponent<UIPlayerBoard>().UIAssignPlantation(plantation);

		if(plantation.type == PlantationType.QUARRY) {
			// Elimina la cantera de la reserva
			GameData.quarryReserve.Remove(plantation);
			// UI
			UIPlantationBoard5P.UIQuarry.text = GameData.quarryReserve.Count.ToString();
		} else {
			// Elimina la plantación de la reserva
			GameData.plantationsShowed.Remove(plantation);
			// UI
			UIPlantationBoard5P.gameObjectSelected.SetActive(false);
		}
		Debug.Log("Colonizador FIN cogerPlantaciones()");
	}
	
	public void PickExtraPlantation(Player player, UIPlantationBoard UIPlantationBoard5P) {
		Debug.Log("Colonizador cogerPlantacionExtra()");
		System.Random rnd = new System.Random();
		// Coge una plantación aleatoria de las plantacionesReserva
		Plantation plantacionExtra = GameData.plantationReserve[rnd.Next(GameData.plantationReserve.Count)];
		Debug.Log("Ha salido " + plantacionExtra.type);

		// Añade la plantación al tablero del jugador
		player.playerBoard.plantations.Add(plantacionExtra);
		// UI
		player.UIPlayerBoard.GetComponent<UIPlayerBoard>().UIAssignPlantation(plantacionExtra);

		// Elimina la plantación de la reserva
		GameData.plantationReserve.Remove(plantacionExtra);
		// UI
		if(GameData.plantationReserve.Count == 0) {
			UIPlantationBoard5P.UIFramePlantationReservation.SetActive(false);
			// TODO RESTARLE AL TEXT TOTAL
		}

		Debug.Log("Colonizador FIN cogerPlantacionExtra()");
	}
}