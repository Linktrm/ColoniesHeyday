using System;
using System.Collections.Generic;
using UnityEngine;

public class Trader : ParentRole {

	public ActionResult actionResult { get; set; }
	
	public bool activeOffice { get; set; }
	public bool activeSmallMarket { get; set; }
	public bool activeLargeMarket { get; set; }

	public int cornSellingPrice { get; set; }
	public int indigoSellingPrice { get; set; }
	public int sugarSellingPrice { get; set; }
	public int tobaccoSellingPrice { get; set; }
	public int coffeeSellingPrice { get; set; }
	
	void ReserPrices() {
		activeOffice = false;
		activeSmallMarket = false;
		activeLargeMarket = false;
		cornSellingPrice = -2;
		indigoSellingPrice = -2;
		sugarSellingPrice = -2;
		tobaccoSellingPrice = -2;
		coffeeSellingPrice = -2;
	}
	
	public ActionResult CheckSellingGoods(Player player, UISellHouse UISellHouse) {
		Debug.Log("Mercader comprobarVentas()");
		ReserPrices();
		
		if(GameData.barrilesVentas.Count < 4) {
			if(player.playerBoard.cornBarrels.Count != 0
				|| player.playerBoard.indigoBarrels.Count != 0
				|| player.playerBoard.sugarBarrels.Count != 0
				|| player.playerBoard.tobaccoBarrels.Count != 0
				|| player.playerBoard.coffeeBarrels.Count != 0) {
				
				// Hasta aquí, hay sitio para vender y el jugador tiene mercancías de algún tipo
				
				// Ahora voy a mirar si tiene Oficina para vender mercancías duplicadas
				if(player.playerBoard.buildings.Find(i => i.type == BuildingType.OFFICE && i.colonists > 0) != null) {
					Debug.Log("Aviso previo, tiene Oficina activa");
					activeOffice = true;
				}
				// Ahora miro si tiene mercados para aumentar el valor
				if(player.playerBoard.buildings.Find(i => i.type == BuildingType.SMALL_MARKET && i.colonists > 0) != null) {
					Debug.Log("Aviso previo, tiene Mercado pequeño activo");
					activeSmallMarket = true;
				}
				if(player.playerBoard.buildings.Find(i => i.type == BuildingType.LARGE_MARKET && i.colonists > 0) != null) {
					Debug.Log("Aviso previo, tiene Mercado grande activo");
					activeLargeMarket = true;
				}
				
				// Si tiene Maiz AND (Si tiene la oficina activa OR no hay esa mercancía ya en el mercado)
				if(player.playerBoard.cornBarrels.Count > 0
					&& (GameData.barrilesVentas.Find(i => i.type == PlantationType.CORN) == null || activeOffice)) {

					// Precio inicial de la mercancía
					cornSellingPrice = player.playerBoard.cornBarrels[0].marketValue;
					
					// Miro si tiene el bonus de role
					if(player.playerBoard.roleBonus) {
						cornSellingPrice += 1;
					}
					
					// Miro si tiene el Mercado Pequeño
					if(activeSmallMarket) {
						cornSellingPrice += 1;
					}
					
					// Miro si tiene el Mercado Grande
					if(activeLargeMarket) {
						cornSellingPrice += 2;
					}
					
					// Control para cuando no quede dinero en el banco
					if(GameData.bankCoins - cornSellingPrice < 0) {
						Debug.Log("ALERTA! Como en el banco no bastan las monedas, lo va a poder vender a " + GameData.bankCoins + " monedas");
						cornSellingPrice = GameData.bankCoins;
					}

					Debug.Log("Puede vender MAÍZ a " + cornSellingPrice + " monedas");
				}
				
				// Si tiene Añil AND (Si no hay esa mercancía ya en el mercado OR tiene la oficina activa)
				if(player.playerBoard.indigoBarrels.Count > 0
					&& (GameData.barrilesVentas.Find(i => i.type == PlantationType.INDIGO) == null || activeOffice)) {

					// Precio inicial de la mercancía
					indigoSellingPrice = player.playerBoard.indigoBarrels[0].marketValue;
					
					// Miro si tiene el bonus de role
					if(player.playerBoard.roleBonus) {
						indigoSellingPrice += 1;
					}
					
					// Miro si tiene el Mercado Pequeño
					if(activeSmallMarket) {
						indigoSellingPrice += 1;
					}
					
					//Miro si tiene el Mercado Grande
					if(activeLargeMarket) {
						indigoSellingPrice += 2;
					}
					
					// Control para cuando no quede dinero en la reserva
					if(GameData.bankCoins - indigoSellingPrice < 0) {
						Debug.Log("ALERTA! Como en el banco no bastan las monedas, lo va a poder vender a " + GameData.bankCoins + " monedas");
						indigoSellingPrice = GameData.bankCoins;
					}

					Debug.Log("Puede vender AÑIL a " + indigoSellingPrice + " monedas");
				}

				// Si tiene Azúcar AND (Si no hay esa mercancía ya en el mercado OR tiene la oficina activa)
				if(player.playerBoard.sugarBarrels.Count > 0
					&& (GameData.barrilesVentas.Find(i => i.type == PlantationType.SUGAR) == null || activeOffice)) {

					// Precio inicial de la mercancía
					sugarSellingPrice = player.playerBoard.sugarBarrels[0].marketValue;
					
					// Miro si tiene el bonus de role
					if(player.playerBoard.roleBonus) {
						sugarSellingPrice += 1;
					}
					
					// Miro si tiene el Mercado Pequeño
					if(activeSmallMarket) {
						sugarSellingPrice += 1;
					}
					
					//Miro si tiene el Mercado Grande
					if(activeLargeMarket) {
						sugarSellingPrice += 2;
					}
					
					// Control para cuando no quede dinero en la reserva
					if(GameData.bankCoins - sugarSellingPrice < 0) {
						Debug.Log("ALERTA! Como en el banco no bastan las monedas, lo va a poder vender a " + GameData.bankCoins + " monedas");
						sugarSellingPrice = GameData.bankCoins;
					}

					Debug.Log("Puede vender AZÚCAR a " + sugarSellingPrice + " monedas");
				}
				
				// Si tiene Tabaco AND (Si no hay esa mercancía ya en el mercado OR tiene la oficina activa)
				if(player.playerBoard.tobaccoBarrels.Count > 0
					&& (GameData.barrilesVentas.Find(i => i.type == PlantationType.TOBACCO) == null || activeOffice)) {

					// Precio inicial de la mercancía
					tobaccoSellingPrice = player.playerBoard.tobaccoBarrels[0].marketValue;
					
					// Miro si tiene el bonus de role
					if(player.playerBoard.roleBonus) {
						tobaccoSellingPrice += 1;
					}
					
					// Miro si tiene el Mercado Pequeño
					if(activeSmallMarket) {
						tobaccoSellingPrice += 1;
					}
					
					//Miro si tiene el Mercado Grande
					if(activeLargeMarket) {
						tobaccoSellingPrice += 2;
					}
					
					// Control para cuando no quede dinero en la reserva
					if(GameData.bankCoins - tobaccoSellingPrice < 0) {
						Debug.Log("ALERTA! Como en el banco no bastan las monedas, lo va a poder vender a " + GameData.bankCoins + " monedas");
						tobaccoSellingPrice = GameData.bankCoins;
					}

					Debug.Log("Puede vender TABACO a " + tobaccoSellingPrice + " monedas");
				}
				
				// Si tiene Café AND (Si no hay esa mercancía ya en el mercado OR tiene la oficina activa)
				if(player.playerBoard.coffeeBarrels.Count > 0
					&& (GameData.barrilesVentas.Find(i => i.type == PlantationType.COFFEE) == null || activeOffice)) {

					// Precio inicial de la mercancía
					coffeeSellingPrice = player.playerBoard.coffeeBarrels[0].marketValue;
					
					// Miro si tiene el bonus de role
					if(player.playerBoard.roleBonus) {
						coffeeSellingPrice += 1;
					}
					
					// Miro si tiene el Mercado Pequeño
					if(activeSmallMarket) {
						coffeeSellingPrice += 1;
					}
					
					//Miro si tiene el Mercado Grande
					if(activeLargeMarket) {
						coffeeSellingPrice += 2;
					}
					
					// Control para cuando no quede dinero en la reserva
					if(GameData.bankCoins - coffeeSellingPrice < 0) {
						Debug.Log("ALERTA! Como en el banco no bastan las monedas, lo va a poder vender a " + GameData.bankCoins + " monedas");
						coffeeSellingPrice = GameData.bankCoins;
					}

					Debug.Log("Puede vender CAFÉ a " + coffeeSellingPrice + " monedas");
				}
				
				if(cornSellingPrice >= 0 || indigoSellingPrice >= 0 || sugarSellingPrice >= 0 || tobaccoSellingPrice >= 0 || coffeeSellingPrice >= 0) {
					// UI
					// CORN
					if(cornSellingPrice < 0) {
						UISellHouse.UITextCorn.text = "X";
						UISellHouse.UITextCorn.color = UISellHouse.colorRed;
					} else {
						UISellHouse.UITextCorn.text = cornSellingPrice.ToString();
						UISellHouse.UITextCorn.color = UISellHouse.colorGreen;
					}
					// INDIGO
					if(indigoSellingPrice < 0) {
						UISellHouse.UITextIndigo.text = "X";
						UISellHouse.UITextIndigo.color = UISellHouse.colorRed;
					} else {
						UISellHouse.UITextIndigo.text = indigoSellingPrice.ToString();
						UISellHouse.UITextIndigo.color = UISellHouse.colorGreen;
					}
					// SUGAR
					if(sugarSellingPrice < 0) {
						UISellHouse.UITextSugar.text = "X";
						UISellHouse.UITextSugar.color = UISellHouse.colorRed;
					} else {
						UISellHouse.UITextSugar.text = sugarSellingPrice.ToString();
						UISellHouse.UITextSugar.color = UISellHouse.colorGreen;
					}
					// TOBACCO
					if(tobaccoSellingPrice < 0) {
						UISellHouse.UITextTobacco.text = "X";
						UISellHouse.UITextTobacco.color = UISellHouse.colorRed;
					} else {
						UISellHouse.UITextTobacco.text = tobaccoSellingPrice.ToString();
						UISellHouse.UITextTobacco.color = UISellHouse.colorGreen;
					}
					// COFFEE
					if(coffeeSellingPrice < 0) {
						UISellHouse.UITextCoffee.text = "X";
						UISellHouse.UITextCoffee.color = UISellHouse.colorRed;
					} else {
						UISellHouse.UITextCoffee.text = coffeeSellingPrice.ToString();
						UISellHouse.UITextCoffee.color = UISellHouse.colorGreen;
					}
					Debug.Log("Mercader FIN comprobarVentas()");
					return ActionResult.OK; // OK - Puede vender mercancías
				}
				Debug.Log("El jugador no puede vender mercancías repetidas");
				Debug.Log("Mercader FIN comprobarVentas()");
				return ActionResult.TRADER_DUPLICATE_GOODS; // ERROR - Mercancías repetidas
			}
			Debug.Log("El jugador no tiene mercancías para vender");
			Debug.Log("Mercader FIN comprobarVentas()");
			return ActionResult.TRADER_PLAYER_WITHOUT_GOODS; // ERROR - No tiene mercancías
		}
		Debug.Log("La casa de ventas se ha llenado, se acaba el Role.");
		Debug.Log("Mercader FIN comprobarVentas()");
		return ActionResult.TRADER_FULL; // ERROR - No hay espacio
	}
	
