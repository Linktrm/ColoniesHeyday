using System;
using System.Collections.Generic;
using UnityEngine;

public class Craftsman : ParentRole {
	
	public int craftingCorn { get; set; }
	public int craftingIndigo { get; set; }
	public int craftingSugar { get; set; }
	public int craftingTobacco { get; set; }
	public int craftingCoffee { get; set; }
	
	public int factoryCraftings { get; set; }
	public bool factoryActive { get; set; }
	
	public void CheckCraftings(Player player) {
		Debug.Log("Capataz comprobarProducciones()");

		InitializeCraftings();
		
		// Variables auxiliares
		Building building;
		List<Plantation> plantations;
		int activeBuildingSlots = 0;
		
		// Miro si tiene la FÁBRICA activa
		if(player.playerBoard.buildings.Find(i => i.type == BuildingType.FACTORY && i.colonists > 0) != null) {
			Debug.Log("El jugador tiene la FÁBRICA activa");
			factoryActive = true;
		}
		
		// Producción Maíz
		// ===============
		Debug.Log("Producción de MAÍZ");
		if(GameData.cornBarrels.Count > 0) {
			plantations = player.playerBoard.plantations.FindAll(i => i.type == PlantationType.CORN && i.colonist > 0);
			craftingCorn = plantations.Count;
			Debug.Log("El jugador puede producir " + craftingCorn);
			// Control barriles en reserva
			if(craftingCorn > GameData.cornBarrels.Count) {
				Debug.Log("Como no hay suficientes barriles, producirá " + GameData.cornBarrels.Count);
				craftingCorn = GameData.cornBarrels.Count;
			}
		} else {
			Debug.Log("No se puede producir MAÍZ porque no hay barriles");
		}
		
		// Producción Añil
		// ===============
		Debug.Log("Producción de AÑIL");
		if(GameData.indigoBarrels.Count > 0) {
			building = player.playerBoard.buildings.Find(i => i.type == BuildingType.SMALL_INDIGO_PLANT);
			if(building != null) {
				activeBuildingSlots += building.colonists;
			}
			building = player.playerBoard.buildings.Find(i => i.type == BuildingType.INDIGO_PLANT);
			if(building != null) {
				activeBuildingSlots += building.colonists;
			}
			if(activeBuildingSlots > 0) {
				plantations = player.playerBoard.plantations.FindAll(i => i.type == PlantationType.INDIGO && i.colonist > 0);
				// Control relación fabricas activas / plantaciones activas
				craftingIndigo = CraftingCalculation(activeBuildingSlots, plantations.Count);
				Debug.Log("El jugador puede producir " + craftingIndigo);
				// Control barriles en reserva
				if(craftingIndigo > GameData.indigoBarrels.Count) {
					Debug.Log("Como no hay suficientes barriles, producirá " + GameData.indigoBarrels.Count);
					craftingIndigo = GameData.indigoBarrels.Count;
				}
			}
		} else {
			Debug.Log("No se puede producir AÑIL porque no hay barriles");
		}
		
		// Producción Azúcar
		// =================
		Debug.Log("Producción de AZÚCAR");
		if(GameData.sugarBarrels.Count > 0) {
			activeBuildingSlots = 0;
			building = player.playerBoard.buildings.Find(i => i.type == BuildingType.SMALL_SUGAR_MILL);
			if(building != null) {
				activeBuildingSlots += building.colonists;
			}
			building = player.playerBoard.buildings.Find(i => i.type == BuildingType.SUGAR_MILL);
			if(building != null) {
				activeBuildingSlots += building.colonists;
			}
			if(activeBuildingSlots > 0) {
				plantations = player.playerBoard.plantations.FindAll(i => i.type == PlantationType.SUGAR && i.colonist > 0);
				// Control relación fabricas activas / plantaciones activas
				craftingSugar = CraftingCalculation(activeBuildingSlots, plantations.Count);
				Debug.Log("El jugador puede producir " + craftingSugar);
				// Control barriles en reserva
				if(craftingSugar > GameData.sugarBarrels.Count) {
					Debug.Log("Como no hay suficientes barriles, producirá " + GameData.sugarBarrels.Count);
					craftingSugar = GameData.sugarBarrels.Count;
				}
			}
		} else {
			Debug.Log("No se puede producir AZÚCAR porque no hay barriles");
		}
		
		// Producción Tabaco
		// =================
		Debug.Log("Producción de TABACO");
		if(GameData.tobaccoBarrels.Count > 0) {
			activeBuildingSlots = 0;
			building = player.playerBoard.buildings.Find(i => i.type == BuildingType.TOBACCO_STORAGE);
			if(building != null) {
				activeBuildingSlots += building.colonists;
			}
			if(activeBuildingSlots > 0) {
				plantations = player.playerBoard.plantations.FindAll(i => i.type == PlantationType.TOBACCO && i.colonist > 0);
				// Control relación fabricas activas / plantaciones activas
				craftingTobacco = CraftingCalculation(activeBuildingSlots, plantations.Count);
				Debug.Log("El jugador puede producir " + craftingTobacco);
				// Control barriles en reserva
				if(craftingTobacco > GameData.tobaccoBarrels.Count) {
					Debug.Log("Como no hay suficientes barriles, producirá " + GameData.tobaccoBarrels.Count);
					craftingTobacco = GameData.tobaccoBarrels.Count;
				}
			}
		} else {
			Debug.Log("No se puede producir TABACO porque no hay barriles");
		}
		
		// Producción Café
		// ===============
		Debug.Log("Producción de CAFÉ");
		if(GameData.coffeeBarrels.Count > 0) {
			activeBuildingSlots = 0;
			building = player.playerBoard.buildings.Find(i => i.type == BuildingType.COFFEE_TOASTER);
			if(building != null) {
				activeBuildingSlots += building.colonists;
			}
			if(activeBuildingSlots > 0) {
				plantations = player.playerBoard.plantations.FindAll(i => i.type == PlantationType.COFFEE && i.colonist > 0);
				// Control relación fabricas activas / plantaciones activas
				craftingCoffee = CraftingCalculation(activeBuildingSlots, plantations.Count);
				Debug.Log("El jugador puede producir " + craftingCoffee);
				// Control barriles en reserva
				if(craftingCoffee > GameData.coffeeBarrels.Count) {
					Debug.Log("Como no hay suficientes barriles, producirá " + GameData.coffeeBarrels.Count);
					craftingCoffee = GameData.coffeeBarrels.Count;
				}
			}
		} else {
			Debug.Log("No se puede producir CAFÉ porque no hay barriles");
		}
		
		if(factoryActive) {
			if(craftingCorn > 0) {
				factoryCraftings++;
			}
			if(craftingIndigo > 0) {
				factoryCraftings++;
			}
			if(craftingSugar > 0) {
				factoryCraftings++;
			}
			if(craftingTobacco > 0) {
				factoryCraftings++;
			}
			if(craftingCoffee > 0) {
				factoryCraftings++;
			}
		}
		Debug.Log("Número de producciones distintas para el bonus de FÁBRICA = " + factoryCraftings);
		Debug.Log("Capataz FIN comprobarProducciones()");
	}
	
