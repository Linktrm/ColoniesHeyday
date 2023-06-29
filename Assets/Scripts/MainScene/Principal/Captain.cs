using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Captain : ParentRole {

	public ActionResult actionResult { get; set; }
	
	// Edificios especiales
	public bool activeHarbor { get; set; }
	public bool activeWharf { get; set; }
	public bool activeSmallWarehouse { get; set; }
	public bool activeLargeWarehouse { get; set; }

	public int ship1CornShipments { get; set; }
	public int ship2CornShipments { get; set; }
	public int ship3CornShipments { get; set; }
	public int ship1IndigoShipments { get; set; }
	public int ship2IndigoShipments { get; set; }
	public int ship3IndigoShipments { get; set; }
	public int ship1SugarShipments { get; set; }
	public int ship2SugarShipments { get; set; }
	public int ship3SugarShipments { get; set; }
	public int ship1TobaccoShipments { get; set; }
	public int ship2TobaccoShipments { get; set; }
	public int ship3TobaccoShipments { get; set; }
	public int ship1CoffeeShipments { get; set; }
	public int ship2CoffeeShipments { get; set; }
	public int ship3CoffeeShipments { get; set; }
	
	public SpoilType cornSpoil { get; set; }
	public SpoilType indigoSpoil { get; set; }
	public SpoilType sugarSpoil { get; set; }
	public SpoilType tobaccoSpoil { get; set; }
	public SpoilType coffeeSpoil { get; set; }

	public int totalNumberSpoilLess1 { get; set; }
	public int totalNumberTotalSpoil { get; set; }
	public int numberSpoilLess1 { get; set; }
	public int numberTotalSpoil { get; set; }

	public int spoilableGoods { get; set; }
	public int storingGoods { get; set; }
	
	private void ResetShipments() {
		activeHarbor = false;
		activeWharf = false;
		// -1 - NO TIENE BARRILES
		ship1CornShipments = -1;
		ship2CornShipments = -1;
		ship3CornShipments = -1;
		ship1IndigoShipments = -1;
		ship2IndigoShipments = -1;
		ship3IndigoShipments = -1;
		ship1SugarShipments = -1;
		ship2SugarShipments = -1;
		ship3SugarShipments = -1;
		ship1TobaccoShipments = -1;
		ship2TobaccoShipments = -1;
		ship3TobaccoShipments = -1;
		ship1CoffeeShipments = -1;
		ship2CoffeeShipments = -1;
		ship3CoffeeShipments = -1;
	}
	
	public void CheckSendings(Player player) {
		Debug.Log("Capitan comprobarEnvios()");
		Debug.Log("Comprobando envíos para el Jugador " + player.nickname);
		ResetShipments();
		
		// Miro si tiene el Puerto activo
		if(player.playerBoard.buildings.Find(i => i.type == BuildingType.HARBOR && i.colonists > 0) != null) {
			Debug.Log("Aviso previo, tiene Puerto usable");
			activeHarbor = true;
		}
		// Miro si tiene el Muelle activo
		if(!player.playerBoard.wharfUsed && player.playerBoard.buildings.Find(i => i.type == BuildingType.WHARF && i.colonists > 0) != null) {
			Debug.Log("Aviso previo, tiene Muelle usable");
			activeWharf = true;
		}
		
		// CÁLCULO DEL BARCO 1
		Debug.Log("=== BARCO 1 ===");
		switch(GameData.ship1.type) {
			case PlantationType.CORN: // Si el barco ya tiene Maíz
				Debug.Log("Comprobación de envíos de MAÍZ");
				ship1CornShipments = CheckSpecificShipments(GameData.ship1, player.playerBoard.cornBarrels.Count);
				Debug.Log("El barco 1 es de MAÍZ y puedo enviar " + ship1CornShipments);
				break;
			case PlantationType.INDIGO: // Si el barco ya tiene Añil
				Debug.Log("Comprobación de envíos de AÑIL");
				ship1IndigoShipments = CheckSpecificShipments(GameData.ship1, player.playerBoard.indigoBarrels.Count);
				Debug.Log("El barco 1 es de AÑIL y puedo enviar " + ship1IndigoShipments);
				break;
			case PlantationType.SUGAR: // Si el barco ya tiene Azúcar
				Debug.Log("Comprobación de envíos de AZÚCAR");
				ship1SugarShipments = CheckSpecificShipments(GameData.ship1, player.playerBoard.sugarBarrels.Count);
				Debug.Log("El barco 1 es de AZÚCAR y puedo enviar " + ship1SugarShipments);
				break;
			case PlantationType.TOBACCO: // Si el barco ya tiene Tabaco
				Debug.Log("Comprobación de envíos de TABACO");
				ship1TobaccoShipments = CheckSpecificShipments(GameData.ship1, player.playerBoard.tobaccoBarrels.Count);
				Debug.Log("El barco 1 es de TABACO y puedo enviar " + ship1TobaccoShipments);
				break;
			case PlantationType.COFFEE: // Si el barco ya tiene Café
				Debug.Log("Comprobación de envíos de CAFÉ");
				ship1CoffeeShipments = CheckSpecificShipments(GameData.ship1, player.playerBoard.coffeeBarrels.Count);
				Debug.Log("El barco 1 es de CAFÉ y puedo enviar " + ship1CoffeeShipments);
				break;
			case PlantationType.EMPTY_SHIP:
				// MAIZ
				// Si los demás barcos no tienen la misma mercancía, puedo enviar en este barco
				Debug.Log("MAÍZ");
				if(GameData.ship2.type != PlantationType.CORN && GameData.ship3.type != PlantationType.CORN) {
					ship1CornShipments = CheckSpecificShipments(GameData.ship1, player.playerBoard.cornBarrels.Count);
					Debug.Log("Puede enviar " + ship1CornShipments + " de MAÍZ al barco 1");
				} else {
					ship1CornShipments = -3; // ERROR - YA HAY OTRO BARCO CON ESA MERCANCIA
					Debug.Log("No se puede enviar MAÍZ a este barco porque ya hay otro de ese tipo");
				}
				
				// AÑIL
				// Si los demás barcos no tienen la misma mercancía, puedo enviar en este barco
				Debug.Log("AÑIL");
				if(GameData.ship2.type != PlantationType.INDIGO && GameData.ship3.type != PlantationType.INDIGO) {
					ship1IndigoShipments = CheckSpecificShipments(GameData.ship1, player.playerBoard.indigoBarrels.Count);
					Debug.Log("Puede enviar " + ship1IndigoShipments + " de AÑIL al barco 1");
				} else {
					ship1IndigoShipments = -3; // ERROR - YA HAY OTRO BARCO CON ESA MERCANCIA
					Debug.Log("No se puede enviar AÑIL a este barco porque ya hay otro de ese tipo");
				}
				
				// AZUCAR
				// Si los demás barcos no tienen la misma mercancía, puedo enviar en este barco
				Debug.Log("AZÚCAR");
				if(GameData.ship2.type != PlantationType.SUGAR && GameData.ship3.type != PlantationType.SUGAR) {
					ship1SugarShipments = CheckSpecificShipments(GameData.ship1, player.playerBoard.sugarBarrels.Count);
					Debug.Log("Puede enviar " + ship1SugarShipments + " de AZÚCAR al barco 1");
				} else {
					ship1SugarShipments = -3; // ERROR - YA HAY OTRO BARCO CON ESA MERCANCIA
					Debug.Log("No se puede enviar AZÚCAR a este barco porque ya hay otro de ese tipo");
				}
				
				// TABACO
				// Si los demás barcos no tienen la misma mercancía, puedo enviar en este barco
				Debug.Log("TABACO");
				if(GameData.ship2.type != PlantationType.TOBACCO && GameData.ship3.type != PlantationType.TOBACCO) {
					ship1TobaccoShipments = CheckSpecificShipments(GameData.ship1, player.playerBoard.tobaccoBarrels.Count);
					Debug.Log("Puede enviar " + ship1TobaccoShipments + " de TABACO al barco 1");
				} else {
					ship1TobaccoShipments = -3; // ERROR - YA HAY OTRO BARCO CON ESA MERCANCIA
					Debug.Log("No se puede enviar TABACO a este barco porque ya hay otro de ese tipo");
				}
				
				// CAFE
				// Si los demás barcos no tienen la misma mercancía, puedo enviar en este barco
				Debug.Log("CAFÉ");
				if(GameData.ship2.type != PlantationType.COFFEE && GameData.ship3.type != PlantationType.COFFEE) {
					ship1CoffeeShipments = CheckSpecificShipments(GameData.ship1, player.playerBoard.coffeeBarrels.Count);
					Debug.Log("Puede enviar " + ship1CoffeeShipments + " de CAFÉ al barco 1");
				} else {
					ship1CoffeeShipments = -3; // ERROR - YA HAY OTRO BARCO CON ESA MERCANCIA
					Debug.Log("No se puede enviar CAFÉ a este barco porque ya hay otro de ese tipo");
				}
				break;
		}
		
		// CÁLCULO DEL BARCO 2
		Debug.Log("=== BARCO 2 ===");
		switch(GameData.ship2.type) {
			case PlantationType.CORN: // Si el barco ya tiene Maíz
				Debug.Log("Comprobación de envíos de MAÍZ");
				ship2CornShipments = CheckSpecificShipments(GameData.ship2, player.playerBoard.cornBarrels.Count);
				Debug.Log("El barco 2 es de MAÍZ y puedo enviar " + ship2CornShipments);
				break;
			case PlantationType.INDIGO: // Si el barco ya tiene Añil
				Debug.Log("Comprobación de envíos de AÑIL");
				ship2IndigoShipments = CheckSpecificShipments(GameData.ship2, player.playerBoard.indigoBarrels.Count);
				Debug.Log("El barco 2 es de AÑIL y puedo enviar " + ship2IndigoShipments);
				break;
			case PlantationType.SUGAR: // Si el barco ya tiene Azúcar
				Debug.Log("Comprobación de envíos de AZÚCAR");
				ship2SugarShipments = CheckSpecificShipments(GameData.ship2, player.playerBoard.sugarBarrels.Count);
				Debug.Log("El barco 2 es de AZÚCAR y puedo enviar " + ship2SugarShipments);
				break;
			case PlantationType.TOBACCO: // Si el barco ya tiene Tabaco
				Debug.Log("Comprobación de envíos de TABACO");
				ship2TobaccoShipments = CheckSpecificShipments(GameData.ship2, player.playerBoard.tobaccoBarrels.Count);
				Debug.Log("El barco 2 es de TABACO y puedo enviar " + ship2TobaccoShipments);
				break;
			case PlantationType.COFFEE: // Si el barco ya tiene Café
				Debug.Log("Comprobación de envíos de CAFÉ");
				ship2CoffeeShipments = CheckSpecificShipments(GameData.ship2, player.playerBoard.coffeeBarrels.Count);
				Debug.Log("El barco 2 es de CAFÉ y puedo enviar " + ship2CoffeeShipments);
				break;
			case PlantationType.EMPTY_SHIP:
				// MAIZ
				// Si los demás barcos no tienen la misma mercancía, puedo enviar en este barco
				Debug.Log("MAÍZ");
				if(GameData.ship1.type != PlantationType.CORN && GameData.ship3.type != PlantationType.CORN) {
					ship2CornShipments = CheckSpecificShipments(GameData.ship2, player.playerBoard.cornBarrels.Count);
					Debug.Log("Puede enviar " + ship2CornShipments + " de MAÍZ al barco 2");
				} else {
					ship2CornShipments = -3; // ERROR - YA HAY OTRO BARCO CON ESA MERCANCIA
					Debug.Log("No se puede enviar MAÍZ a este barco porque ya hay otro de ese tipo");
				}
				
				// AÑIL
				// Si los demás barcos no tienen la misma mercancía, puedo enviar en este barco
				Debug.Log("AÑIL");
				if(GameData.ship1.type != PlantationType.INDIGO && GameData.ship3.type != PlantationType.INDIGO) {
					ship2IndigoShipments = CheckSpecificShipments(GameData.ship2, player.playerBoard.indigoBarrels.Count);
					Debug.Log("Puede enviar " + ship2IndigoShipments + " de AÑIL al barco 2");
				} else {
					ship2IndigoShipments = -3; // ERROR - YA HAY OTRO BARCO CON ESA MERCANCIA
					Debug.Log("No se puede enviar AÑIL a este barco porque ya hay otro de ese tipo");
				}
				
				// AZUCAR
				// Si los demás barcos no tienen la misma mercancía, puedo enviar en este barco
				Debug.Log("AZÚCAR");
				if(GameData.ship1.type != PlantationType.SUGAR && GameData.ship3.type != PlantationType.SUGAR) {
					ship2SugarShipments = CheckSpecificShipments(GameData.ship2, player.playerBoard.sugarBarrels.Count);
					Debug.Log("Puede enviar " + ship2SugarShipments + " de AZÚCAR al barco 2");
				} else {
					ship2SugarShipments = -3; // ERROR - YA HAY OTRO BARCO CON ESA MERCANCIA
					Debug.Log("No se puede enviar AZÚCAR a este barco porque ya hay otro de ese tipo");
				}
				
				// TABACO
				// Si los demás barcos no tienen la misma mercancía, puedo enviar en este barco
				Debug.Log("TABACO");
				if(GameData.ship1.type != PlantationType.TOBACCO && GameData.ship3.type != PlantationType.TOBACCO) {
					ship2TobaccoShipments = CheckSpecificShipments(GameData.ship2, player.playerBoard.tobaccoBarrels.Count);
					Debug.Log("Puede enviar " + ship2TobaccoShipments + " de TABACO al barco 2");
				} else {
					ship2TobaccoShipments = -3; // ERROR - YA HAY OTRO BARCO CON ESA MERCANCIA
					Debug.Log("No se puede enviar TABACO a este barco porque ya hay otro de ese tipo");
				}
				
				// CAFE
				// Si los demás barcos no tienen la misma mercancía, puedo enviar en este barco
				Debug.Log("CAFÉ");
				if(GameData.ship1.type != PlantationType.COFFEE && GameData.ship3.type != PlantationType.COFFEE) {
					ship2CoffeeShipments = CheckSpecificShipments(GameData.ship2, player.playerBoard.coffeeBarrels.Count);
					Debug.Log("Puede enviar " + ship2CoffeeShipments + " de CAFÉ al barco 2");
				} else {
					ship2CoffeeShipments = -3; // ERROR - YA HAY OTRO BARCO CON ESA MERCANCIA
					Debug.Log("No se puede enviar CAFÉ a este barco porque ya hay otro de ese tipo");
				}
				break;
		}
		
		// CÁLCULO DEL BARCO 3
		Debug.Log("=== BARCO 3 ===");
		switch(GameData.ship3.type) {
			case PlantationType.CORN: // Si el barco ya tiene Maíz
				Debug.Log("Comprobación de envíos de MAÍZ");
				ship3CornShipments = CheckSpecificShipments(GameData.ship3, player.playerBoard.cornBarrels.Count);
				Debug.Log("El barco 3 es de MAÍZ y puedo enviar " + ship3CornShipments);
				break;
			case PlantationType.INDIGO: // Si el barco ya tiene Añil
				Debug.Log("Comprobación de envíos de AÑIL");
				ship3IndigoShipments = CheckSpecificShipments(GameData.ship3, player.playerBoard.indigoBarrels.Count);
				Debug.Log("El barco 3 es de AÑIL y puedo enviar " + ship3IndigoShipments);
				break;
			case PlantationType.SUGAR: // Si el barco ya tiene Azúcar
				Debug.Log("Comprobación de envíos de AZÚCAR");
				ship3SugarShipments = CheckSpecificShipments(GameData.ship3, player.playerBoard.sugarBarrels.Count);
				Debug.Log("El barco 3 es de AZÚCAR y puedo enviar " + ship3SugarShipments);
				break;
			case PlantationType.TOBACCO: // Si el barco ya tiene Tabaco
				Debug.Log("Comprobación de envíos de TABACO");
				ship3TobaccoShipments = CheckSpecificShipments(GameData.ship3, player.playerBoard.tobaccoBarrels.Count);
				Debug.Log("El barco 3 es de TABACO y puedo enviar " + ship3TobaccoShipments);
				break;
			case PlantationType.COFFEE: // Si el barco ya tiene Café
				Debug.Log("Comprobación de envíos de CAFÉ");
				ship3CoffeeShipments = CheckSpecificShipments(GameData.ship3, player.playerBoard.coffeeBarrels.Count);
				Debug.Log("El barco 3 es de CAFÉ y puedo enviar " + ship3CoffeeShipments);
				break;
			case PlantationType.EMPTY_SHIP:
				// MAIZ
				// Si los demás barcos no tienen la misma mercancía, puedo enviar en este barco
				Debug.Log("MAÍZ");
				if(GameData.ship1.type != PlantationType.CORN && GameData.ship2.type != PlantationType.CORN) {
					ship3CornShipments = CheckSpecificShipments(GameData.ship3, player.playerBoard.cornBarrels.Count);
					Debug.Log("Puede enviar " + ship3CornShipments + " de MAÍZ al barco 3");
				} else {
					ship3CornShipments = -3; // ERROR - YA HAY OTRO BARCO CON ESA MERCANCIA
					Debug.Log("No se puede enviar MAÍZ a este barco porque ya hay otro de ese tipo");
				}
				
				// AÑIL
				// Si los demás barcos no tienen la misma mercancía, puedo enviar en este barco
				Debug.Log("AÑIL");
				if(GameData.ship1.type != PlantationType.INDIGO && GameData.ship2.type != PlantationType.INDIGO) {
					ship3IndigoShipments = CheckSpecificShipments(GameData.ship3, player.playerBoard.indigoBarrels.Count);
					Debug.Log("Puede enviar " + ship3IndigoShipments + " de AÑIL al barco 3");
				} else {
					ship3IndigoShipments = -3; // ERROR - YA HAY OTRO BARCO CON ESA MERCANCIA
					Debug.Log("No se puede enviar AÑIL a este barco porque ya hay otro de ese tipo");
				}
				
				// AZUCAR
				// Si los demás barcos no tienen la misma mercancía, puedo enviar en este barco
				Debug.Log("AZÚCAR");
				if(GameData.ship1.type != PlantationType.SUGAR && GameData.ship2.type != PlantationType.SUGAR) {
					ship3SugarShipments = CheckSpecificShipments(GameData.ship3, player.playerBoard.sugarBarrels.Count);
					Debug.Log("Puede enviar " + ship3SugarShipments + " de AZÚCAR al barco 3");
				} else {
					ship3SugarShipments = -3; // ERROR - YA HAY OTRO BARCO CON ESA MERCANCIA
					Debug.Log("No se puede enviar AZÚCAR a este barco porque ya hay otro de ese tipo");
				}
				
				// TABACO
				// Si los demás barcos no tienen la misma mercancía, puedo enviar en este barco
				Debug.Log("TABACO");
				if(GameData.ship1.type != PlantationType.TOBACCO && GameData.ship2.type != PlantationType.TOBACCO) {
					ship3TobaccoShipments = CheckSpecificShipments(GameData.ship3, player.playerBoard.tobaccoBarrels.Count);
					Debug.Log("Puede enviar " + ship3TobaccoShipments + " de TABACO al barco 3");
				} else {
					ship3TobaccoShipments = -3; // ERROR - YA HAY OTRO BARCO CON ESA MERCANCIA
					Debug.Log("No se puede enviar TABACO a este barco porque ya hay otro de ese tipo");
				}
				
				// CAFE
				// Si los demás barcos no tienen la misma mercancía, puedo enviar en este barco
				Debug.Log("CAFÉ");
				if(GameData.ship1.type != PlantationType.COFFEE && GameData.ship2.type != PlantationType.COFFEE) {
					ship3CoffeeShipments = CheckSpecificShipments(GameData.ship3, player.playerBoard.coffeeBarrels.Count);
					Debug.Log("Puede enviar " + ship3CoffeeShipments + " de CAFÉ al barco 3");
				} else {
					ship3CoffeeShipments = -3; // ERROR - YA HAY OTRO BARCO CON ESA MERCANCIA
					Debug.Log("No se puede enviar CAFÉ a este barco porque ya hay otro de ese tipo");
				}
				break;
		}
		
		if(ship1CornShipments < 1 && ship2CornShipments < 1 && ship3CornShipments < 1 &&
			ship1IndigoShipments < 1 && ship2IndigoShipments < 1 && ship3IndigoShipments < 1 &&
			ship1SugarShipments < 1 && ship2SugarShipments < 1 && ship3SugarShipments < 1 &&
			ship1TobaccoShipments < 1 && ship2TobaccoShipments < 1 && ship3TobaccoShipments < 1 &&
			ship1CoffeeShipments < 1 && ship2CoffeeShipments < 1 && ship3CoffeeShipments < 1) {

			if(activeWharf && !player.playerBoard.wharfUsed &&
				(player.playerBoard.cornBarrels.Count > 0 || player.playerBoard.indigoBarrels.Count > 0 || 
				player.playerBoard.sugarBarrels.Count > 0 || player.playerBoard.tobaccoBarrels.Count > 0 || player.playerBoard.coffeeBarrels.Count > 0)) {
				Debug.Log("Puede enviar al barco privado");
			} else {
				player.playerBoard.continueSendingGoods = false;
				Debug.Log("No puede seguir enviando");
			}
		} else {
			Debug.Log("Tiene mercancías para enviar");
		}
		Debug.Log("Capitan FIN comprobarEnvios()");
	}
	
	private int CheckSpecificShipments(Ship ship, int playerBarrels) {
		if(playerBarrels > 0) { // Si el jugador tiene barriles para ese barco
			if(ship.barrels.Count < ship.size) { // Si hay sitio
				if(playerBarrels <= (ship.size - ship.barrels.Count)) {
					// Si tengo menos barriles que espacios libres, envío lo que tengo
					Debug.Log("Puede enviar todos");
					return playerBarrels;
				} else {
					// Si tengo más barriles que espacios libres, envío lo que puedo hasta llenar
					Debug.Log("Tengo más barriles (" + playerBarrels + ") que espacios libres tiene el barco (" + (ship.size - ship.barrels.Count) + ")");
					return ship.size - ship.barrels.Count;
				}
			} else {
				Debug.Log("BARCO LLENO");
				return -2; // ERROR - NO HAY ESPACIO
			}
		} else {
			Debug.Log("El jugador no tiene barriles de ese tipo para enviar");
			return 0; // El jugador no envía nada porque no tiene barriles
		}
	}
	
	public ActionResult SendGoods(Player player, List<Barrel> barrels, int sendings, Ship ship) {
		Debug.Log("Capitan enviar()");
		int vp = 0;
		Debug.Log("El jugador " + player.nickname + " va a enviar " + sendings + " barriles de " + barrels[0].type);
		while(sendings > 0) {
			if(ship == null) { // Envío sin barco, significa barco privado
				// Devuelve los barriles a la reserva
				switch(barrels[0].type) {
					case PlantationType.CORN:
						Debug.Log("Añado un barril de " + barrels[0].type + " a la reserva (" + GameData.cornBarrels.Count + "->" + (GameData.cornBarrels.Count+1) + ")");
						GameData.cornBarrels.Add(barrels[0]); break;
					case PlantationType.INDIGO:
						Debug.Log("Añado un barril de " + barrels[0].type + " a la reserva (" + GameData.indigoBarrels.Count + "->" + (GameData.indigoBarrels.Count+1) + ")");
						GameData.indigoBarrels.Add(barrels[0]); break;
					case PlantationType.SUGAR:
						Debug.Log("Añado un barril de " + barrels[0].type + " a la reserva (" + GameData.sugarBarrels.Count + "->" + (GameData.sugarBarrels.Count+1) + ")");
						GameData.sugarBarrels.Add(barrels[0]); break;
					case PlantationType.TOBACCO:
						Debug.Log("Añado un barril de " + barrels[0].type + " a la reserva (" + GameData.tobaccoBarrels.Count + "->" + (GameData.tobaccoBarrels.Count+1) + ")");
						GameData.tobaccoBarrels.Add(barrels[0]); break;
					case PlantationType.COFFEE:
						Debug.Log("Añado un barril de " + barrels[0].type + " a la reserva (" + GameData.coffeeBarrels.Count + "->" + (GameData.coffeeBarrels.Count+1) + ")");
						GameData.coffeeBarrels.Add(barrels[0]); break;
				}
				activeWharf = false;
				player.playerBoard.wharfUsed = true;
			} else {
				// Añade los barriles al barco seleccionado
				Debug.Log("Añado un barril al barco (" + ship.barrels.Count + "->" + (ship.barrels.Count+1) + ")");
				ship.barrels.Add(barrels[0]);
				if(ship.type == PlantationType.EMPTY_SHIP) {
					ship.type = barrels[0].type;
				}
			}
			barrels.RemoveAt(0); // Elimina los barriles del jugador
			vp++;
			Debug.Log(vp + " PV a sumar");
			sendings--;
		}
		Debug.Log("Se ha acabado de enviar");

		// Si tiene el BONUS ROLE, 1 PV extra, pero solo una vez
		if(player.playerBoard.roleBonus) {
			Debug.Log("BONUS ROLE, 1 PV extra");
			vp++;
			Debug.Log(vp + " PV a sumar");
			player.playerBoard.roleBonus = false;
		}
		
		// Si tiene el Puerto activo, 1 PV extra cada vez
		if(activeHarbor) {
			Debug.Log("Puerto activo, 1 PV extra cada vez que envía");
			vp++;
			Debug.Log(vp + " PV a sumar");
		}
		
		Debug.Log("PV del jugador (" + player.playerBoard.vp + "->" + (player.playerBoard.vp + vp) + ")");
		player.playerBoard.vp += vp;
		Debug.Log("PV de la reserva (" + GameData.victoryPoinsReserve + "->" + (GameData.victoryPoinsReserve - vp) + ")");
		GameData.victoryPoinsReserve -= vp;
		if(GameData.victoryPoinsReserve <= 0) {
			Debug.Log("¡ALERTA! Se han terminado los PV - RONDA FINAL");
			GameData.victoryPoinsReserve = 0;
			Debug.Log("Capitan FIN enviar()");
			return ActionResult.PV_RESERVE_EMPTY; // SE HAN ACABADO LOS PV, RONDA FINAL
		}
		Debug.Log("Capitan FIN enviar()");
		return ActionResult.OK;
	}
	
	
	// SPOILEOS
	// ========
	
	private void ResetSpoils() {
		activeSmallWarehouse = false;
		activeLargeWarehouse = false;
		
		cornSpoil = SpoilType.TOTAL_SPOIL;
		indigoSpoil = SpoilType.TOTAL_SPOIL;
		sugarSpoil = SpoilType.TOTAL_SPOIL;
		tobaccoSpoil = SpoilType.TOTAL_SPOIL;
		coffeeSpoil = SpoilType.TOTAL_SPOIL;

		storingGoods = 0;
		spoilableGoods = 0; 
		totalNumberSpoilLess1 = 0;
		totalNumberTotalSpoil = 0;
		numberSpoilLess1 = 0;
		numberTotalSpoil = 0;
	}
	
	public void CalculateSpoilingGoods(Player player) {
		Debug.Log("Capitan calcularSpoileos()");
		ResetSpoils();
		
		// Miro si tiene el Almacén pequeño activo
		if(player.playerBoard.buildings.Find(i => i.type == BuildingType.SMALL_WAREHOUSE && i.colonists > 0) != null) {
			Debug.Log("Aviso previo, tiene Almacén pequeño usable");
			activeSmallWarehouse = true;
			storingGoods += 1;
		}
		// Miro si tiene el Almacén grande activo
		if(player.playerBoard.buildings.Find(i => i.type == BuildingType.LARGE_WAREHOUSE && i.colonists > 0) != null) {
			Debug.Log("Aviso previo, tiene Almacén grande usable");
			activeLargeWarehouse = true;
			storingGoods += 2;
		}

		// Compruebo la cantidad de tipos de mercancías que ha de spoilear
		if(player.playerBoard.cornBarrels.Count > 0) { // MAIZ
			Debug.Log("Al jugador " + player.nickname + " le sobran " + player.playerBoard.cornBarrels.Count + " barriles de MAÍZ");
			spoilableGoods++;
		}
		if(player.playerBoard.indigoBarrels.Count > 0) { // AÑIL
			Debug.Log("Al jugador " + player.nickname + " le sobran " + player.playerBoard.indigoBarrels.Count + " barriles de AÑIL");
			spoilableGoods++;
		}
		if(player.playerBoard.sugarBarrels.Count > 0) { // AZÚCAR
			Debug.Log("Al jugador " + player.nickname + " le sobran " + player.playerBoard.sugarBarrels.Count + " barriles de AZÚCAR");
			spoilableGoods++;
		}
		if(player.playerBoard.tobaccoBarrels.Count > 0) { // TABACO
			Debug.Log("Al jugador " + player.nickname + " le sobran " + player.playerBoard.tobaccoBarrels.Count + " barriles de TABACO");
			spoilableGoods++;
		}
		if(player.playerBoard.coffeeBarrels.Count > 0) { // CAFÉ
			Debug.Log("Al jugador " + player.nickname + " le sobran " + player.playerBoard.coffeeBarrels.Count + " barriles de CAFÉ");
			spoilableGoods++;
		}

		// Le restamos la cantidad de mercancías spoileables por los almacenes
		Debug.Log("Tiene " + spoilableGoods + " mercancías para spoilear");
		spoilableGoods -= storingGoods;
		if(spoilableGoods < 0) {
			spoilableGoods = 0;
		}
		Debug.Log("EN TOTAL, con los almacenes, tiene " + spoilableGoods + " mercancías para spoilear");

		ResetCalculatedSpoils(player.UIPlayerBoard.GetComponent<UIPlayerBoard>(), player.playerBoard);

		Debug.Log("Capitan FIN calcularSpoileos()");
	}

	public void ResetCalculatedSpoils(UIPlayerBoard UITablero, PlayerBoard playerBoard) {
		cornSpoil = SpoilType.TOTAL_SPOIL;
		indigoSpoil = SpoilType.TOTAL_SPOIL;
		sugarSpoil = SpoilType.TOTAL_SPOIL;
		tobaccoSpoil = SpoilType.TOTAL_SPOIL;
		coffeeSpoil = SpoilType.TOTAL_SPOIL;

		UITablero.UICornBarrelSpoil.text = "0";
		UITablero.UIIndigoBarrelSpoil.text = "0";
		UITablero.UISugarBarrelSpoil.text = "0";
		UITablero.UITobaccoBarrelSpoil.text = "0";
		UITablero.UICoffeeBarrelSpoil.text = "0";

		numberSpoilLess1 = 0;
		numberTotalSpoil = 0;

		// Control de que si hay capitan.mercanciasSpoileables = 1, ha de elegir 1->Menos 1
		// Control de que si hay capitan.mercanciasSpoileables = 2, ha de elegir 1->Menos 1 y 1->Total
		// Control de que si hay capitan.mercanciasSpoileables = 3, ha de elegir 1->Menos 1 y 2->Total
		// Control de que si hay capitan.mercanciasSpoileables = 4, ha de elegir 1->Menos 1 y 3->Total
		// Control de que si hay capitan.mercanciasSpoileables = 5, ha de elegir 1->Menos 1 y 4->Total
		switch(spoilableGoods) {
			case 1:
				totalNumberSpoilLess1 = 1;
				totalNumberTotalSpoil = 0;
				break;
			case 2:
				totalNumberSpoilLess1 = 1;
				totalNumberTotalSpoil = 1;
				break;
			case 3:
				totalNumberSpoilLess1 = 1;
				totalNumberTotalSpoil = 2;
				break;
			case 4:
				totalNumberSpoilLess1 = 1;
				totalNumberTotalSpoil = 3;
				break;
			case 5:
				totalNumberSpoilLess1 = 1;
				totalNumberTotalSpoil = 4;
				break;
		}
		// Por defecto, todas las mercancías estarán en TOTAL_SPOIL
		if(playerBoard.cornBarrels.Count > 0) {
			numberTotalSpoil++;
		}
		if(playerBoard.indigoBarrels.Count > 0) {
			numberTotalSpoil++;
		}
		if(playerBoard.sugarBarrels.Count > 0) {
			numberTotalSpoil++;
		}
		if(playerBoard.tobaccoBarrels.Count > 0) {
			numberTotalSpoil++;
		}
		if(playerBoard.coffeeBarrels.Count > 0) {
			numberTotalSpoil++;
		}
	}
	
	public void Spoil(Player player) {
		Debug.Log("Capitan spoilear()");
		
		// AQUI EL JUGADOR HABRÁ SELECCIONADO POR LA INTERFAZ QUE MERCANCIAS VA A SALVAR
		// POR LO TANTO SE HABRÁN RELLENADO LAS VARIABLES DE SPOILEOS:
		// NO SE SPOILEA
		// SPOILEO MENOS 1
		// SPOILEO TOTAL (defualt)
		
		if(cornSpoil != SpoilType.NOT_SPOILING) {
			if(cornSpoil == SpoilType.SPOIL_LESS_1) {
				Debug.Log("Spoileo de 1 barril de MAÍZ (" + player.playerBoard.cornBarrels.Count + " -> 1)");
			} else {
				Debug.Log("Spoileo TOTAL de barriles de MAÍZ (" + player.playerBoard.cornBarrels.Count + " -> 0)");
			}
			if(cornSpoil == SpoilType.TOTAL_SPOIL || player.playerBoard.cornBarrels.Count > 1) {
				Barrel notSpoiledBarrel = null;
				// Si el spoileo menos uno, sacamos y guardamos el barril para luego
				if(cornSpoil == SpoilType.SPOIL_LESS_1) {
					notSpoiledBarrel = player.playerBoard.cornBarrels[0];
					player.playerBoard.cornBarrels.Remove(notSpoiledBarrel);
				}
				// Añadimos los barriles del jugador a la reserva
				foreach(Barrel barrel in player.playerBoard.cornBarrels) {
					GameData.cornBarrels.Add(barrel); // Añade barril a la reserva
				}
				// Vaciamos los barriles del jugador
				player.playerBoard.cornBarrels.Clear();
				if(notSpoiledBarrel != null) {
					player.playerBoard.cornBarrels.Add(notSpoiledBarrel); // Añadimos el barril que guardamos antes
				}
			}
		}
		
		if(indigoSpoil != SpoilType.NOT_SPOILING) {
			if(indigoSpoil == SpoilType.SPOIL_LESS_1) {
				Debug.Log("Spoileo de 1 barril de AÑIL (" + player.playerBoard.indigoBarrels.Count + " -> 1)");
			} else {
				Debug.Log("Spoileo TOTAL de barriles de AÑIL (" + player.playerBoard.indigoBarrels.Count + " -> 0)");
			}
			if(indigoSpoil == SpoilType.TOTAL_SPOIL || player.playerBoard.indigoBarrels.Count > 1) {
				Barrel notSpoiledBarrel = null;
				// Si el spoileo menos uno, sacamos y guardamos el barril para luego
				if(indigoSpoil == SpoilType.SPOIL_LESS_1) {
					notSpoiledBarrel = player.playerBoard.indigoBarrels[0];
					player.playerBoard.indigoBarrels.Remove(notSpoiledBarrel);
				}
				// Añadimos los barriles del jugador a la reserva
				foreach(Barrel barrel in player.playerBoard.indigoBarrels) {
					GameData.indigoBarrels.Add(barrel); // Añade barril a la reserva
				}
				// Vaciamos los barriles del jugador
				player.playerBoard.indigoBarrels.Clear();
				if(notSpoiledBarrel != null) {
					player.playerBoard.indigoBarrels.Add(notSpoiledBarrel); // Añadimos el barril que guardamos antes
				}
			}
		}
		
		if(sugarSpoil != SpoilType.NOT_SPOILING) {
			if(sugarSpoil == SpoilType.SPOIL_LESS_1) {
				Debug.Log("Spoileo de 1 barril de AZÚCAR (" + player.playerBoard.sugarBarrels.Count + " -> 1)");
			} else {
				Debug.Log("Spoileo TOTAL de barriles de AZÚCAR (" + player.playerBoard.sugarBarrels.Count + " -> 0)");
			}
			if(sugarSpoil == SpoilType.TOTAL_SPOIL || player.playerBoard.sugarBarrels.Count > 1) {
				Barrel notSpoiledBarrel = null;
				// Si el spoileo menos uno, sacamos y guardamos el barril para luego
				if(sugarSpoil == SpoilType.SPOIL_LESS_1) {
					notSpoiledBarrel = player.playerBoard.sugarBarrels[0];
					player.playerBoard.sugarBarrels.Remove(notSpoiledBarrel);
				}
				// Añadimos los barriles del jugador a la reserva
				foreach(Barrel barrel in player.playerBoard.sugarBarrels) {
					GameData.sugarBarrels.Add(barrel); // Añade barril a la reserva
				}
				// Vaciamos los barriles del jugador
				player.playerBoard.sugarBarrels.Clear();
				if(notSpoiledBarrel != null) {
					player.playerBoard.sugarBarrels.Add(notSpoiledBarrel); // Añadimos el barril que guardamos antes
				}
			}
		}
		
		if(tobaccoSpoil != SpoilType.NOT_SPOILING) {
			if(tobaccoSpoil == SpoilType.SPOIL_LESS_1) {
				Debug.Log("Spoileo de 1 barril de TABACO (" + player.playerBoard.tobaccoBarrels.Count + " -> 1)");
			} else {
				Debug.Log("Spoileo TOTAL de barriles de TABACO (" + player.playerBoard.tobaccoBarrels.Count + " -> 0)");
			}
			if(tobaccoSpoil == SpoilType.TOTAL_SPOIL || player.playerBoard.tobaccoBarrels.Count > 1) {
				Barrel notSpoiledBarrel = null;
				// Si el spoileo menos uno, sacamos y guardamos el barril para luego
				if(tobaccoSpoil == SpoilType.SPOIL_LESS_1) {
					notSpoiledBarrel = player.playerBoard.tobaccoBarrels[0];
					player.playerBoard.tobaccoBarrels.Remove(notSpoiledBarrel);
				}
				// Añadimos los barriles del jugador a la reserva
				foreach(Barrel barrel in player.playerBoard.tobaccoBarrels) {
					GameData.tobaccoBarrels.Add(barrel); // Añade barril a la reserva
				}
				// Vaciamos los barriles del jugador
				player.playerBoard.tobaccoBarrels.Clear();
				if(notSpoiledBarrel != null) {
					player.playerBoard.tobaccoBarrels.Add(notSpoiledBarrel); // Añadimos el barril que guardamos antes
				}
			}
		}
		
		if(coffeeSpoil != SpoilType.NOT_SPOILING) {
			if(coffeeSpoil == SpoilType.SPOIL_LESS_1) {
				Debug.Log("Spoileo de 1 barril de CAFÉ (" + player.playerBoard.coffeeBarrels.Count + " -> 1)");
			} else {
				Debug.Log("Spoileo TOTAL de barriles de CAFÉ (" + player.playerBoard.coffeeBarrels.Count + " -> 0)");
			}
			if(coffeeSpoil == SpoilType.TOTAL_SPOIL || player.playerBoard.coffeeBarrels.Count > 1) {
				Barrel notSpoiledBarrel = null;
				// Si el spoileo menos uno, sacamos y guardamos el barril para luego
				if(coffeeSpoil == SpoilType.SPOIL_LESS_1) {
					notSpoiledBarrel = player.playerBoard.coffeeBarrels[0];
					player.playerBoard.coffeeBarrels.Remove(notSpoiledBarrel);
				}
				// Añadimos los barriles del jugador a la reserva
				foreach(Barrel barrel in player.playerBoard.coffeeBarrels) {
					GameData.coffeeBarrels.Add(barrel); // Añade barril a la reserva
				}
				// Vaciamos los barriles del jugador
				player.playerBoard.coffeeBarrels.Clear();
				if(notSpoiledBarrel != null) {
					player.playerBoard.coffeeBarrels.Add(notSpoiledBarrel); // Añadimos el barril que guardamos antes
				}
			}
		}
		
		player.playerBoard.wharfUsed = false; // Reinicio la variable del barco extra
		player.playerBoard.continueSendingGoods = true; // Reinicio la variable de poder seguir enviando
		Debug.Log("Capitan FIN spoilear()");
	}

	public void EmptyFullShips() {
		Debug.Log("Capitan vaciarBarcosLlenos()");

		if(GameData.ship1.barrels.Count == GameData.ship1.size) {
			Debug.Log("BARCO 1 LLENO");
			foreach(Barrel barrel in GameData.ship1.barrels) {
				AddBarrelToReserve(barrel); // Añade barril a la reserva
			}
			GameData.ship1.barrels.Clear(); // Elimina barriles del Barco
			GameData.ship1.type = PlantationType.EMPTY_SHIP;
		}

		if(GameData.ship2.barrels.Count == GameData.ship2.size) {
			Debug.Log("BARCO 2 LLENO");
			foreach(Barrel barrel in GameData.ship2.barrels) {
				AddBarrelToReserve(barrel); // Añade barril a la reserva
			}
			GameData.ship2.barrels.Clear(); // Elimina barriles del Barco
			GameData.ship2.type = PlantationType.EMPTY_SHIP;
		}

		if(GameData.ship3.barrels.Count == GameData.ship3.size) {
			Debug.Log("BARCO 3 LLENO");
			foreach(Barrel barrel in GameData.ship3.barrels) {
				AddBarrelToReserve(barrel); // Añade barril a la reserva
			}
			GameData.ship3.barrels.Clear(); // Elimina barriles del Barco
			GameData.ship3.type = PlantationType.EMPTY_SHIP;
		}

		Debug.Log("Capitan FIN vaciarBarcosLlenos()");
	}

	void AddBarrelToReserve(Barrel barrel) {
		// Devuelve los barriles a la reserva
		switch(barrel.type) {
			case PlantationType.CORN:
				Debug.Log("Añado un barril de " + barrel.type + " a la reserva (" + GameData.cornBarrels.Count + "->" + (GameData.cornBarrels.Count+1) + ")");
				GameData.cornBarrels.Add(barrel); break;
			case PlantationType.INDIGO:
				Debug.Log("Añado un barril de " + barrel.type + " a la reserva (" + GameData.indigoBarrels.Count + "->" + (GameData.indigoBarrels.Count+1) + ")");
				GameData.indigoBarrels.Add(barrel); break;
			case PlantationType.SUGAR:
				Debug.Log("Añado un barril de " + barrel.type + " a la reserva (" + GameData.sugarBarrels.Count + "->" + (GameData.sugarBarrels.Count+1) + ")");
				GameData.sugarBarrels.Add(barrel); break;
			case PlantationType.TOBACCO:
				Debug.Log("Añado un barril de " + barrel.type + " a la reserva (" + GameData.tobaccoBarrels.Count + "->" + (GameData.tobaccoBarrels.Count+1) + ")");
				GameData.tobaccoBarrels.Add(barrel); break;
			case PlantationType.COFFEE:
				Debug.Log("Añado un barril de " + barrel.type + " a la reserva (" + GameData.coffeeBarrels.Count + "->" + (GameData.coffeeBarrels.Count+1) + ")");
				GameData.coffeeBarrels.Add(barrel); break;
		}
	}

	public int GetShipmentsNumberByShipAndBarrelType(CaptainObjectType shipType, PlantationType barrelType, PlayerBoard playerBoard) {
		switch(barrelType) {
			case PlantationType.CORN:
				if(shipType == CaptainObjectType.SHIP_1) {
					return ship1CornShipments;
				} else if(shipType == CaptainObjectType.SHIP_2) {
					return ship2CornShipments;
				} else if(shipType == CaptainObjectType.SHIP_3) {
					return ship3CornShipments;
				} else if(shipType == CaptainObjectType.PRIVATE_SHIP) {
					return playerBoard.cornBarrels.Count;
				} break;
			case PlantationType.INDIGO:
				if(shipType == CaptainObjectType.SHIP_1) {
					return ship1IndigoShipments;
				} else if(shipType == CaptainObjectType.SHIP_2) {
					return ship2IndigoShipments;
				} else if(shipType == CaptainObjectType.SHIP_3) {
					return ship3IndigoShipments;
				} else if(shipType == CaptainObjectType.PRIVATE_SHIP) {
					return playerBoard.indigoBarrels.Count;
				} break;
			case PlantationType.SUGAR:
				if(shipType == CaptainObjectType.SHIP_1) {
					return ship1SugarShipments;
				} else if(shipType == CaptainObjectType.SHIP_2) {
					return ship2SugarShipments;
				} else if(shipType == CaptainObjectType.SHIP_3) {
					return ship3SugarShipments;
				} else if(shipType == CaptainObjectType.PRIVATE_SHIP) {
					return playerBoard.sugarBarrels.Count;
				} break;
			case PlantationType.TOBACCO:
				if(shipType == CaptainObjectType.SHIP_1) {
					return ship1TobaccoShipments;
				} else if(shipType == CaptainObjectType.SHIP_2) {
					return ship2TobaccoShipments;
				} else if(shipType == CaptainObjectType.SHIP_3) {
					return ship3TobaccoShipments;
				} else if(shipType == CaptainObjectType.PRIVATE_SHIP) {
					return playerBoard.tobaccoBarrels.Count;
				} break;
			case PlantationType.COFFEE:
				if(shipType == CaptainObjectType.SHIP_1) {
					return ship1CoffeeShipments;
				} else if(shipType == CaptainObjectType.SHIP_2) {
					return ship2CoffeeShipments;
				} else if(shipType == CaptainObjectType.SHIP_3) {
					return ship3CoffeeShipments;
				} else if(shipType == CaptainObjectType.PRIVATE_SHIP) {
					return playerBoard.coffeeBarrels.Count;
				} break;
		}
		return 0;
	}

	public SpoilType CalculateSubmitSpoil(SpoilType spoilType, int totalBarrels, Text UISpoilText) {
		Debug.Log("Está en " + spoilType);
		// Si está en TOTAL SPOIL (x0)
		if(spoilType == SpoilType.TOTAL_SPOIL) {
			// Pasará a SPOIL_LESS_1 (x1)
			numberTotalSpoil--;
			spoilType = SpoilType.SPOIL_LESS_1;
			numberSpoilLess1++;
			UISpoilText.text = "1";
		// Si está en SPOIL_LESS_1 (x1)
		} else if(spoilType == SpoilType.SPOIL_LESS_1) {
			numberSpoilLess1--;
			// Si tiene más de un barril
			if(totalBarrels > 1) {
				// Pasará a NOT_SPOILING (xMAX)
				spoilType = SpoilType.NOT_SPOILING;
				UISpoilText.text = totalBarrels.ToString();
			// Si tiene UN barril
			} else {
				// Pasará a TOTAL_SPOIL (x0)
				spoilType = SpoilType.TOTAL_SPOIL;
				numberTotalSpoil++;
				UISpoilText.text = "0";
			}
		// Si está en NOT_SPOILING (xMAX)
		} else if(spoilType == SpoilType.NOT_SPOILING) {
			// Pasará a TOTAL_SPOIL (x0)
			spoilType = SpoilType.TOTAL_SPOIL;
			numberTotalSpoil++;
			UISpoilText.text = "0";
		}
		Debug.Log("Y pasa a " + spoilType);
		return spoilType;
	}

}