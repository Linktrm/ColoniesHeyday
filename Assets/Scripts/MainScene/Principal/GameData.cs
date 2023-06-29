using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public static class GameData {

	public static GameLanguage gameLanguage { get; set; }

	public static List<Player> players { get; set; }
	public static List<Player> playersByController { get; set; }
	public static List<Player> finalPlayers { get; set; }
	public static int totalPlayers { get; set; }

	public static bool gameOver { get; set; }

	public static GameStatus gameStatus { get; set; }

	public static GameStatus player1Status { get; set; }
	public static GameStatus player2Status { get; set; }
	public static GameStatus player3Status { get; set; }
	public static GameStatus player4Status { get; set; }
	public static GameStatus player5Status { get; set; }

	public static List<Player> actualRolePlayers { get; set; }
	public static Player actualRolePlayer { get; set; }

	public static int initialCoins { get; set; }
	public static int bankCoins { get; set; } // 86 monedas TOTALES
	public static int victoryPoinsReserve { get; set; } // 122 puntos TOTALES
	public static int colonistReserve { get; set; } // 100 colonos TOTALES
	public static int colonistShip { get; set; }

	public static List<Role> roles { get; set; }
	public static Role actualRole { get; set; }

	public static List<Barrel> cornBarrels { get; set; }
	public static List<Barrel> indigoBarrels { get; set; }
	public static List<Barrel> sugarBarrels { get; set; }
	public static List<Barrel> tobaccoBarrels { get; set; }
	public static List<Barrel> coffeeBarrels { get; set; }
	
	public static Ship ship1 { get; set; }
	public static Ship ship2 { get; set; }
	public static Ship ship3 { get; set; }

	public static List<Plantation> plantationReserve { get; set; }
	public static List<Plantation> plantationsShowed { get; set; }
	public static List<Plantation> quarryReserve { get; set; }

	public static List<Building> listSmallIndigoPlant { get; set; }
	public static List<Building> listSmallSugarMill { get; set; }
	public static List<Building> listSmallMarket { get; set; }
	public static List<Building> listHacienda { get; set; }
	public static List<Building> listConstructionHut { get; set; }
	public static List<Building> listSmallWarehouse { get; set; }
	public static List<Building> listIndigoPlant { get; set; }
	public static List<Building> listSugarMill { get; set; }
	public static List<Building> listHospice { get; set; }
	public static List<Building> listOffice { get; set; }
	public static List<Building> listLargeMarket { get; set; }
	public static List<Building> listLargeWarehouse { get; set; }
	public static List<Building> listTobaccoStorage { get; set; }
	public static List<Building> listCoffeeToaster { get; set; }
	public static List<Building> listFactory { get; set; }
	public static List<Building> listUniversity { get; set; }
	public static List<Building> listHarbor { get; set; }
	public static List<Building> listWharf { get; set; }
	public static Building guildHall { get; set; }
	public static Building residence { get; set; }
	public static Building fortress { get; set; }
	public static Building customsHouse { get; set; }
	public static Building cityHall { get; set; }

	public static List<Barrel> barrilesVentas { get; set; }

	// BARRELS
	public static readonly int NUM_BARREL_MAIZ = 10;
	public static readonly int NUM_BARREL_ANIL = 11;
	public static readonly int NUM_BARREL_AZUCAR = 11;
	public static readonly int NUM_BARREL_TABACO = 9;
	public static readonly int NUM_BARREL_CAFE = 9;

	// BUILDINGS
	public static readonly int NUM_BUILDING_SMALL_INDIGO_PLANT = 4;
	public static readonly int NUM_BUILDING_SMALL_SUGAR_MILL = 4;
	public static readonly int NUM_BUILDING_SMALL_MARKET = 2;
	public static readonly int NUM_BUILDING_HACIENDA = 2;
	public static readonly int NUM_BUILDING_CONSTRUCTION_HUT = 2;
	public static readonly int NUM_BUILDING_SMALL_WAREHOUSE = 2;

	public static readonly int NUM_BUILDING_INDIGO_PLANT = 3;
	public static readonly int NUM_BUILDING_SUGAR_MILL = 3;
	public static readonly int NUM_BUILDING_HOSPICE = 2;
	public static readonly int NUM_BUILDING_OFFICE = 2;
	public static readonly int NUM_BUILDING_LARGE_MARKET = 2;
	public static readonly int NUM_BUILDING_LARGE_WAREHOUSE = 2;

	public static readonly int NUM_BUILDING_TOBACCO_STORAGE = 3;
	public static readonly int NUM_BUILDING_COFFEE_TOASTER = 3;
	public static readonly int NUM_BUILDING_FACTORY = 2;
	public static readonly int NUM_BUILDING_UNIVERSITY = 2;
	public static readonly int NUM_BUILDING_HARBOR = 2;
	public static readonly int NUM_BUILDING_WHARF = 2;

	// PLANTATIONS / QUARRY
	public static readonly int NUM_CANTERAS = 8;
	public static readonly int NUM_PLANTACIONES = 50;

	public static void InitializeEverything() {
		CalculatePlayersPosition();
		InitializeRoles();
		InitializeColonistsCoinsVP();
		InitializeBarrels();
		InitializeShips();
		InitializeBuildings();
		InitializePlantations();
		barrilesVentas = new List<Barrel>(4);
		finalPlayers = new List<Player>(totalPlayers);
	}

	public static void CalculatePlayersPosition() {

		// JUGADOR 1
		int player1 = UnityEngine.Random.Range(0, totalPlayers); // Tirar dado

		int positionAcc = player1;
		for(int acc = 1; acc <= totalPlayers; acc++) {
			Debug.Log(acc + "º " + players[positionAcc].nickname);
			players[positionAcc].position = acc;

			// Siguiente jugador
			positionAcc++;
			if(positionAcc == totalPlayers) {
				positionAcc = 0;
			}
		}

		// Ordenamos la lista de jugadores por posición
		players.Sort((p1,p2)=>p1.position.CompareTo(p2.position));
		
		// Ponemos al primer jugador el Gobernador
		players[0].playerBoard.governor = true;

		/* 
		Por motivos de interfaz, ya no hace falta calcular aleatoriamente el orden de todos jugadores.
		Ya que, al estar ligada la posición del tablero con el numero del controlador, solo hace falta el primero.

		// JUGADOR 2
		int jugador2 = jugador1;
		// Mientras el resultado del dado sea = a las anteriores posiciones
		while(jugador2 == jugador1) {
			jugador2 = UnityEngine.Random.Range(1, numeroJugadores+1); // Tirar dado
		}
		jugadores[1].posicion = jugador2;
		Debug.Log(jugadores[1].nombre + " será el " + jugador2 + "º");
		
		if(numeroJugadores > 2) {
			// JUGADOR 3
			int jugador3 = jugador1;
			// Mientras el resultado del dado sea = a las anteriores posiciones
			while(jugador3 == jugador1 || jugador3 == jugador2) {
				jugador3 = UnityEngine.Random.Range(1, numeroJugadores+1); // Tirar dado
			}
			jugadores[2].posicion = jugador3;
			Debug.Log(jugadores[2].nombre + " será el " + jugador3 + "º");
			
			if(numeroJugadores > 3) {
				// JUGADOR 4
				int jugador4 = jugador1;
				// Mientras el resultado del dado sea = a las anteriores posiciones
				while(jugador4 == jugador1 || jugador4 == jugador2 || jugador4 == jugador3) {
					jugador4 = UnityEngine.Random.Range(1, numeroJugadores+1); // Tirar dado
				}
				jugadores[3].posicion = jugador4;
				Debug.Log(jugadores[3].nombre + " será el " + jugador4 + "º");
				
				if(numeroJugadores > 4) {
					// JUGADOR 5
					int jugador5 = jugador1;
					// Mientras el resultado del dado sea = a las anteriores posiciones
					while(jugador5 == jugador1 || jugador5 == jugador2 || jugador5 == jugador3 || jugador5 == jugador4) {
						jugador5 = UnityEngine.Random.Range(1, numeroJugadores+1); // Tirar dado
					}
					jugadores[4].posicion = jugador5;
					Debug.Log(jugadores[4].nombre + " será el " + jugador5 + "º");
				}
			}
		}
 		*/

		Debug.Log("Comprobación orden correcto:");
		foreach(Player player in players) {
			Debug.Log(player.nickname + " es el " + player.position);
		}
	}

	static void InitializeRoles() {
		roles = new List<Role>(8);
		roles.Add(new Role(RoleTypes.BUILDER));
		roles.Add(new Role(RoleTypes.SETTLER));
		roles.Add(new Role(RoleTypes.MAYOR));
		roles.Add(new Role(RoleTypes.CRAFTSMAN));
		roles.Add(new Role(RoleTypes.CAPTAIN));
		roles.Add(new Role(RoleTypes.TRADER));
	}

	static void InitializeColonistsCoinsVP() {
		colonistShip = totalPlayers;
		switch(totalPlayers) {
			case 2:
				roles.Add(new Role(RoleTypes.PROSPECTOR_1));
				
				colonistReserve = 40; // A estos colonos ya se le han restado los del barco
				bankCoins = 74; // A estas monedas ya se le han restado las iniciales de los jugadores
				victoryPoinsReserve = 65;
				
				initialCoins = 3;

				players[0].playerBoard.coins = initialCoins;
				players[1].playerBoard.coins = initialCoins;
				break;
			case 3:
				colonistReserve = 55; // A estos colonos ya se le han restado los del barco
				bankCoins = 80; // A estas monedas ya se le han restado las iniciales de los jugadores
				victoryPoinsReserve = 75;
				
				initialCoins = 2;

				players[0].playerBoard.coins = initialCoins;
				players[1].playerBoard.coins = initialCoins;
				players[2].playerBoard.coins = initialCoins;
				break;
			case 4:
				roles.Add(new Role(RoleTypes.PROSPECTOR_1));

				colonistReserve = 75; // A estos colonos ya se le han restado los del barco
				bankCoins = 74; // A estas monedas ya se le han restado las iniciales de los jugadores
				victoryPoinsReserve = 100;
				
				initialCoins = 3;

				players[0].playerBoard.coins = initialCoins;
				players[1].playerBoard.coins = initialCoins;
				players[2].playerBoard.coins = initialCoins;
				players[3].playerBoard.coins = initialCoins;
				break;
			case 5:
				roles.Add(new Role(RoleTypes.PROSPECTOR_1));
				roles.Add(new Role(RoleTypes.PROSPECTOR_2));
				
				colonistReserve = 95; // A estos colonos ya se le han restado los del barco
				bankCoins = 66; // A estas monedas ya se le han restado las iniciales de los jugadores
				victoryPoinsReserve = 122;
				
				initialCoins = 4;

				players[0].playerBoard.coins = initialCoins;
				players[1].playerBoard.coins = initialCoins;
				players[2].playerBoard.coins = initialCoins;
				players[3].playerBoard.coins = initialCoins;
				players[4].playerBoard.coins = initialCoins;
				break;
		}
	}

	static void InitializeBarrels() {
		cornBarrels = new List<Barrel>(NUM_BARREL_MAIZ);
		for(int acc = 1; acc <= NUM_BARREL_MAIZ; acc++) {
			cornBarrels.Add(new Barrel(PlantationType.CORN));
		}
		
		indigoBarrels = new List<Barrel>(NUM_BARREL_ANIL);
		for(int acc = 1; acc <= NUM_BARREL_ANIL; acc++) {
			indigoBarrels.Add(new Barrel(PlantationType.INDIGO));
		}
		
		sugarBarrels = new List<Barrel>(NUM_BARREL_AZUCAR);
		for(int acc = 1; acc <= NUM_BARREL_AZUCAR; acc++) {
			sugarBarrels.Add(new Barrel(PlantationType.SUGAR));
		}
		
		tobaccoBarrels = new List<Barrel>(NUM_BARREL_TABACO);
		for(int acc = 1; acc <= NUM_BARREL_TABACO; acc++) {
			tobaccoBarrels.Add(new Barrel(PlantationType.TOBACCO));
		}
		
		coffeeBarrels = new List<Barrel>(NUM_BARREL_CAFE);
		for(int acc = 1; acc <= NUM_BARREL_CAFE; acc++) {
			coffeeBarrels.Add(new Barrel(PlantationType.COFFEE));
		}
	}

	static void InitializeShips() {
		switch(totalPlayers) {
			case 2:
				ship1 = new Ship(6);
				ship2 = new Ship(4);
				break;
			case 3:
				ship1 = new Ship(6);
				ship2 = new Ship(5);
				ship3 = new Ship(4);
				break;
			case 4:
				ship1 = new Ship(7);
				ship2 = new Ship(6);
				ship3 = new Ship(5);
				break;
			case 5:
				ship1 = new Ship(8);
				ship2 = new Ship(7);
				ship3 = new Ship(6);
				break;
		}
	}

	static List<Building> FillBuildingLists(List<Building> listBuilding, BuildingType buildingType, int numberBuildings) {
		listBuilding = new List<Building>(numberBuildings);
		for (int acc = 0; acc < numberBuildings; acc++) listBuilding.Add(new Building(buildingType));
		return listBuilding;
	}

	static void InitializeBuildings() {
		listSmallIndigoPlant = FillBuildingLists(listSmallIndigoPlant, BuildingType.SMALL_INDIGO_PLANT, NUM_BUILDING_SMALL_INDIGO_PLANT);
		listSmallSugarMill = FillBuildingLists(listSmallSugarMill, BuildingType.SMALL_SUGAR_MILL, NUM_BUILDING_SMALL_SUGAR_MILL);
		listSmallMarket = FillBuildingLists(listSmallMarket, BuildingType.SMALL_MARKET, NUM_BUILDING_SMALL_MARKET);
		listHacienda = FillBuildingLists(listHacienda, BuildingType.HACIENDA, NUM_BUILDING_HACIENDA);
		listConstructionHut = FillBuildingLists(listConstructionHut, BuildingType.CONSTRUCTION_HUT, NUM_BUILDING_CONSTRUCTION_HUT);
		listSmallWarehouse = FillBuildingLists(listSmallWarehouse, BuildingType.SMALL_WAREHOUSE, NUM_BUILDING_SMALL_WAREHOUSE);
		
		//
		
		listIndigoPlant = FillBuildingLists(listIndigoPlant, BuildingType.INDIGO_PLANT, NUM_BUILDING_INDIGO_PLANT);
		listSugarMill = FillBuildingLists(listSugarMill, BuildingType.SUGAR_MILL, NUM_BUILDING_SUGAR_MILL);
		listHospice = FillBuildingLists(listHospice, BuildingType.HOSPICE, NUM_BUILDING_HOSPICE);
		listOffice = FillBuildingLists(listOffice, BuildingType.OFFICE, NUM_BUILDING_OFFICE);
		listLargeMarket = FillBuildingLists(listLargeMarket, BuildingType.LARGE_MARKET, NUM_BUILDING_LARGE_MARKET);
		listLargeWarehouse = FillBuildingLists(listLargeWarehouse, BuildingType.LARGE_WAREHOUSE, NUM_BUILDING_LARGE_WAREHOUSE);
		
		//
		
		listTobaccoStorage = FillBuildingLists(listTobaccoStorage, BuildingType.TOBACCO_STORAGE, NUM_BUILDING_TOBACCO_STORAGE);
		listCoffeeToaster = FillBuildingLists(listCoffeeToaster, BuildingType.COFFEE_TOASTER, NUM_BUILDING_COFFEE_TOASTER);
		listFactory = FillBuildingLists(listFactory, BuildingType.FACTORY, NUM_BUILDING_FACTORY);
		listUniversity = FillBuildingLists(listUniversity, BuildingType.UNIVERSITY, NUM_BUILDING_UNIVERSITY);
		listHarbor = FillBuildingLists(listHarbor, BuildingType.HARBOR, NUM_BUILDING_HARBOR);
		listWharf = FillBuildingLists(listWharf, BuildingType.WHARF, NUM_BUILDING_WHARF);
		
		//
		
		guildHall = new Building(BuildingType.GUILD_HALL);
		residence = new Building(BuildingType.RESIDENCE);
		fortress = new Building(BuildingType.FORTRESS);
		customsHouse = new Building(BuildingType.CUSTOMS_HOUSE);
		cityHall = new Building(BuildingType.CITY_HALL);
	}

	static void InitializePlantations() {
		// Inicializamos las plantaciones
		// //////////////////////////////
		
		plantationReserve = new List<Plantation>(NUM_PLANTACIONES);
		quarryReserve = new List<Plantation>(NUM_CANTERAS);
		
		// Ponemos estas cantidades porque son seguras en todo tipo de jugadores.
		// Luego añadimos las que faltan si son menos de 5 jugadores.

		int minCorn = 8; // 8 Maíz
		int minIndigo = 9; // 9 Añil
		int minSugar = 11; // 11 Azúcar
		int minTobacco = 9; // 9 Tabaco
		int minCoffee = 8; // 8 Café

		for(int acc = 0; acc < new int[]{minCorn, minIndigo, minSugar, minTobacco, minCoffee, NUM_CANTERAS}.Max(); acc++) {
			if(acc < minCorn)
				plantationReserve.Add(new Plantation(PlantationType.CORN));
			if(acc < minIndigo)
				plantationReserve.Add(new Plantation(PlantationType.INDIGO));
			if(acc < minSugar)
				plantationReserve.Add(new Plantation(PlantationType.SUGAR));
			if(acc < minTobacco)
				plantationReserve.Add(new Plantation(PlantationType.TOBACCO));
			if(acc < minCoffee)
				plantationReserve.Add(new Plantation(PlantationType.COFFEE));
			if(acc < NUM_CANTERAS)
				quarryReserve.Add(new Plantation(PlantationType.QUARRY));
		}
		
		// Según los jugadores, se restan las plantaciones iniciales (maíz y añil) de los jugadores
		// Y añadimos las plantaciones iniciales a los tableros de los jugadores
		// NOTA: Añadimos a saco con el index de la lista porque hemos ordenado los jugadores previamente en el método CalculatePlayersPosition()
		switch(totalPlayers) {
			case 2:
				plantationReserve.Add(new Plantation(PlantationType.CORN)); // TOTAL 9 Maíz en reserva
				
				plantationReserve.Add(new Plantation(PlantationType.INDIGO));
				plantationReserve.Add(new Plantation(PlantationType.INDIGO)); // TOTAL 11 Añil en reserva
				
				players[0].playerBoard.plantations.Add(new Plantation(PlantationType.INDIGO)); // Añadir Añil al Jugador 1
				players[1].playerBoard.plantations.Add(new Plantation(PlantationType.CORN)); // Añadir Maíz al Jugador 2
				
				break;
			case 3:
				plantationReserve.Add(new Plantation(PlantationType.CORN)); // TOTAL 9 Maíz en reserva
				
				plantationReserve.Add(new Plantation(PlantationType.INDIGO)); // TOTAL 10 Añil en reserva
				
				players[0].playerBoard.plantations.Add(new Plantation(PlantationType.INDIGO)); // Añadir Añil al Jugador 1
				players[1].playerBoard.plantations.Add(new Plantation(PlantationType.INDIGO)); // Añadir Añil al Jugador 2
				players[2].playerBoard.plantations.Add(new Plantation(PlantationType.CORN)); // Añadir Maíz al Jugador 3
				break;
			case 4:
				plantationReserve.Add(new Plantation(PlantationType.INDIGO)); // TOTAL 10 Añil en reserva
				
				players[0].playerBoard.plantations.Add(new Plantation(PlantationType.INDIGO)); // Añadir Añil al Jugador 1
				players[1].playerBoard.plantations.Add(new Plantation(PlantationType.INDIGO)); // Añadir Añil al Jugador 2
				players[2].playerBoard.plantations.Add(new Plantation(PlantationType.CORN)); // Añadir Maíz al Jugador 3
				players[3].playerBoard.plantations.Add(new Plantation(PlantationType.CORN)); // Añadir Maíz al Jugador 4
				break;
			case 5:
				players[0].playerBoard.plantations.Add(new Plantation(PlantationType.INDIGO)); // Añadir Añil al Jugador 1
				players[1].playerBoard.plantations.Add(new Plantation(PlantationType.INDIGO)); // Añadir Añil al Jugador 2
				players[2].playerBoard.plantations.Add(new Plantation(PlantationType.INDIGO)); // Añadir Añil al Jugador 3
				players[3].playerBoard.plantations.Add(new Plantation(PlantationType.CORN)); // Añadir Maíz al Jugador 4
				players[4].playerBoard.plantations.Add(new Plantation(PlantationType.CORN)); // Añadir Maíz al Jugador 5
				break;
		}

		// PLANTACIONES DESCUBIERTAS
		plantationsShowed = new List<Plantation>(totalPlayers + 1);

		ResetPlantations();
	}

	public static void ResetPlantations() {
		Debug.Log("ResetPlantations()");

		Debug.Log("Añadimos las plantaciones mostradas (" + plantationsShowed.Count + ") a la reserva (" + plantationReserve.Count + ")");

        // Primero desechar las sobrantes (si hay)
		plantationReserve.AddRange(plantationsShowed);
		plantationsShowed.Clear();
		//

		Debug.Log("Plantaciones mostradas = " + plantationsShowed.Count);
		Debug.Log("Plantaciones en reserva (antes): " + plantationReserve.Count);
		
		if(plantationReserve.Count > 0) { // Si al menos hay 1 plantación en reserva
			// Generar 5 Randoms con las plantaciones a mostrar
			int randomNumber = 0;
			int indexPlantation1 = -1;
			int indexPlantation2 = -1;
			int indexPlantation3 = -1;
			int indexPlantation4 = -1;
			int indexPlantation5 = -1;
			int indexPlantation6 = -1;
			Plantation plantation1 = null;
			Plantation plantation2 = null;
			Plantation plantation3 = null;
			Plantation plantation4 = null;
			Plantation plantation5 = null;
			Plantation plantation6 = null;
			
			// PLANTACIÓN 1
			randomNumber = UnityEngine.Random.Range(0, plantationReserve.Count); // Tirar dado
			indexPlantation1 = randomNumber;
			plantation1 = plantationReserve[indexPlantation1];
			Debug.Log("Plantación 1 = " + plantation1.type);
			plantationsShowed.Add(plantation1); // Ponemos la nueva plantación en las plantaciones descubiertas
			
			// PLANTACIÓN 2
			if(plantationReserve.Count > 1) { // Si al menos hay 2 plantación en reserva
				
				// Mientras el resultado del dado sea = a las anteriores posiciones
				while(randomNumber == indexPlantation1) {
					randomNumber = UnityEngine.Random.Range(0, plantationReserve.Count); // Tirar dado
				}
				indexPlantation2 = randomNumber;
				plantation2 = plantationReserve[indexPlantation2];
				Debug.Log("Plantación 2 = " + plantation2.type);
				plantationsShowed.Add(plantation2); // Ponemos la nueva plantación en las plantaciones descubiertas
				
				// PLANTACIÓN 3
				if(plantationReserve.Count > 2) { // Si al menos hay 3 plantaciones en reserva
					
					// Mientras el resultado del dado sea = a las anteriores posiciones
					while(randomNumber == indexPlantation1 || randomNumber == indexPlantation2) {
						randomNumber = UnityEngine.Random.Range(0, plantationReserve.Count); // Tirar dado
					}
					indexPlantation3 = randomNumber;
					plantation3 = plantationReserve[indexPlantation3];
					Debug.Log("Plantación 3 = " + plantation3.type);
					plantationsShowed.Add(plantation3); // Ponemos la nueva plantación en las plantaciones descubiertas
					
					// PLANTACIÓN 4
					if((totalPlayers + 1) > 3 && plantationReserve.Count > 3) { // Si son al menos 3 jugadores y al menos hay 4 plantaciones en reserva
						
						// Mientras el resultado del dado sea = a las anteriores posiciones
						while(randomNumber == indexPlantation1 || randomNumber == indexPlantation2 || randomNumber == indexPlantation3) {
							randomNumber = UnityEngine.Random.Range(0, plantationReserve.Count); // Tirar dado
						}
						indexPlantation4 = randomNumber;
						plantation4 = plantationReserve[indexPlantation4];
						Debug.Log("Plantación 4 = " + plantation4.type);
						plantationsShowed.Add(plantation4); // Ponemos la nueva plantación en las plantaciones descubiertas

						// PLANTACIÓN 5
						if((totalPlayers + 1) > 4 && plantationReserve.Count > 4) { // Si son al menos 4 jugadores y al menos hay 5 plantaciones en reserva
							
							// Mientras el resultado del dado sea = a las anteriores posiciones
							while(randomNumber == indexPlantation1 || randomNumber == indexPlantation2 || randomNumber == indexPlantation3 || randomNumber == indexPlantation4) {
								randomNumber = UnityEngine.Random.Range(0, plantationReserve.Count); // Tirar dado
							}
							indexPlantation5 = randomNumber;
							plantation5 = plantationReserve[indexPlantation5];
							Debug.Log("Plantación 5 = " + plantation5.type);
							plantationsShowed.Add(plantation5); // Ponemos la nueva plantación en las plantaciones descubiertas
							
							// PLANTACIÓN 6
							if((totalPlayers + 1) > 5 && plantationReserve.Count > 5) { // Si son al menos 5 jugadores y al menos hay 6 plantaciones en reserva
								
								// Mientras el resultado del dado sea = a las anteriores posiciones
								while(randomNumber == indexPlantation1 || randomNumber == indexPlantation2 || randomNumber == indexPlantation3 || randomNumber == indexPlantation4 || randomNumber == indexPlantation5) {
									randomNumber = UnityEngine.Random.Range(0, plantationReserve.Count); // Tirar dado
								}
								indexPlantation6 = randomNumber;
								plantation6 = plantationReserve[indexPlantation6];
								Debug.Log("Plantación 6 = " + plantation6.type);
								plantationsShowed.Add(plantation6); // Ponemos la nueva plantación en las plantaciones descubiertas
								//
							}
						}
					}
				}
			}
			// Vaciamos las plantaciones de la reserva
			if(plantation1 != null)
				plantationReserve.Remove(plantation1); 
			if(plantation2 != null)
				plantationReserve.Remove(plantation2);
			if(plantation3 != null)
				plantationReserve.Remove(plantation3);
			if(plantation4 != null)
				plantationReserve.Remove(plantation4);
			if(plantation5 != null)
				plantationReserve.Remove(plantation5);
			if(plantation6 != null)
				plantationReserve.Remove(plantation6);
		}
		Debug.Log("Plantaciones en reserva (después): " + plantationReserve.Count);
	}

	public static void MovePlayerPosition() {
		// Avanzar posición

		players[0].playerBoard.governor = false;

		foreach(Player player in players) {
			player.position--; // 2º -> 1º
			if(player.position < 1) {
				player.position = totalPlayers; // 1º -> último
			}
			player.actualRole = null;
			// UI
			player.UIPlayerBoard.GetComponent<UIPlayerBoard>().UIActualRole.SetActive(false);
			player.UIPlayerBoard.GetComponent<UIPlayerBoard>().UIGovernor.SetActive(false);
		}
		// Ordenamos la lista de jugadores por posición
		players.Sort((p1,p2)=>p1.position.CompareTo(p2.position));

		Debug.Log("El nuevo orden es:");
		foreach(Player player in players) {
			Debug.Log(player.position + "º " + player.nickname);
		}

		// Ponemos al primer jugador el Gobernador
		players[0].playerBoard.governor = true;
		// UI
		players[0].UIPlayerBoard.GetComponent<UIPlayerBoard>().UIGovernor.SetActive(true);
	}

	public static void FulfillRolePlayerList(Player player) {
		Debug.Log("El orden a ejecutar el Role será:");

		// Rellenamos la lista de jugadores con el orden para el Role actual
		int accPosicion = players.IndexOf(actualRolePlayer);
		actualRolePlayers = new List<Player>(totalPlayers);
		for(int acc = 1; acc <= totalPlayers; acc++) {
			Debug.Log(acc + "º " + players[accPosicion].nickname);
			actualRolePlayers.Add(players[accPosicion]);

			// Siguiente jugador
			accPosicion++;
			if(accPosicion == totalPlayers) {
				accPosicion = 0;
			}
		}
		Debug.Log("===============================");
	}

	public static int NegativeControl(int number) {
		if(number < 0) {
			return 0;
		}
		return number;
	}

	
	public static void guardarDatosNuevaPartida() {
		
		// TODO Teniendo todos los DatosPartidaJugador en la List<Jugadores>, se pasa todo al archivo Partidas.txt con una nueva partida
		
	}
	
	public static void leerDatosPartida(String[] datos) {
		
		// TODO Pasando los datos de la partida, rellena la List<Jugadores> con sus DatosPartidaJugador
		
	}
	
}