	private void InitializeCraftings() {
		craftingCorn = -1;
		craftingIndigo = -1;
		craftingSugar = -1;
		craftingTobacco = -1;
		craftingCoffee = -1;

		factoryCraftings = 0;
		factoryActive = false;
	}
	
	private int CraftingCalculation(int activeBuildingSlots, int activePlantations) {
		Debug.Log("huecosFabricaOcupados: " + activeBuildingSlots + " plantacionesOcupadas: " + activePlantations);
		// Si hay más colonos en la fábrica que en la plantación (o viceversa), devuelve el más pequeño
		if(activeBuildingSlots > activePlantations) {
			return activePlantations;
		} else if(activeBuildingSlots < activePlantations) {
			return activeBuildingSlots;
		}
		// Si son iguales, devuelve uno cualquiera
		return activePlantations;
	}
	
	public void Craft(Player player, UIBarrelReservation UIBarrelReservation, UICentralBoard UICentralBoard) {
		Debug.Log("Capataz producir()");
		// Bucle Maíz
		Debug.Log("Jugador barriles MAÍZ: " + player.playerBoard.cornBarrels.Count);
		Debug.Log("Partida barriles MAÍZ: " + GameData.cornBarrels.Count);
		while(craftingCorn > 0) {
			player.playerBoard.cornBarrels.Add(GameData.cornBarrels[craftingCorn-1]);
			GameData.cornBarrels.Remove(GameData.cornBarrels[craftingCorn-1]);
			craftingCorn--;
		}
		Debug.Log("RESULTADO Jugador barriles MAÍZ: " + player.playerBoard.cornBarrels.Count);
		Debug.Log("RESULTADO Partida barriles MAÍZ: " + GameData.cornBarrels.Count);

		// Bucle Añil
		Debug.Log("Jugador barriles AÑIL: " + player.playerBoard.indigoBarrels.Count);
		Debug.Log("Partida barriles AÑIL: " + GameData.indigoBarrels.Count);
		while(craftingIndigo > 0) {
			player.playerBoard.indigoBarrels.Add(GameData.indigoBarrels[craftingIndigo-1]);
			GameData.indigoBarrels.Remove(GameData.indigoBarrels[craftingIndigo-1]);
			craftingIndigo--;
		}
		Debug.Log("RESULTADO Jugador barriles AÑIL: " + player.playerBoard.indigoBarrels.Count);
		Debug.Log("RESULTADO Partida barriles AÑIL: " + GameData.indigoBarrels.Count);

		// Bucle Azúcar
		Debug.Log("Jugador barriles AZÚCAR: " + player.playerBoard.sugarBarrels.Count);
		Debug.Log("Partida barriles AZÚCAR: " + GameData.sugarBarrels.Count);
		while(craftingSugar > 0) {
			player.playerBoard.sugarBarrels.Add(GameData.sugarBarrels[craftingSugar-1]);
			GameData.sugarBarrels.Remove(GameData.sugarBarrels[craftingSugar-1]);
			craftingSugar--;
		}
		Debug.Log("RESULTADO Jugador barriles AZÚCAR: " + player.playerBoard.sugarBarrels.Count);
		Debug.Log("RESULTADO Partida barriles AZÚCAR: " + GameData.sugarBarrels.Count);

		// Bucle Tabaco
		Debug.Log("Jugador barriles TABACO: " + player.playerBoard.tobaccoBarrels.Count);
		Debug.Log("Partida barriles TABACO: " + GameData.tobaccoBarrels.Count);
		while(craftingTobacco > 0) {
			player.playerBoard.tobaccoBarrels.Add(GameData.tobaccoBarrels[craftingTobacco-1]);
			GameData.tobaccoBarrels.Remove(GameData.tobaccoBarrels[craftingTobacco-1]);
			craftingTobacco--;
		}
		Debug.Log("RESULTADO Jugador barriles TABACO: " + player.playerBoard.tobaccoBarrels.Count);
		Debug.Log("RESULTADO Partida barriles TABACO: " + GameData.tobaccoBarrels.Count);

		// Bucle Café
		Debug.Log("Jugador barriles CAFÉ: " + player.playerBoard.coffeeBarrels.Count);
		Debug.Log("Partida barriles CAFÉ: " + GameData.coffeeBarrels.Count);
		while(craftingCoffee > 0) {
			player.playerBoard.coffeeBarrels.Add(GameData.coffeeBarrels[craftingCoffee-1]);
			GameData.coffeeBarrels.Remove(GameData.coffeeBarrels[craftingCoffee-1]);
			craftingCoffee--;
		}
		Debug.Log("RESULTADO Jugador barriles CAFÉ: " + player.playerBoard.coffeeBarrels.Count);
		Debug.Log("RESULTADO Partida barriles CAFÉ: " + GameData.coffeeBarrels.Count);

		// UI
		player.UIPlayerBoard.GetComponent<UIPlayerBoard>().UICornBarrel.text = player.playerBoard.cornBarrels.Count.ToString();
		player.UIPlayerBoard.GetComponent<UIPlayerBoard>().UIIndigoBarrel.text = player.playerBoard.indigoBarrels.Count.ToString();
		player.UIPlayerBoard.GetComponent<UIPlayerBoard>().UISugarBarrel.text = player.playerBoard.sugarBarrels.Count.ToString();
		player.UIPlayerBoard.GetComponent<UIPlayerBoard>().UITobaccoBarrel.text = player.playerBoard.tobaccoBarrels.Count.ToString();
		player.UIPlayerBoard.GetComponent<UIPlayerBoard>().UICoffeeBarrel.text = player.playerBoard.coffeeBarrels.Count.ToString();
		UIBarrelReservation.UICornBarrels.text = GameData.cornBarrels.Count.ToString();
		UIBarrelReservation.UIIndigoBarrels.text = GameData.indigoBarrels.Count.ToString();
		UIBarrelReservation.UISugarBarrels.text = GameData.sugarBarrels.Count.ToString();
		UIBarrelReservation.UITobaccoBarrels.text = GameData.tobaccoBarrels.Count.ToString();
		UIBarrelReservation.UICoffeeBarrels.text = GameData.coffeeBarrels.Count.ToString();
		
		// Si tiene FÁBRICA activa y produce lo suficiente, se añaden monedas
		Debug.Log("Bonus FÁBRICA");
		if(factoryCraftings > 1) {
			switch(factoryCraftings) {
				case 2: // 2 Tipos de mercancías, 1 moneda
					Debug.Log("2 Tipos de mercancías, 1 moneda");
					if(GameData.bankCoins >= 1) {
						GameData.bankCoins -= 1;
						player.playerBoard.coins += 1;
					}
					break;
				case 3: // 3 Tipos de mercancías, 2 monedas
					Debug.Log("3 Tipos de mercancías, 2 monedas");
					if(GameData.bankCoins < 2) {
						Debug.Log("No hay suficientes monedas en el banco, añado " + GameData.bankCoins);
						player.playerBoard.coins += GameData.bankCoins;
						GameData.bankCoins = 0;
					} else {
						player.playerBoard.coins += 2;
						GameData.bankCoins -= 2;
					}
					break;
				case 4: // 4 Tipos de mercancías, 3 monedas
					Debug.Log("4 Tipos de mercancías, 3 monedas");
					if(GameData.bankCoins < 3) {
						Debug.Log("No hay suficientes monedas en el banco, añado " + GameData.bankCoins);
						player.playerBoard.coins += GameData.bankCoins;
						GameData.bankCoins = 0;
					} else {
						player.playerBoard.coins += 3;
						GameData.bankCoins -= 3;
					}
					break;
				case 5: // 5 Tipos de mercancías, 5 monedas
					Debug.Log("5 Tipos de mercancías, 5 monedas");
					if(GameData.bankCoins < 5) {
						Debug.Log("No hay suficientes monedas en el banco, añado " + GameData.bankCoins);
						player.playerBoard.coins += GameData.bankCoins;
						GameData.bankCoins = 0;
					} else {
						player.playerBoard.coins += 5;
						GameData.bankCoins -= 5;
					}
					break;
				default:
					Debug.Log("No hay bonus de FÁBRICA"); 
					break;
			}
			// UI
			player.UIPlayerBoard.GetComponent<UIPlayerBoard>().UICoins.text = player.playerBoard.coins.ToString();
			UICentralBoard.UICoins.text = GameData.bankCoins.ToString();
		}
		factoryCraftings = 0;
		Debug.Log("Capataz FIN producir()");
	}
	
	public void ExtraCrafting(Player player, UIBarrelReservation UIBarrelReservation, UICentralBoard UICentralBoard) {
		Debug.Log("Capataz producirBarrilExtra()");
		InitializeCraftings();
		switch(UIBarrelReservation.barrelSelected) {
			case PlantationType.CORN:
				craftingCorn = 1; break;
			case PlantationType.INDIGO:
				craftingIndigo = 1; break;
			case PlantationType.SUGAR:
				craftingSugar = 1; break;
			case PlantationType.TOBACCO:
				craftingTobacco = 1; break;
			case PlantationType.COFFEE:
				craftingCoffee = 1; break;
		}
		Craft(player, UIBarrelReservation, UICentralBoard);
		Debug.Log("Capataz FIN producirBarrilExtra()");
	}
}