	public ActionResult SellGoods(Player player, Barrel barrel, UISellHouse UISellHouse, UIBarrelReservation UIBarrelReservation) {
		Debug.Log("Mercader venderMercancia()");
		
		// Añade el barril a la casa de ventas
		GameData.barrilesVentas.Add(barrel);
		// UI
		UISellHouse.UIAssignBarrel(barrel.type);
		
		// Elimina el barril de los barriles del jugador y recoge monedas
		switch(barrel.type) {
			case PlantationType.CORN:
				Debug.Log("El jugador pasa a tener " + player.playerBoard.coins + "->" + (player.playerBoard.coins+cornSellingPrice) + " monedas");
				player.playerBoard.cornBarrels.Remove(barrel);
				player.playerBoard.coins += cornSellingPrice; // Sumo las monedas al jugador
				GameData.bankCoins -= cornSellingPrice; // Resto a las monedas del banco
				// UI
				player.UIPlayerBoard.GetComponent<UIPlayerBoard>().UICornBarrel.text = player.playerBoard.cornBarrels.Count.ToString();
				break;
			case PlantationType.INDIGO:
				Debug.Log("El jugador pasa a tener " + player.playerBoard.coins + "->" + (player.playerBoard.coins+indigoSellingPrice) + " monedas");
				player.playerBoard.indigoBarrels.Remove(barrel);
				player.playerBoard.coins += indigoSellingPrice; // Sumo las monedas al jugador
				GameData.bankCoins -= indigoSellingPrice; // Resto a las monedas del banco
				// UI
				player.UIPlayerBoard.GetComponent<UIPlayerBoard>().UIIndigoBarrel.text = player.playerBoard.indigoBarrels.Count.ToString();
				break;
			case PlantationType.SUGAR:
				Debug.Log("El jugador pasa a tener " + player.playerBoard.coins + "->" + (player.playerBoard.coins+sugarSellingPrice) + " monedas");
				player.playerBoard.sugarBarrels.Remove(barrel);
				player.playerBoard.coins += sugarSellingPrice; // Sumo las monedas al jugador
				GameData.bankCoins -= sugarSellingPrice; // Resto a las monedas del banco
				// UI
				player.UIPlayerBoard.GetComponent<UIPlayerBoard>().UISugarBarrel.text = player.playerBoard.sugarBarrels.Count.ToString();
				break;
			case PlantationType.TOBACCO:
				Debug.Log("El jugador pasa a tener " + player.playerBoard.coins + "->" + (player.playerBoard.coins+tobaccoSellingPrice) + " monedas");
				player.playerBoard.tobaccoBarrels.Remove(barrel);
				player.playerBoard.coins += tobaccoSellingPrice; // Sumo las monedas al jugador
				GameData.bankCoins -= tobaccoSellingPrice; // Resto a las monedas del banco
				// UI
				player.UIPlayerBoard.GetComponent<UIPlayerBoard>().UITobaccoBarrel.text = player.playerBoard.tobaccoBarrels.Count.ToString();
				break;
			case PlantationType.COFFEE:
				Debug.Log("El jugador pasa a tener " + player.playerBoard.coins + "->" + (player.playerBoard.coins+coffeeSellingPrice) + " monedas");
				player.playerBoard.coffeeBarrels.Remove(barrel);
				player.playerBoard.coins += coffeeSellingPrice; // Sumo las monedas al jugador
				GameData.bankCoins -= coffeeSellingPrice; // Resto a las monedas del banco
				// UI
				player.UIPlayerBoard.GetComponent<UIPlayerBoard>().UICoffeeBarrel.text = player.playerBoard.coffeeBarrels.Count.ToString();
				break;
		}
		// UI
		player.UIPlayerBoard.GetComponent<UIPlayerBoard>().UICoins.text = player.playerBoard.coins.ToString();
		
		// Si la casa de ventas se ha llenado, la vaciamos e indicamos que finalice el Role.
		Debug.Log("La casa de ventas ahora tiene " + GameData.barrilesVentas.Count + " barriles");
		if(GameData.barrilesVentas.Count == 4) {
			Debug.Log("Vaciamos");
			foreach(Barrel barrilAVaciar in GameData.barrilesVentas) {
				switch(barrilAVaciar.type) {
					case PlantationType.CORN:
						GameData.cornBarrels.Add(barrilAVaciar);
						// UI
						UIBarrelReservation.UICornBarrels.text = GameData.cornBarrels.Count.ToString();
						break;
					case PlantationType.INDIGO:
						GameData.indigoBarrels.Add(barrilAVaciar);
						// UI
						UIBarrelReservation.UIIndigoBarrels.text = GameData.indigoBarrels.Count.ToString();
						break;
					case PlantationType.SUGAR:
						GameData.sugarBarrels.Add(barrilAVaciar);
						// UI
						UIBarrelReservation.UISugarBarrels.text = GameData.sugarBarrels.Count.ToString();
						break;
					case PlantationType.TOBACCO:
						GameData.tobaccoBarrels.Add(barrilAVaciar);
						// UI
						UIBarrelReservation.UITobaccoBarrels.text = GameData.tobaccoBarrels.Count.ToString();
						break;
					case PlantationType.COFFEE:
						GameData.coffeeBarrels.Add(barrilAVaciar);
						// UI
						UIBarrelReservation.UICoffeeBarrels.text = GameData.coffeeBarrels.Count.ToString();
						break;
				}
			}
			GameData.barrilesVentas.Clear();
			// UI
			UISellHouse.UIBarrel1.SetActive(false);
			UISellHouse.UIBarrel2.SetActive(false);
			UISellHouse.UIBarrel3.SetActive(false);
			UISellHouse.UIBarrel4.SetActive(false);

			Debug.Log("Mercader FIN venderMercancia()");
			return ActionResult.TRADER_FULL; // La casa de ventas se ha llenado
		}
		Debug.Log("Mercader FIN venderMercancia()");
		return ActionResult.OK; // Sigue habiendo sitio para vender
	}
}