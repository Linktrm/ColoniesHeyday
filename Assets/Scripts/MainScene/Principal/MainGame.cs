using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGame : MonoBehaviour {

	public GameObject playerBoard1;
	public GameObject playerBoard2;
	public GameObject playerBoard3;
	public GameObject playerBoard4;
	public GameObject playerBoard5;

	public GameObject centralBoard;
	public GameObject shipBoard;
	public GameObject sellHouse;
	public GameObject barrelReservation;
	public GameObject VPReservation;
	public GameObject plantationBoard;
	public GameObject colonistsBoard;
	public GameObject roleBoard;
	
	Mayor mayor { get; set; }
	Prospector prospector { get; set; }
	Craftsman craftsman { get; set; }
	Captain captain { get; set; }
	Settler settler { get; set; }
	Builder builder { get; set; }
	Trader trader { get; set; }

	InputType input { get; set; }

	InputType player1Input { get; set; }
	InputType player2Input { get; set; }
	InputType player3Input { get; set; }
	InputType player4Input { get; set; }
	InputType player5Input { get; set; }

	// Use this for initialization
	void Start () {
		GameData.gameStatus = GameStatus.GAME_LOADING;

		// TODO Viene dada de la esena anterior o del panel de configuración
		GameData.gameLanguage = GameLanguage.SPANISH;

		/*
		// NOS VIENE DADA LA LISTA DE JUGADORES DE LA ESCENA ANTERIOR Y SUS RESPECTIVOS MANDOS
		// FIXME lo borraremos cuando esté hecha la escena anterior
		*/
		GameData.playersByController = new List<Player>(5);
		GameData.playersByController.Add(new Player("Toni", 1));
		GameData.playersByController.Add(new Player("Alva", 2));
		GameData.playersByController.Add(new Player("Óscar", 3));
		GameData.playersByController.Add(new Player("Edu", 4));
		GameData.playersByController.Add(new Player("Sergio", 5));

		// Pasamos los jugadores a la lista interna de jugadores por posicion
		GameData.totalPlayers = GameData.playersByController.Count;
		GameData.players = new List<Player>(GameData.totalPlayers);
		foreach(Player jugador in GameData.playersByController) {
			jugador.UIPlayerBoard = GetUIPlayerBoardByController(jugador.controller);
			GameData.players.Add(jugador);
		}
		// ==============================

		// Inicializamos la mayor parte del juego
		GameData.InitializeEverything();

		// Inicializamos los diferentes módulos del juegos
		mayor = new Mayor();
		prospector = new Prospector();
		craftsman = new Craftsman();
		captain = new Captain();
		settler = new Settler();
		builder = new Builder();
		trader = new Trader();

		GameData.gameOver = false;

		// Actualizamos toda la UI asignando los valores iniciales generados anteriormente
		UIactualizarLabelsInicial();
		
		// Emprezamos la corrutina principal
		StartCoroutine(MainLoop());
	}

	GameObject GetUIPlayerBoardByController(int controller) {
		switch(controller) {
			case 1:
				return playerBoard1;
			case 2:
				return playerBoard2;
			case 3:
				return playerBoard3;
			case 4:
				return playerBoard4;
			case 5:
				return playerBoard5;
		}
		return null;
	}
	
	// Update is called once per frame
	void Update () {

		if(GameData.gameStatus == GameStatus.PLAYER1_CHOOSE_ROLE_INPUT) {
			UISelectRole(1);
		} else if(GameData.gameStatus == GameStatus.PLAYER2_CHOOSE_ROLE_INPUT) {
			UISelectRole(2);
		} else if(GameData.gameStatus == GameStatus.PLAYER3_CHOOSE_ROLE_INPUT) {
			UISelectRole(3);
		} else if(GameData.gameStatus == GameStatus.PLAYER4_CHOOSE_ROLE_INPUT) {
			UISelectRole(4);
		} else if(GameData.gameStatus == GameStatus.PLAYER5_CHOOSE_ROLE_INPUT) {
			UISelectRole(5);
		} else if(GameData.gameStatus == GameStatus.ROLE_BUILDER_PLAYER_CHOOSE_BUILDING) {
			UISelectBuilding(GameData.actualRolePlayer.controller);
		} else if(GameData.gameStatus == GameStatus.ROLE_MAYOR_PLACING) {
			// Lo hago para que se puedan mover todos en el mismo frame
			// PLAYER 1
			if(GameData.player1Status == GameStatus.ROLE_MAYOR_PLAYER1_PLACING) {
				player1Input = UISelectColonistPlayer(1, player1Input, playerBoard1.GetComponent<UIPlayerBoard>());
			} else if(GameData.player1Status == GameStatus.ROLE_MAYOR_PLAYER1_FINISHED) {
				// Si el jugador pulsa Cancel
				if(InputManager.Cancel(1)) {
					Debug.Log("El jugador 1 vuelve a colocar");
					playerBoard1.GetComponent<UIPlayerBoard>().UIPanelFinished.SetActive(false);
					playerBoard1.GetComponent<UIPlayerBoard>().SelectFirstSlotAvailableMayor();
					GameData.player1Status = GameStatus.ROLE_MAYOR_PLAYER1_PLACING;
				}
			}
			// PLAYER 2
			if(GameData.player2Status == GameStatus.ROLE_MAYOR_PLAYER2_PLACING) {
				player2Input = UISelectColonistPlayer(2, player2Input, playerBoard2.GetComponent<UIPlayerBoard>());
			} else if(GameData.player2Status == GameStatus.ROLE_MAYOR_PLAYER2_FINISHED) {
				// Si el jugador pulsa Cancel
				if(InputManager.Cancel(2)) {
					Debug.Log("El jugador 2 vuelve a colocar");
					playerBoard2.GetComponent<UIPlayerBoard>().UIPanelFinished.SetActive(false);
					playerBoard2.GetComponent<UIPlayerBoard>().SelectFirstSlotAvailableMayor();
					GameData.player2Status = GameStatus.ROLE_MAYOR_PLAYER2_PLACING;
				}
			}
			if(GameData.totalPlayers > 2) {
				// PLAYER 3
				if(GameData.player3Status == GameStatus.ROLE_MAYOR_PLAYER3_PLACING) {
					player3Input = UISelectColonistPlayer(3, player3Input, playerBoard3.GetComponent<UIPlayerBoard>());
				} else if(GameData.player3Status == GameStatus.ROLE_MAYOR_PLAYER3_FINISHED) {
					// Si el jugador pulsa Cancel
					if(InputManager.Cancel(3)) {
						Debug.Log("El jugador 3 vuelve a colocar");
						playerBoard3.GetComponent<UIPlayerBoard>().UIPanelFinished.SetActive(false);
						playerBoard3.GetComponent<UIPlayerBoard>().SelectFirstSlotAvailableMayor();
						GameData.player3Status = GameStatus.ROLE_MAYOR_PLAYER3_PLACING;
					}
				}
				if(GameData.totalPlayers > 3) {
					// PLAYER 4
					if(GameData.player4Status == GameStatus.ROLE_MAYOR_PLAYER4_PLACING) {
						player4Input = UISelectColonistPlayer(4, player4Input, playerBoard4.GetComponent<UIPlayerBoard>());
					} else if(GameData.player4Status == GameStatus.ROLE_MAYOR_PLAYER4_FINISHED) {
						// Si el jugador pulsa Cancel
						if(InputManager.Cancel(4)) {
							Debug.Log("El jugador 4 vuelve a colocar");
							playerBoard4.GetComponent<UIPlayerBoard>().UIPanelFinished.SetActive(false);
							playerBoard4.GetComponent<UIPlayerBoard>().SelectFirstSlotAvailableMayor();
							GameData.player4Status = GameStatus.ROLE_MAYOR_PLAYER4_PLACING;
						}
					}
					if(GameData.totalPlayers > 4) {
						// PLAYER 5
						if(GameData.player5Status == GameStatus.ROLE_MAYOR_PLAYER5_PLACING) {
							player5Input = UISelectColonistPlayer(5, player5Input, playerBoard5.GetComponent<UIPlayerBoard>());
						} else if(GameData.player5Status == GameStatus.ROLE_MAYOR_PLAYER5_FINISHED) {
							// Si el jugador pulsa Cancel
							if(InputManager.Cancel(5)) {
								Debug.Log("El jugador 5 vuelve a colocar");
								playerBoard5.GetComponent<UIPlayerBoard>().UIPanelFinished.SetActive(false);
								playerBoard5.GetComponent<UIPlayerBoard>().SelectFirstSlotAvailableMayor();
								GameData.player5Status = GameStatus.ROLE_MAYOR_PLAYER5_PLACING;
							}
						}
					}
				}
			}
			// Calculamos si todos los jugadores han acabado de colocar y salimos
			if(CalculatePlayersMayorPlacingFinished()) {
				playerBoard1.GetComponent<UIPlayerBoard>().UIPanelFinished.SetActive(false);
				playerBoard2.GetComponent<UIPlayerBoard>().UIPanelFinished.SetActive(false);
				if(GameData.totalPlayers > 2) {
					playerBoard3.GetComponent<UIPlayerBoard>().UIPanelFinished.SetActive(false);
					if(GameData.totalPlayers > 3) {
						playerBoard4.GetComponent<UIPlayerBoard>().UIPanelFinished.SetActive(false);
						if(GameData.totalPlayers > 4)
							playerBoard5.GetComponent<UIPlayerBoard>().UIPanelFinished.SetActive(false);
					}
				}
				GameData.gameStatus = GameStatus.ROLE_MAYOR_PLACING_FINISHED;
			}
		} else if(GameData.gameStatus == GameStatus.ROLE_CRAFTSMAN_PLAYER_CHOOSE_EXTRA) {
			UISelectExtraBarrel(GameData.actualRolePlayer.controller);
		} else if(GameData.gameStatus == GameStatus.ROLE_SETTLER_PLAYER_CHOOSE_EXTRA) {
			UISelectExtraPlantation(GameData.actualRolePlayer.controller);
		} else if(GameData.gameStatus == GameStatus.ROLE_SETTLER_PLAYER_CHOOSE_PLANTATION) {
			UISelectPlantation(GameData.actualRolePlayer.controller);
		} else if(GameData.gameStatus == GameStatus.ROLE_TRADER_PLAYER_CHOOSE_BARREL) {
			UISelectBarrelTrader(GameData.actualRolePlayer.controller);
		} else if(GameData.gameStatus == GameStatus.ROLE_CAPTAIN_PLAYER_CHOOSE_BARREL) {
			UISelectBarrelCaptain(GameData.actualRolePlayer.controller);
		} else if(GameData.gameStatus == GameStatus.ROLE_CAPTAIN_PLAYER_CHOOSE_SHIP) {
			UISelectShipCaptain(GameData.actualRolePlayer.controller);
		} else if(GameData.gameStatus == GameStatus.ROLE_CAPTAIN_PLAYER_CHOOSE_SPOIL) {
			UISelectSpoilCaptain(GameData.actualRolePlayer.controller);
		}

	}

	// ==============
	// ROLE SELECTION
	// ==============

	UIRoleBoard GetScriptUIRoleBoard() {
		switch(GameData.totalPlayers) {
			case 2:
				return roleBoard.GetComponent<UIRoleBoard2P>();
			case 3:
				return roleBoard.GetComponent<UIRoleBoard3P>();
			case 4:
				return roleBoard.GetComponent<UIRoleBoard4P>();
			case 5:
				return roleBoard.GetComponent<UIRoleBoard5P>();
		}
		return null;
	}

	void UISelectRole(int playerController) {
		input = InputManager.CalculateIdle(playerController, input);

		if(input == InputManager.GetIdle(playerController)) {
			//Debug.Log("=====El input es IDLE, MOVE CURSOR");
			input = GetScriptUIRoleBoard().MoveCursor(InputManager.Horizontal(playerController, input), InputManager.Vertical(playerController, input), playerController);
		}
		//Debug.Log("Input = " + input);

		// Si el jugador pulsa Submit
		if(InputManager.Submit(playerController)) {

			// TODO Diálogo de confirmación? (Aceptar/Cancelar)

			// Asignamos RoleActual (Core)
			GameData.actualRole = GameData.roles.Find(i => i.type == GetScriptUIRoleBoard().roleSelected);
			GameData.actualRole.usedRole = true;
			GameData.actualRolePlayer.actualRole = GameData.actualRole;

			// Asignamos RoleActual (UI)
			GameData.actualRolePlayer.UIPlayerBoard.GetComponent<UIPlayerBoard>().UIFrameActualRole.GetComponent<Image>().sprite = GameData.actualRolePlayer.UIPlayerBoard.GetComponent<UIPlayerBoard>().UIRoleFrame;
			switch(GameData.actualRole.type) {
				case RoleTypes.BUILDER:
					Debug.Log("ROLE BUILDER");
					// Asignamos Role al Tablero del Jugador
					GameData.actualRolePlayer.UIPlayerBoard.GetComponent<UIPlayerBoard>().UIAssignRole(GetScriptUIRoleBoard().UIRoleBuilder.GetComponent<Image>().sprite);
					// Desactivamos Role de la reserva
					GetScriptUIRoleBoard().UIRoleBuilder.SetActive(false);
					GetScriptUIRoleBoard().UIFrameBuilder.GetComponent<Image>().sprite = GetScriptUIRoleBoard().UIRoleFrameTransparent;
					// Cambiamos estado a START
					GameData.gameStatus = GameStatus.ROLE_BUILDER_START;
					break;
				case RoleTypes.SETTLER:
					Debug.Log("ROLE SETTLER");
					// Asignamos Role al Tablero del Jugador
					GameData.actualRolePlayer.UIPlayerBoard.GetComponent<UIPlayerBoard>().UIAssignRole(GetScriptUIRoleBoard().UIRoleSettler.GetComponent<Image>().sprite);
					// Desactivamos Role de la reserva
					GetScriptUIRoleBoard().UIRoleSettler.SetActive(false);
					GetScriptUIRoleBoard().UIFrameSettler.GetComponent<Image>().sprite = GetScriptUIRoleBoard().UIRoleFrameTransparent;
					// Cambiamos estado a START
					GameData.gameStatus = GameStatus.ROLE_SETTLER_START;
					break;
				case RoleTypes.MAYOR:
					Debug.Log("ROLE MAYOR");
					// Asignamos Role al Tablero del Jugador
					GameData.actualRolePlayer.UIPlayerBoard.GetComponent<UIPlayerBoard>().UIAssignRole(GetScriptUIRoleBoard().UIRoleMayor.GetComponent<Image>().sprite);
					// Desactivamos Role de la reserva
					GetScriptUIRoleBoard().UIRoleMayor.SetActive(false);
					GetScriptUIRoleBoard().UIFrameMayor.GetComponent<Image>().sprite = GetScriptUIRoleBoard().UIRoleFrameTransparent;
					// Cambiamos estado a START
					GameData.gameStatus = GameStatus.ROLE_MAYOR_START;
					break;
				case RoleTypes.CRAFTSMAN:
					Debug.Log("ROLE CRAFTSMAN");
					// Asignamos Role al Tablero del Jugador
					GameData.actualRolePlayer.UIPlayerBoard.GetComponent<UIPlayerBoard>().UIAssignRole(GetScriptUIRoleBoard().UIRoleCraftsman.GetComponent<Image>().sprite);
					// Desactivamos Role de la reserva
					GetScriptUIRoleBoard().UIRoleCraftsman.SetActive(false);
					GetScriptUIRoleBoard().UIFrameCraftsman.GetComponent<Image>().sprite = GetScriptUIRoleBoard().UIRoleFrameTransparent;
					// Cambiamos estado a START
					GameData.gameStatus = GameStatus.ROLE_CRAFTSMAN_START;
					break;
				case RoleTypes.CAPTAIN:
					Debug.Log("ROLE CAPTAIN");
					// Asignamos Role al Tablero del Jugador
					GameData.actualRolePlayer.UIPlayerBoard.GetComponent<UIPlayerBoard>().UIAssignRole(GetScriptUIRoleBoard().UIRoleCaptain.GetComponent<Image>().sprite);
					// Desactivamos Role de la reserva
					GetScriptUIRoleBoard().UIRoleCaptain.SetActive(false);
					GetScriptUIRoleBoard().UIFrameCaptain.GetComponent<Image>().sprite = GetScriptUIRoleBoard().UIRoleFrameTransparent;
					// Cambiamos estado a START
					GameData.gameStatus = GameStatus.ROLE_CAPTAIN_START;
					break;
				case RoleTypes.TRADER:
					Debug.Log("ROLE TRADER");
					// Asignamos Role al Tablero del Jugador
					GameData.actualRolePlayer.UIPlayerBoard.GetComponent<UIPlayerBoard>().UIAssignRole(GetScriptUIRoleBoard().UIRoleTrader.GetComponent<Image>().sprite);
					// Desactivamos Role de la reserva
					GetScriptUIRoleBoard().UIRoleTrader.SetActive(false);
					GetScriptUIRoleBoard().UIFrameTrader.GetComponent<Image>().sprite = GetScriptUIRoleBoard().UIRoleFrameTransparent;
					// Cambiamos estado a START
					GameData.gameStatus = GameStatus.ROLE_TRADER_START;
					break;
				case RoleTypes.PROSPECTOR_1:
					Debug.Log("ROLE PROSPECTOR_1");
					// Asignamos Role al Tablero del Jugador
					GameData.actualRolePlayer.UIPlayerBoard.GetComponent<UIPlayerBoard>().UIAssignRole(GetScriptUIRoleBoard().UIRoleProspector1.GetComponent<Image>().sprite);
					// Desactivamos Role de la reserva
					GetScriptUIRoleBoard().UIRoleProspector1.SetActive(false);
					GetScriptUIRoleBoard().UIFrameProspector1.GetComponent<Image>().sprite = GetScriptUIRoleBoard().UIRoleFrameTransparent;
					// Cambiamos estado a START
					GameData.gameStatus = GameStatus.ROLE_PROSPECTOR_START;
					break;
				case RoleTypes.PROSPECTOR_2:
					Debug.Log("ROLE PROSPECTOR_2");
					// Asignamos Role al Tablero del Jugador
					GameData.actualRolePlayer.UIPlayerBoard.GetComponent<UIPlayerBoard>().UIAssignRole(GetScriptUIRoleBoard().UIRoleProspector2.GetComponent<Image>().sprite);
					// Desactivamos Role de la reserva
					GetScriptUIRoleBoard().UIRoleProspector2.SetActive(false);
					GetScriptUIRoleBoard().UIFrameProspector2.GetComponent<Image>().sprite = GetScriptUIRoleBoard().UIRoleFrameTransparent;
					// Cambiamos estado a START
					GameData.gameStatus = GameStatus.ROLE_PROSPECTOR_START;
					break;
			}
		}
	}

	// =======
	// BUILDER
	// =======

	void UISelectBuilding(int playerController) {
		input = InputManager.CalculateIdle(playerController, input);

		if(input == InputManager.GetIdle(playerController)) {
			//Debug.Log("=====El input es IDLE, MOVE CURSOR");
			input = centralBoard.GetComponent<UICentralBoard>().MoveCursor(InputManager.Horizontal(playerController, input), InputManager.Vertical(playerController, input), playerController);
		}
		//Debug.Log("Input = " + input);

		// Si el jugador pulsa Submit
		if(InputManager.Submit(playerController)) {
			Debug.Log("Edificio escogido = " + centralBoard.GetComponent<UICentralBoard>().buildingSelected);

			// TODO Diálogo de confirmación? (Aceptar/Cancelar)
			
			ActionResult resultadoAccion = builder.BuyBuilding(GameData.actualRolePlayer, UIGetBuildingFromReserve(centralBoard.GetComponent<UICentralBoard>().buildingSelected), centralBoard.GetComponent<UICentralBoard>(), GetScriptUIColonistShip());
			
			// TODO ANIMACIONES
			GameData.gameStatus = GameStatus.ROLE_BUILDER_ANIM_BUILDING;

			if(resultadoAccion == ActionResult.BUILDING_SLOTS_FULL) {
				GameData.gameOver = true;
				// TODO MOSTRAR MENSAJE ÚLTIMA RONDA
			}

			GameData.gameStatus = GameStatus.ROLE_BUILDER_PLAYER_CHOOSE_BUILDING_FINISHED;
		} else if(InputManager.Cancel(playerController)) {

			// TODO Diálogo de confirmación? (Aceptar/Cancelar)
			
			Debug.Log("El jugador no ha querido comprar");
			GameData.gameStatus = GameStatus.ROLE_BUILDER_PLAYER_CHOOSE_BUILDING_FINISHED;
		}
	}

	Building UIGetBuildingFromReserve(BuildingType type) {
		switch(type) {
			case BuildingType.SMALL_INDIGO_PLANT:
				return GameData.listSmallIndigoPlant[0];
			case BuildingType.SMALL_SUGAR_MILL:
				return GameData.listSmallSugarMill[0];
			case BuildingType.SMALL_MARKET:
				return GameData.listSmallMarket[0];
			case BuildingType.HACIENDA:
				return GameData.listHacienda[0];
			case BuildingType.CONSTRUCTION_HUT:
				return GameData.listConstructionHut[0];
			case BuildingType.SMALL_WAREHOUSE:
				return GameData.listSmallWarehouse[0];
			case BuildingType.INDIGO_PLANT:
				return GameData.listIndigoPlant[0];
			case BuildingType.SUGAR_MILL:
				return GameData.listSugarMill[0];
			case BuildingType.HOSPICE:
				return GameData.listHospice[0];
			case BuildingType.OFFICE:
				return GameData.listOffice[0];
			case BuildingType.LARGE_MARKET:
				return GameData.listLargeMarket[0];
			case BuildingType.LARGE_WAREHOUSE:
				return GameData.listLargeWarehouse[0];
			case BuildingType.TOBACCO_STORAGE:
				return GameData.listTobaccoStorage[0];
			case BuildingType.COFFEE_TOASTER:
				return GameData.listCoffeeToaster[0];
			case BuildingType.FACTORY:
				return GameData.listFactory[0];
			case BuildingType.UNIVERSITY:
				return GameData.listUniversity[0];
			case BuildingType.HARBOR:
				return GameData.listHarbor[0];
			case BuildingType.WHARF:
				return GameData.listWharf[0];
			case BuildingType.GUILD_HALL:
				return GameData.guildHall;
			case BuildingType.RESIDENCE:
				return GameData.residence;
			case BuildingType.FORTRESS:
				return GameData.fortress;
			case BuildingType.CUSTOMS_HOUSE:
				return GameData.customsHouse;
			case BuildingType.CITY_HALL:
				return GameData.cityHall;
		}
		return null;
	}

	// =====
	// MAYOR
	// =====

	UIColonistShip GetScriptUIColonistShip() {
		switch(GameData.totalPlayers) {
			case 2:
				return colonistsBoard.GetComponent<UIColonistShip2P>();
			case 3:
				return colonistsBoard.GetComponent<UIColonistShip3P>();
			case 4:
				return colonistsBoard.GetComponent<UIColonistShip4P>();
			case 5:
				return colonistsBoard.GetComponent<UIColonistShip5P>();
		}
		return null;
	}

	InputType UISelectColonistPlayer(int playerController, InputType playerInput, UIPlayerBoard UITablero) {
		// MOVE CURSOR
		//if(playerController == 1) {
			//Debug.Log("VOY A CALCULAR IDLE PARA PLAYER "+playerController+" CON EL INPUT = " + playerInput);
		//}
		playerInput = InputManager.CalculateIdle(playerController, playerInput);
		if(playerInput == InputManager.GetIdle(playerController)) {
			//Debug.Log("=====El input es IDLE, MOVE CURSOR");
			//if(playerController == 1) {
				//Debug.Log("MOVE CURSOR PLAYER "+playerController+" = " + UITablero.MoveCursorMayor(InputManager.Horizontal(playerController, playerInput), InputManager.Vertical(playerController, playerInput), playerController));
			//}
			playerInput = UITablero.MoveCursorMayor(InputManager.Horizontal(playerController, playerInput), InputManager.Vertical(playerController, playerInput), playerController);
		}
		//if(playerController == 1) {
			//Debug.Log("INPUT PLAYER "+playerController+" = " + playerInput);
		//}
		// SUBMIT (Añadir colono)
		if(InputManager.Submit(playerController) && GameData.playersByController[playerController-1].playerBoard.extraColonists > 0) {
			if(UITablero.mayorGameObjectType == GameObjectType.PLANTATION) {
				if(GameData.playersByController[playerController-1].playerBoard.plantations[UITablero.mayorGameObjectIndex].colonist == 0) {
					Debug.Log("El jugador "+playerController+" añade un colono a la Plantación " + (UITablero.mayorGameObjectIndex+1));
					// Añadimos colono
					GameData.playersByController[playerController-1].playerBoard.plantations[UITablero.mayorGameObjectIndex].colonist++;
					GameData.playersByController[playerController-1].playerBoard.emptySlots--;
					UITablero.mayorGameObjectSelected.GetComponent<UIPlantation>().UIColonist.SetActive(true);

					// Restamos de San Juan
					GameData.playersByController[playerController-1].playerBoard.extraColonists--;
					UITablero.UIExtraColonist.text = GameData.playersByController[playerController-1].playerBoard.extraColonists.ToString();
				} else {
					Debug.Log("El jugador "+playerController+" intenta añadir colono a la Plantación " + (UITablero.mayorGameObjectIndex+1) + " pero no puede");
					// TODO Sonido ERROR
				}
			} else if(UITablero.mayorGameObjectType == GameObjectType.BUILDING) {
				UIBuilding UIBuilding = UITablero.mayorGameObjectSelected.GetComponent<UIBuilding>();
				Building building = GameData.playersByController[playerController-1].playerBoard.buildings.Find(i => i.type == UIBuilding.type);
				if(UIBuilding.lowerPart && building.colonists < building.maximumColonists) {
					Debug.Log("El jugador "+playerController+" añade un colono al Edificio " + building.type);
					// Añadimos colono
					building.colonists++;
					GameData.playersByController[playerController-1].playerBoard.emptySlots--;
					UITablero.mayorGameObjectSelected.GetComponent<UIBuilding>().CalculateBuildingColonists(building.colonists);

					// Restamos de San Juan
					GameData.playersByController[playerController-1].playerBoard.extraColonists--;
					UITablero.UIExtraColonist.text = GameData.playersByController[playerController-1].playerBoard.extraColonists.ToString();

					// Restamos uno a la reserva temporal calculada
					GetScriptUIColonistShip().CalculateColonistReservationCalculated(GetScriptUIColonistShip().colonistReservationCalculated + 1);
				} else {
					Debug.Log("El jugador "+playerController+" intenta añadir colono al Edificio " + building.type + " pero no puede");
					// TODO Sonido ERROR
				}
			}
			Debug.Log("Jugador "+playerController+" empty slots = " + GameData.playersByController[playerController-1].playerBoard.emptySlots);
			Debug.Log("Jugador "+playerController+" San Juan = " + GameData.playersByController[playerController-1].playerBoard.extraColonists);

		// CANCEL (Eliminar colono)
		} else if(InputManager.Cancel(playerController)) {
			if(UITablero.mayorGameObjectType == GameObjectType.PLANTATION) {
				if(GameData.playersByController[playerController-1].playerBoard.plantations[UITablero.mayorGameObjectIndex].colonist == 1) {
					Debug.Log("El jugador "+playerController+" elimina un colono a la Plantación " + (UITablero.mayorGameObjectIndex+1));
					// Eliminamos colono
					GameData.playersByController[playerController-1].playerBoard.plantations[UITablero.mayorGameObjectIndex].colonist--;
					GameData.playersByController[playerController-1].playerBoard.emptySlots++;
					UITablero.mayorGameObjectSelected.GetComponent<UIPlantation>().UIColonist.SetActive(false);
			
					// Añadimos a San Juan
					GameData.playersByController[playerController-1].playerBoard.extraColonists++;
					UITablero.UIExtraColonist.text = GameData.playersByController[playerController-1].playerBoard.extraColonists.ToString();
				} else {
					Debug.Log("El jugador "+playerController+" intenta eliminar colono de la Plantación " + (UITablero.mayorGameObjectIndex+1) + " pero no puede");
					// TODO Sonido ERROR
				}
			} else if(UITablero.mayorGameObjectType == GameObjectType.BUILDING) {
				UIBuilding UIBuilding = UITablero.mayorGameObjectSelected.GetComponent<UIBuilding>();
				Building building = GameData.playersByController[playerController-1].playerBoard.buildings.Find(i => i.type == UIBuilding.type);
				if(UIBuilding.lowerPart && building.colonists > 0) {
					Debug.Log("El jugador "+playerController+" elimina un colono al Edificio " + building.type);
					// Eliminamos colono
					building.colonists--;
					GameData.playersByController[playerController-1].playerBoard.emptySlots++;
					UITablero.mayorGameObjectSelected.GetComponent<UIBuilding>().CalculateBuildingColonists(building.colonists);
					
					// Añadimos a San Juan
					GameData.playersByController[playerController-1].playerBoard.extraColonists++;
					UITablero.UIExtraColonist.text = GameData.playersByController[playerController-1].playerBoard.extraColonists.ToString();

					// Añadimos uno a la reserva temporal calculada
					GetScriptUIColonistShip().CalculateColonistReservationCalculated(GetScriptUIColonistShip().colonistReservationCalculated - 1);
				} else {
					Debug.Log("El jugador "+playerController+" intenta eliminar colono del Edificio " + building.type + " pero no puede");
					// TODO Sonido ERROR
				}
			}
			Debug.Log("Jugador "+playerController+" empty slots = " + GameData.playersByController[playerController-1].playerBoard.emptySlots);
			Debug.Log("Jugador "+playerController+" San Juan = " + GameData.playersByController[playerController-1].playerBoard.extraColonists);

		// START (Finalizar turno)
		} else if(InputManager.Start(playerController)) {
			Debug.Log("Jugador "+playerController+" empty slots = " + GameData.playersByController[playerController-1].playerBoard.emptySlots);
			Debug.Log("Jugador "+playerController+" San Juan = " + GameData.playersByController[playerController-1].playerBoard.extraColonists);
			
			// Si no tiene más colonos en San Juan, OR Tiene colonos en San Juan pero no hay más huecos que rellenar
			if(GameData.playersByController[playerController-1].playerBoard.extraColonists == 0 || GameData.playersByController[playerController-1].playerBoard.emptySlots == 0) {
				Debug.Log("El jugador " + playerController + " ha acabado el turno");
				UITablero.DeselectFramesBuildingsPlantations();
				UITablero.UIPanelFinished.SetActive(true);
				CalculateStatusMayorFinished(playerController);
			} else {
				// TODO Sonido ERROR
				// TODO Mensaje Aún quedan huecos que tapar
				Debug.Log("El jugador " + playerController + " aún tiene huecos que tapar");
			}
		}
		return playerInput;
	}

	bool CalculatePlayersMayorPlacingFinished() {
		if(GameData.player1Status == GameStatus.ROLE_MAYOR_PLAYER1_FINISHED
			&& GameData.player2Status == GameStatus.ROLE_MAYOR_PLAYER2_FINISHED) {
			if(GameData.totalPlayers > 2) {
				if(GameData.player3Status == GameStatus.ROLE_MAYOR_PLAYER3_FINISHED) {
					if(GameData.totalPlayers > 3) {
						if(GameData.player4Status == GameStatus.ROLE_MAYOR_PLAYER4_FINISHED) {
							if(GameData.totalPlayers > 4) {
								if(GameData.player5Status == GameStatus.ROLE_MAYOR_PLAYER5_FINISHED) {
									return true;
								}
								return false;
							}
							return true;
						}
						return false;
					}
					return true;
				}
				return false;
			}
			return true;
		}
		return false;
	}

	void CalculateStatusMayorFinished(int playerController) {
		switch(playerController) {
			case 1:
				GameData.player1Status = GameStatus.ROLE_MAYOR_PLAYER1_FINISHED; break;
			case 2:
				GameData.player2Status = GameStatus.ROLE_MAYOR_PLAYER2_FINISHED; break;
			case 3:
				GameData.player3Status = GameStatus.ROLE_MAYOR_PLAYER3_FINISHED; break;
			case 4:
				GameData.player4Status = GameStatus.ROLE_MAYOR_PLAYER4_FINISHED; break;
			case 5:
				GameData.player5Status = GameStatus.ROLE_MAYOR_PLAYER5_FINISHED; break;
		}
	}

	// =========
	// CRAFTSMAN
	// =========

	void UISelectExtraBarrel(int playerController) {
		input = InputManager.CalculateIdle(playerController, input);

		if(input == InputManager.GetIdle(playerController)) {
			//Debug.Log("=====El input es IDLE, MOVE CURSOR");
			input = barrelReservation.GetComponent<UIBarrelReservation>().MoveCursor(InputManager.Horizontal(playerController, input), InputManager.Vertical(playerController, input), playerController, craftsman);
		}
		//Debug.Log("Input = " + input);

		// Si el jugador pulsa Submit
		if(InputManager.Submit(playerController)) {
			Debug.Log("Barril escogido = " + barrelReservation.GetComponent<UIBarrelReservation>().barrelSelected);

			// TODO Diálogo de confirmación? (Aceptar/Cancelar)
			
			craftsman.ExtraCrafting(GameData.actualRolePlayer, barrelReservation.GetComponent<UIBarrelReservation>(), centralBoard.GetComponent<UICentralBoard>());
			
			barrelReservation.GetComponent<UIBarrelReservation>().DeselectFrames();

			// TODO ANIMACIONES
			GameData.gameStatus = GameStatus.ROLE_CRAFTSMAN_PLAYER_CHOOSE_EXTRA_FINISHED;
		}
	}

	// =======
	// SETTLER
	// =======

	UIPlantationBoard GetScriptUIPlantationBoard() {
		switch(GameData.totalPlayers) {
			case 2:
				return plantationBoard.GetComponent<UIPlantationBoard2P>();
			case 3:
				return plantationBoard.GetComponent<UIPlantationBoard3P>();
			case 4:
				return plantationBoard.GetComponent<UIPlantationBoard4P>();
			case 5:
				return plantationBoard.GetComponent<UIPlantationBoard5P>();
		}
		return null;
	}

	void UISelectExtraPlantation(int playerController) {
		if(InputManager.Submit(playerController)) {
			Debug.Log("El jugador elige coger una Plantacion extra");
			settler.PickExtraPlantation(GameData.actualRolePlayer, GetScriptUIPlantationBoard());
			GameData.gameStatus = GameStatus.ROLE_SETTLER_PLAYER_CHOOSE_EXTRA_FINISHED;

			// TODO ANIMACIÓN COGER EXTRA
			GameData.gameStatus = GameStatus.ROLE_SETTLER_ANIM_PICKING_EXTRA;
		} else if(InputManager.Cancel(playerController)) {
			
			// TODO Diálogo de confirmación? (Aceptar/Cancelar)
			
			Debug.Log("El jugador no ha querido el extra");
			GameData.gameStatus = GameStatus.ROLE_SETTLER_PLAYER_CHOOSE_EXTRA_FINISHED;
		}
	}

	void UISelectPlantation(int playerController) {
		input = InputManager.CalculateIdle(playerController, input);

		if(input == InputManager.GetIdle(playerController)) {
			//Debug.Log("=====El input es IDLE, MOVE CURSOR");
			input = GetScriptUIPlantationBoard().MoveCursor(InputManager.Horizontal(playerController, input), InputManager.Vertical(playerController, input), playerController);
		}
		//Debug.Log("Input = " + input);

		// Si el jugador pulsa Submit
		if(InputManager.Submit(playerController)) {
			Debug.Log("Plantación escogida = " + GetScriptUIPlantationBoard().objectTypeSelected);

			// TODO Diálogo de confirmación? (Aceptar/Cancelar)
			
			if(GetScriptUIPlantationBoard().objectTypeSelected == SettlerObjectType.QUARRY) {
				settler.PickPlantations(GameData.actualRolePlayer, GameData.quarryReserve[0], GetScriptUIPlantationBoard(), GetScriptUIColonistShip());
			} else {
				settler.PickPlantations(GameData.actualRolePlayer, GetScriptUIPlantationBoard().listPlantations[GetScriptUIPlantationBoard().gameObjectIndexSelected], GetScriptUIPlantationBoard(), GetScriptUIColonistShip());
			}

			GameData.gameStatus = GameStatus.ROLE_SETTLER_PLAYER_CHOOSE_PLANTATION_FINISHED;
		}
	}

	// ======
	// TRADER
	// ======

	void UISelectBarrelTrader(int playerController) {
		input = InputManager.CalculateIdle(playerController, input);

		if(input == InputManager.GetIdle(playerController)) {
			//Debug.Log("=====El input es IDLE, MOVE CURSOR");
			input = GameData.actualRolePlayer.UIPlayerBoard.GetComponent<UIPlayerBoard>().MoveCursorTrader(InputManager.Horizontal(playerController, input), InputManager.Vertical(playerController, input), playerController, GameData.actualRolePlayer.playerBoard, trader.activeOffice);
		}
		//Debug.Log("Input = " + input);

		// Si el jugador pulsa Submit
		if(InputManager.Submit(playerController)) {
			Debug.Log("Barril escogido = " + GameData.actualRolePlayer.UIPlayerBoard.GetComponent<UIPlayerBoard>().selectedBarrel);

			// TODO Diálogo de confirmación? (Aceptar/Cancelar)
			
			trader.actionResult = trader.SellGoods(GameData.actualRolePlayer, UIGetBarrelFromPlayerBoard(GameData.actualRolePlayer.UIPlayerBoard.GetComponent<UIPlayerBoard>().selectedBarrel, GameData.actualRolePlayer.playerBoard), sellHouse.GetComponent<UISellHouse>(), barrelReservation.GetComponent<UIBarrelReservation>());

			centralBoard.GetComponent<UICentralBoard>().UICoins.text = GameData.bankCoins.ToString();

			GameData.gameStatus = GameStatus.ROLE_SETTLER_PLAYER_CHOOSE_PLANTATION_FINISHED;
		} else if(InputManager.Cancel(playerController)) {
			Debug.Log("El jugador decide no vender");
			trader.actionResult = ActionResult.TRADER_PLAYER_REFUSE;
			GameData.gameStatus = GameStatus.ROLE_SETTLER_PLAYER_CHOOSE_PLANTATION_FINISHED;
		}
	}

	Barrel UIGetBarrelFromPlayerBoard(PlantationType type, PlayerBoard playerBoard) {
		switch(type) {
			case PlantationType.CORN:
				return playerBoard.cornBarrels[0];
			case PlantationType.INDIGO:
				return playerBoard.indigoBarrels[0];
			case PlantationType.SUGAR:
				return playerBoard.sugarBarrels[0];
			case PlantationType.TOBACCO:
				return playerBoard.tobaccoBarrels[0];
			case PlantationType.COFFEE:
				return playerBoard.coffeeBarrels[0];
		}
		return null;
	}

	// =======
	// CAPTAIN
	// =======

	void UISelectBarrelCaptain(int playerController) {
		input = InputManager.CalculateIdle(playerController, input);

		if(input == InputManager.GetIdle(playerController)) {
			//Debug.Log("=====El input es IDLE, MOVE CURSOR");
			input = GameData.actualRolePlayer.UIPlayerBoard.GetComponent<UIPlayerBoard>().MoveCursorCaptain(InputManager.Horizontal(playerController, input), InputManager.Vertical(playerController, input), playerController, GameData.actualRolePlayer.playerBoard, captain);
		}
		//Debug.Log("Input = " + input);

		// Si el jugador pulsa Submit
		if(InputManager.Submit(playerController)) {
			Debug.Log("Barril escogido = " + GameData.actualRolePlayer.UIPlayerBoard.GetComponent<UIPlayerBoard>().selectedBarrel);

			GameData.gameStatus = GameStatus.ROLE_CAPTAIN_PLAYER_CHOOSE_BARREL_FINISHED;
			Debug.Log("GameStatus = " + GameData.gameStatus);

			shipBoard.GetComponent<UIShipBoard>().SelectFirstShipAvailable(GameData.actualRolePlayer, captain);

			// ACCIÓN GUI PARA ELEGIR EL BARCO DONDE ENVIAR
			GameData.gameStatus = GameStatus.ROLE_CAPTAIN_PLAYER_CHOOSE_SHIP;
			Debug.Log("GameStatus = " + GameData.gameStatus);
		}
	}

	void UISelectShipCaptain(int playerController) {
		input = InputManager.CalculateIdle(playerController, input);

		if(input == InputManager.GetIdle(playerController)) {
			//Debug.Log("=====El input es IDLE, MOVE CURSOR");
			input = shipBoard.GetComponent<UIShipBoard>().MoveCursor(InputManager.Horizontal(playerController, input), InputManager.Vertical(playerController, input), playerController, GameData.actualRolePlayer, captain);
		}
		//Debug.Log("Input = " + input);

		// Si el jugador pulsa Submit
		if(InputManager.Submit(playerController)) {
			Debug.Log("Barco escogido = " + shipBoard.GetComponent<UIShipBoard>().selectedShipType);

			// TODO Diálogo de confirmación? (Aceptar/Cancelar)
			
			captain.actionResult = 
				captain.SendGoods(
					// Jugador
					GameData.actualRolePlayer, 
					// Lista de barriles del jugador a enviar
					UIGetListBarrelsFromPlayerBoard(
						GameData.actualRolePlayer.UIPlayerBoard.GetComponent<UIPlayerBoard>().selectedBarrel, 
						GameData.actualRolePlayer.playerBoard
					), 
					// Numero de barriles a enviar
					captain.GetShipmentsNumberByShipAndBarrelType(
						shipBoard.GetComponent<UIShipBoard>().selectedShipType, 
						GameData.actualRolePlayer.UIPlayerBoard.GetComponent<UIPlayerBoard>().selectedBarrel, 
						GameData.actualRolePlayer.playerBoard
					), 
					// Barco al que va a enviar
					UIGetShipFromCore(shipBoard.GetComponent<UIShipBoard>().selectedShipType)
				);
			
			if(captain.actionResult == ActionResult.PV_RESERVE_EMPTY) { GameData.gameOver = true; }

			GameData.gameStatus = GameStatus.ROLE_CAPTAIN_PLAYER_CHOOSE_SHIP_FINISHED;
			Debug.Log("GameStatus = " + GameData.gameStatus);
		} else if(InputManager.Cancel(playerController)) {
			Debug.Log("VUELVE ATRÁS. El jugador decide elegir otra mercancía");
			
			shipBoard.GetComponent<UIShipBoard>().DeselectFrames();
			GameData.actualRolePlayer.UIPlayerBoard.GetComponent<UIPlayerBoard>().SelectFirstSlotAvailableCaptain(GameData.actualRolePlayer.playerBoard, captain);

			// ACCIÓN GUI PARA ELEGIR QUÉ BARRIL QUIERE ENVIAR
			GameData.gameStatus = GameStatus.ROLE_CAPTAIN_PLAYER_CHOOSE_BARREL;
			Debug.Log("GameStatus = " + GameData.gameStatus);
		}
	}

	void UISelectSpoilCaptain(int playerController) {
		input = InputManager.CalculateIdle(playerController, input);

		if(input == InputManager.GetIdle(playerController)) {
			//Debug.Log("=====El input es IDLE, MOVE CURSOR");
			input = GameData.actualRolePlayer.UIPlayerBoard.GetComponent<UIPlayerBoard>().MoveCursorSpoil(InputManager.Horizontal(playerController, input), InputManager.Vertical(playerController, input), playerController, GameData.actualRolePlayer.playerBoard);
		}
		//Debug.Log("Input = " + input);

		// SUBMIT
		if(InputManager.Submit(playerController)) {
			Debug.Log("Barril escogido = " + GameData.actualRolePlayer.UIPlayerBoard.GetComponent<UIPlayerBoard>().selectedBarrel);

			switch(GameData.actualRolePlayer.UIPlayerBoard.GetComponent<UIPlayerBoard>().selectedBarrel) {
				case PlantationType.CORN:
					captain.cornSpoil = captain.CalculateSubmitSpoil(captain.cornSpoil, GameData.actualRolePlayer.playerBoard.cornBarrels.Count, GameData.actualRolePlayer.UIPlayerBoard.GetComponent<UIPlayerBoard>().UICornBarrelSpoil);
					break;
				case PlantationType.INDIGO:
					captain.indigoSpoil = captain.CalculateSubmitSpoil(captain.indigoSpoil, GameData.actualRolePlayer.playerBoard.indigoBarrels.Count, GameData.actualRolePlayer.UIPlayerBoard.GetComponent<UIPlayerBoard>().UIIndigoBarrelSpoil);
					break;
				case PlantationType.SUGAR:
					captain.sugarSpoil = captain.CalculateSubmitSpoil(captain.sugarSpoil, GameData.actualRolePlayer.playerBoard.sugarBarrels.Count, GameData.actualRolePlayer.UIPlayerBoard.GetComponent<UIPlayerBoard>().UISugarBarrelSpoil);
					break;
				case PlantationType.TOBACCO:
					captain.tobaccoSpoil = captain.CalculateSubmitSpoil(captain.tobaccoSpoil, GameData.actualRolePlayer.playerBoard.tobaccoBarrels.Count, GameData.actualRolePlayer.UIPlayerBoard.GetComponent<UIPlayerBoard>().UITobaccoBarrelSpoil);
					break;
				case PlantationType.COFFEE:
					captain.coffeeSpoil = captain.CalculateSubmitSpoil(captain.coffeeSpoil, GameData.actualRolePlayer.playerBoard.coffeeBarrels.Count, GameData.actualRolePlayer.UIPlayerBoard.GetComponent<UIPlayerBoard>().UICoffeeBarrelSpoil);
					break;
			}
		// CANCEL
		} else if(InputManager.Cancel(playerController)) {
			Debug.Log("Reseteamos el cálculo de spoileos");
			captain.ResetCalculatedSpoils(GameData.actualRolePlayer.UIPlayerBoard.GetComponent<UIPlayerBoard>(), GameData.actualRolePlayer.playerBoard);
		// START
		} else if(InputManager.Start(playerController)) {
			// Si ya ha marcado todas las mercancías para spoilear
			if(captain.numberTotalSpoil == captain.totalNumberTotalSpoil && captain.numberSpoilLess1 == captain.totalNumberSpoilLess1) {
				captain.Spoil(GameData.actualRolePlayer);

				GameData.gameStatus = GameStatus.ROLE_CAPTAIN_PLAYER_CHOOSE_SPOIL_FINISHED;
				Debug.Log("GameStatus = " + GameData.gameStatus);
			} else {
				Debug.Log("Aún quedan mercancías que marcar para spoilear");
			}
		}
	}

	List<Barrel> UIGetListBarrelsFromPlayerBoard(PlantationType type, PlayerBoard playerBoard) {
		switch(type) {
			case PlantationType.CORN:
				return playerBoard.cornBarrels;
			case PlantationType.INDIGO:
				return playerBoard.indigoBarrels;
			case PlantationType.SUGAR:
				return playerBoard.sugarBarrels;
			case PlantationType.TOBACCO:
				return playerBoard.tobaccoBarrels;
			case PlantationType.COFFEE:
				return playerBoard.coffeeBarrels;
		}
		return null;
	}

	Ship UIGetShipFromCore(CaptainObjectType shipType) {
		switch(shipType) {
			case CaptainObjectType.SHIP_1:
				return GameData.ship1;
			case CaptainObjectType.SHIP_2:
				return GameData.ship2;
			case CaptainObjectType.SHIP_3:
				return GameData.ship3;
		}
		return null;
	}

	IEnumerator MainLoop() {
		while(!GameData.gameOver) {
			GameData.gameStatus = GameStatus.PLAYER1_CHOOSE_ROLE_INPUT;
			foreach(Player player in GameData.players) {
				// UI
				player.UIPlayerBoard.GetComponent<UIPlayerBoard>().UISelectedFrame.SetActive(true);

				// Autoselecciona el primer Role disponible
				GetScriptUIRoleBoard().SelectFirstRoleAvailable();

				GameData.actualRolePlayer = player;

				// Calcula el GameStatus para que el jugador correspondiente elija Role (Update)
				GameData.gameStatus = calcularStatusElegirRole(player.controller);
				Debug.Log("GameStatus = " + GameData.gameStatus);

				// Esperamos hasta que el jugador elige Role
				while(GameData.gameStatus == GameStatus.PLAYER1_CHOOSE_ROLE_INPUT
					|| GameData.gameStatus == GameStatus.PLAYER2_CHOOSE_ROLE_INPUT
					|| GameData.gameStatus == GameStatus.PLAYER3_CHOOSE_ROLE_INPUT
					|| GameData.gameStatus == GameStatus.PLAYER4_CHOOSE_ROLE_INPUT
					|| GameData.gameStatus == GameStatus.PLAYER5_CHOOSE_ROLE_INPUT) {
						yield return null;
				}
				player.playerBoard.roleBonus = true; // Activo el bonus de Role

				// Calculo el orden de jugadores para este Role
				GameData.FulfillRolePlayerList(GameData.actualRolePlayer);

				// Una vez elegido Role, empieza la corrutina correspondiente
				switch(GameData.gameStatus) {
					case GameStatus.ROLE_MAYOR_START:
						yield return StartCoroutine(RoleMayor()); break;
					case GameStatus.ROLE_PROSPECTOR_START:
						yield return StartCoroutine(RoleProspector()); break;
					case GameStatus.ROLE_CRAFTSMAN_START:
						yield return StartCoroutine(RoleCraftsman()); break;
					case GameStatus.ROLE_CAPTAIN_START:
						yield return StartCoroutine(RoleCaptain()); break;
					case GameStatus.ROLE_SETTLER_START:
						yield return StartCoroutine(RoleSettler()); break;
					case GameStatus.ROLE_BUILDER_START:
						yield return StartCoroutine(RoleBuilder()); break;
					case GameStatus.ROLE_TRADER_START:
						yield return StartCoroutine(RoleTrader()); break;
					default:
						break;
				}

				player.playerBoard.roleBonus = false;
				// UI
				player.UIPlayerBoard.GetComponent<UIPlayerBoard>().UIFrameActualRole.GetComponent<Image>().sprite = player.UIPlayerBoard.GetComponent<UIPlayerBoard>().UIRoleFrameTransparent;
			}

			// Ronda acabada. Si no ha acabado el juego, añade monedas a los Roles, los jugadores devuelven sus Roles, se avanzan posiciones
			if(!GameData.gameOver) {
				RoundEnd();
			}
		}
		GameOver();
	}

	GameStatus calcularStatusElegirRole(int playerController) {
		switch(playerController) {
			case 1:
				input = InputType.PLAYER1_IDLE;
				return GameStatus.PLAYER1_CHOOSE_ROLE_INPUT;
			case 2:
				input = InputType.PLAYER2_IDLE;
				return GameStatus.PLAYER2_CHOOSE_ROLE_INPUT;
			case 3:
				input = InputType.PLAYER3_IDLE;
				return GameStatus.PLAYER3_CHOOSE_ROLE_INPUT;
			case 4:
				input = InputType.PLAYER4_IDLE;
				return GameStatus.PLAYER4_CHOOSE_ROLE_INPUT;
			case 5:
				input = InputType.PLAYER5_IDLE;
				return GameStatus.PLAYER5_CHOOSE_ROLE_INPUT;
			default:
				input = InputType.PLAYER1_IDLE;
				return GameStatus.PLAYER1_CHOOSE_ROLE_INPUT;
		}
	}

	void ResetPanelFinishedAndSelectedFrameAllPlayers() {
		foreach(Player player in GameData.players) {
			player.UIPlayerBoard.GetComponent<UIPlayerBoard>().UIPanelFinished.SetActive(false);
			player.UIPlayerBoard.GetComponent<UIPlayerBoard>().UISelectedFrame.SetActive(false);
		}
	}

	IEnumerator RoleBuilder() {
		Debug.Log("Corrutina RoleBuilder");
		foreach(Player player in GameData.actualRolePlayers) {
			Debug.Log("Jugador " + player.nickname);
			// UI
			player.UIPlayerBoard.GetComponent<UIPlayerBoard>().UISelectedFrame.SetActive(true);

			// Sumamos las monedas acumuladas
			if(player.playerBoard.roleBonus) {
				builder.AddStackedCoins(player, GetScriptUIRoleBoard().UIPanelCoinsBuilder, GetScriptUIRoleBoard().UICoinsBuilder);
			}

			// Comprueba los edificios que puede comprar el jugador, si devuelve false es que no puede comprar nada
			if(builder.CheckMarketplace(player, centralBoard.GetComponent<UICentralBoard>()) == ActionResult.OK) {

				// Asignamos como jugadorRoleActual al jugador que le toque comprar
				GameData.actualRolePlayer = player;

				centralBoard.GetComponent<UICentralBoard>().SelectFirstBuildingAvailable();

				// Calcula el GameStatus para que el jugador correspondiente elija Edificio (Update)
				GameData.gameStatus = GameStatus.ROLE_BUILDER_PLAYER_CHOOSE_BUILDING;
				Debug.Log("GameStatus = " + GameData.gameStatus);
				
				// Esperamos hasta que el jugador elige Edificio
				while(GameData.gameStatus == GameStatus.ROLE_BUILDER_PLAYER_CHOOSE_BUILDING) {
					yield return null;
				}
				// Reseteamos el estado de los edificios para el siguiente jugador
				centralBoard.GetComponent<UICentralBoard>().SetBuildingsNotBuyable();
			}
			// UI
			player.UIPlayerBoard.GetComponent<UIPlayerBoard>().UIPanelFinished.SetActive(true);
			player.UIPlayerBoard.GetComponent<UIPlayerBoard>().UISelectedFrame.SetActive(false);
			
			GameData.gameStatus = GameStatus.ROLE_BUILDER_PLAYER_END;
		}
		centralBoard.GetComponent<UICentralBoard>().ResetBuildingPrices();
		ResetPanelFinishedAndSelectedFrameAllPlayers();

		GameData.gameStatus = GameStatus.ROLE_BUILDER_FINISH;
		Debug.Log("Corrutina FIN RoleBuilder");
	}

	IEnumerator RoleMayor() {
		Debug.Log("Corrutina RoleMayor");
		ActionResult actionResult;

		// Sumamos las monedas acumuladas
		if(GameData.actualRolePlayer.playerBoard.roleBonus) {
			mayor.AddStackedCoins(GameData.actualRolePlayer, GetScriptUIRoleBoard().UIPanelCoinsMayor, GetScriptUIRoleBoard().UICoinsMayor);
		}

		// Repartimos colonos a los jugadores
		mayor.DistributeColonists(GameData.actualRolePlayer, GetScriptUIColonistShip());

		// UI
		// Ponemos el barco a 0
		GetScriptUIColonistShip().RefreshShipLabels(0);
		// Calculamos la previsión de colonos a rellenar
		int emptySlots = mayor.CalculateEmptySlots();
		if(emptySlots < GameData.totalPlayers)
			emptySlots = GameData.totalPlayers;

		GetScriptUIColonistShip().colonistReservationCalculated = GetScriptUIColonistShip().CalculateColonistReservationCalculated(GameData.colonistReserve - emptySlots);
		GetScriptUIColonistShip().UIColonistReservationCalculated.gameObject.SetActive(true);
		GetScriptUIColonistShip().UIColonistReservationCalculated.text = GetScriptUIColonistShip().colonistReservationCalculated.ToString();
		
		// TODO ANIMACIÓN REPARTICIÓN DE COLONOS
		GameData.gameStatus = GameStatus.ROLE_MAYOR_ANIM_DISTRIBUTING;

		playerBoard1.GetComponent<UIPlayerBoard>().SelectFirstSlotAvailableMayor();
		player1Input = InputType.PLAYER1_IDLE;
		GameData.player1Status = GameStatus.ROLE_MAYOR_PLAYER1_PLACING;
		playerBoard1.GetComponent<UIPlayerBoard>().UISelectedFrame.SetActive(true);

		playerBoard2.GetComponent<UIPlayerBoard>().SelectFirstSlotAvailableMayor();
		player2Input = InputType.PLAYER2_IDLE;
		GameData.player2Status = GameStatus.ROLE_MAYOR_PLAYER2_PLACING;
		playerBoard2.GetComponent<UIPlayerBoard>().UISelectedFrame.SetActive(true);

		if(GameData.totalPlayers > 2) {
			playerBoard3.GetComponent<UIPlayerBoard>().SelectFirstSlotAvailableMayor();
			player3Input = InputType.PLAYER3_IDLE;
			GameData.player3Status = GameStatus.ROLE_MAYOR_PLAYER3_PLACING;
			playerBoard3.GetComponent<UIPlayerBoard>().UISelectedFrame.SetActive(true);

			if(GameData.totalPlayers > 3) {
				playerBoard4.GetComponent<UIPlayerBoard>().SelectFirstSlotAvailableMayor();
				player4Input = InputType.PLAYER4_IDLE;
				GameData.player4Status = GameStatus.ROLE_MAYOR_PLAYER4_PLACING;
				playerBoard4.GetComponent<UIPlayerBoard>().UISelectedFrame.SetActive(true);

				if(GameData.totalPlayers > 4) {
					playerBoard5.GetComponent<UIPlayerBoard>().SelectFirstSlotAvailableMayor();
					player5Input = InputType.PLAYER5_IDLE;
					GameData.player5Status = GameStatus.ROLE_MAYOR_PLAYER5_PLACING;
					playerBoard5.GetComponent<UIPlayerBoard>().UISelectedFrame.SetActive(true);
				}
			}
		}
		
		// ACCIÓN GUI PARA ORGANIZAR COLONOS EN LOS TABLEROS (Update)
		GameData.gameStatus = GameStatus.ROLE_MAYOR_PLACING;
		while(GameData.gameStatus == GameStatus.ROLE_MAYOR_PLACING) {
			yield return null;
		}

		// Rellenamos el barco con los colonos de la reserva
		actionResult = mayor.FulfillColonistsShip();

		// TODO ANIMACIÓN RELLENAR EL BARCO DE COLONOS
		GameData.gameStatus = GameStatus.ROLE_MAYOR_ANIM_FILLING_SHIP;

		// UI
		GetScriptUIColonistShip().UIColonistReservation.text = GameData.colonistReserve.ToString();
		GetScriptUIColonistShip().RefreshShipLabels(GameData.colonistShip);
		GetScriptUIColonistShip().UIColonistReservationCalculated.gameObject.SetActive(false);
		ResetPanelFinishedAndSelectedFrameAllPlayers();
		
		// Si a la hora de rellenar de colonos el barco no había suficientes, esta será la ronda final
		if(actionResult == ActionResult.COLONIST_RESERVE_EMPTY) {
			GameData.gameOver = true;
			// TODO MOSTRAR MENSAJE ÚLTIMA RONDA
		}

		GameData.gameStatus = GameStatus.ROLE_MAYOR_FINISH;
		Debug.Log("Corrutina FIN RoleMayor");
	}

	IEnumerator RoleProspector() {
		Debug.Log("Corrutina RoleProspector");

		// Sumamos las monedas acumuladas
		if(GameData.actualRolePlayer.playerBoard.roleBonus) {
			if(GameData.actualRole.type == RoleTypes.PROSPECTOR_1) {
				prospector.AddStackedCoins(GameData.actualRolePlayer, GetScriptUIRoleBoard().UIPanelCoinsProspector1, GetScriptUIRoleBoard().UICoinsProspector1);
			} else if(GameData.actualRole.type == RoleTypes.PROSPECTOR_2) {
				prospector.AddStackedCoins(GameData.actualRolePlayer, GetScriptUIRoleBoard().UIPanelCoinsProspector2, GetScriptUIRoleBoard().UICoinsProspector2);
			}
		}

		// Coge las monedas del banco
		prospector.Prospect(GameData.actualRolePlayer, centralBoard.GetComponent<UICentralBoard>());
				
		// TODO ANIMACIÓN DE AÑADIR LAS MONEDAS
		GameData.gameStatus = GameStatus.ROLE_PROSPECTOR_ANIM_GRABBING;

		// UI
		ResetPanelFinishedAndSelectedFrameAllPlayers();

		GameData.gameStatus = GameStatus.ROLE_PROSPECTOR_FINISH;
		Debug.Log("Corrutina FIN RoleProspector");
		yield return null; // TODO BORRAR CUANDO SE HAGA UNA ANIMACIÓN
	}

	IEnumerator RoleCraftsman() {
		Debug.Log("Corrutina RoleCraftsman");
		// Producimos para todos los jugadores comprobando la posición de cada uno.
		foreach(Player player in GameData.actualRolePlayers) {
			Debug.Log("Comprobamos y producimos para el Jugador " + player.nickname);

			// Sumamos las monedas acumuladas
			if(player.playerBoard.roleBonus) {
				craftsman.AddStackedCoins(player, GetScriptUIRoleBoard().UIPanelCoinsCraftsman, GetScriptUIRoleBoard().UICoinsCraftsman);
			}

			// Comprobamos lo que podemos producir
			craftsman.CheckCraftings(player);
			// Producimos
			craftsman.Craft(player, barrelReservation.GetComponent<UIBarrelReservation>(), centralBoard.GetComponent<UICentralBoard>());
			
			// TODO ANIMACIÓN PARA AÑADIR LOS BARRILES
			GameData.gameStatus = GameStatus.ROLE_CRAFTSMAN_ANIM_BARREL_DISTRIBUTING;
			
		}

		// *** BONUS ROLE
		// Comprobamos otra vez las producciones del jugador con el Bonus de Role
		Debug.Log("Vamos a comprobar si puede producir el extra");
		craftsman.CheckCraftings(GameData.actualRolePlayer);
		// Si puede producir algo
		if(craftsman.craftingCorn > 0 || craftsman.craftingIndigo > 0 || 
			craftsman.craftingSugar > 0 || craftsman.craftingTobacco > 0 || 
			craftsman.craftingCoffee > 0) {
			Debug.Log("Puede producir el extra, el jugador elije:");

			barrelReservation.GetComponent<UIBarrelReservation>().SelectFirstBarrelAvailable(craftsman);

			// ACCIÓN GUI PARA ELEGIR EL BARRIL EXTRA (SI SE PUEDE)
			GameData.gameStatus = GameStatus.ROLE_CRAFTSMAN_PLAYER_CHOOSE_EXTRA;
			while(GameData.gameStatus == GameStatus.ROLE_CRAFTSMAN_PLAYER_CHOOSE_EXTRA) {
				yield return null;
			}

			// TODO ANIMACIÓN PARA AÑADIR LOS BARRILES
			GameData.gameStatus = GameStatus.ROLE_CRAFTSMAN_ANIM_BARREL_DISTRIBUTING_EXTRA;
		} else {
			Debug.Log("No puede producir nada, se queda sin bonus");
		}

		ResetPanelFinishedAndSelectedFrameAllPlayers();
		
		GameData.gameStatus = GameStatus.ROLE_CRAFTSMAN_FINISH;
		Debug.Log("Corrutina FIN RoleCraftsman");
	}

	IEnumerator RoleCaptain() {
		Debug.Log("Corrutina RoleCaptain");
		int logRounds = 1;
		// Cargamos la lista de los jugadores que pueden enviar (por defecto aqui todos, ya que aún no hemos calculado nada.
		List<Player> playersSending = GameData.actualRolePlayers.FindAll(i => i.playerBoard.continueSendingGoods);
		while(playersSending.Count > 0) { // Mientras quede alguien para enviar
			Debug.Log("RONDA DE ENVÍO " + logRounds);

			// UI
			shipBoard.GetComponent<UIShipBoard>().EnablePrivateShip(false);

			// Bucle jugadores
			foreach(Player captainPlayer in playersSending) {
				
				GameData.gameStatus = GameStatus.ROLE_CAPTAIN_LOADING_SHIPMENTS;
				Debug.Log("GameStatus = " + GameData.gameStatus);

				// Sumamos las monedas acumuladas
				if(captainPlayer.playerBoard.roleBonus) {
					captain.AddStackedCoins(captainPlayer, GetScriptUIRoleBoard().UIPanelCoinsCaptain, GetScriptUIRoleBoard().UICoinsCaptain);
				}

				// Asignamos como jugadorRoleActual al jugador actual
				GameData.actualRolePlayer = captainPlayer;

				// Comprueba y calcula los envíos que puede hacer el jugador en ese momento
				captain.CheckSendings(captainPlayer);
				
				// Si puede enviar algo, ACCIÓN GUI
				if(captainPlayer.playerBoard.continueSendingGoods) {
					Debug.Log("El jugador elige qué enviar y dónde");

					// UI
					captainPlayer.UIPlayerBoard.GetComponent<UIPlayerBoard>().UISelectedFrame.SetActive(true);
					shipBoard.GetComponent<UIShipBoard>().EnablePrivateShip(captain.activeWharf && !captainPlayer.playerBoard.wharfUsed);

					captainPlayer.UIPlayerBoard.GetComponent<UIPlayerBoard>().SelectFirstSlotAvailableCaptain(captainPlayer.playerBoard, captain);

					// ACCIÓN GUI PARA ELEGIR QUÉ BARRIL QUIERE ENVIAR
					GameData.gameStatus = GameStatus.ROLE_CAPTAIN_PLAYER_CHOOSE_BARREL;
					Debug.Log("GameStatus = " + GameData.gameStatus);

					// Esperamos hasta que el jugador elige el tipo de barril a enviar Y el barco donde enviar
					while(GameData.gameStatus == GameStatus.ROLE_CAPTAIN_PLAYER_CHOOSE_BARREL || GameData.gameStatus == GameStatus.ROLE_CAPTAIN_PLAYER_CHOOSE_BARREL_FINISHED
						|| GameData.gameStatus == GameStatus.ROLE_CAPTAIN_PLAYER_CHOOSE_SHIP) {
						yield return null;
					}

					// UI
					shipBoard.GetComponent<UIShipBoard>().RefreshShip(UIGetShipFromCore(shipBoard.GetComponent<UIShipBoard>().selectedShipType));
					shipBoard.GetComponent<UIShipBoard>().DeselectFrames();
					captainPlayer.UIPlayerBoard.GetComponent<UIPlayerBoard>().RefreshBarrels(captainPlayer.playerBoard);
					captainPlayer.UIPlayerBoard.GetComponent<UIPlayerBoard>().UIVP.text = captainPlayer.playerBoard.vp.ToString();
					captainPlayer.UIPlayerBoard.GetComponent<UIPlayerBoard>().DeselectFramesBarrels();
					VPReservation.GetComponent<UIVPReservation>().SetVP(GameData.victoryPoinsReserve);
					barrelReservation.GetComponent<UIBarrelReservation>().RefreshBarrels();

					// TODO ANIMACIÓN GANAR PV
					GameData.gameStatus = GameStatus.ROLE_CAPTAIN_ANIM_GAIN_VP;
					Debug.Log("GameStatus = " + GameData.gameStatus);

					captainPlayer.UIPlayerBoard.GetComponent<UIPlayerBoard>().UISelectedFrame.SetActive(false);
				} else {
					captainPlayer.UIPlayerBoard.GetComponent<UIPlayerBoard>().UIPanelFinished.SetActive(true);
				}
				if(captainPlayer.playerBoard.cornBarrels.Count == 0 && captainPlayer.playerBoard.indigoBarrels.Count == 0 && 
					captainPlayer.playerBoard.sugarBarrels.Count == 0 && captainPlayer.playerBoard.tobaccoBarrels.Count == 0 && 
					captainPlayer.playerBoard.coffeeBarrels.Count == 0) {
					// UI
					captainPlayer.UIPlayerBoard.GetComponent<UIPlayerBoard>().UIPanelFinished.SetActive(true);
					
					captainPlayer.playerBoard.continueSendingGoods = false;
				}
				// UI
				shipBoard.GetComponent<UIShipBoard>().EnablePrivateShip(false);
			}
			// Después de recorrer una vez todos los jugadores, recalcula la lista de jugadores que pueden seguir enviando.
			playersSending = GameData.actualRolePlayers.FindAll(i => i.playerBoard.continueSendingGoods);
			logRounds++;
		}
		ResetPanelFinishedAndSelectedFrameAllPlayers();
		
		// Comprueba los spoileos de cada jugador y los efectúa (también reinicia la variable de si puede seguir enviando y si ha usado el puerto)
		Debug.Log("COMPROBACIÓN DE SPOILEOS");
		
		GameData.gameStatus = GameStatus.ROLE_CAPTAIN_LOADING_SPOILERS;
		Debug.Log("GameStatus = " + GameData.gameStatus);

		foreach(Player player in GameData.actualRolePlayers) {
			Debug.Log("Spoileos para el Jugador " + player.nickname);

			// Asignamos como jugadorRoleActual al jugador actual
			GameData.actualRolePlayer = player;

			// Calculamos los spoileos del jugador
			captain.CalculateSpoilingGoods(player);

			if(captain.spoilableGoods > 0) {
				Debug.Log("El jugador elige que mercancías spoilear");

				// UI
				player.UIPlayerBoard.GetComponent<UIPlayerBoard>().UISelectedFrame.SetActive(true);
				player.UIPlayerBoard.GetComponent<UIPlayerBoard>().ActivateSpoilFrames(true);
				player.UIPlayerBoard.GetComponent<UIPlayerBoard>().SelectFirstSpoilAvailable(player.playerBoard);

				// ACCIÓN GUI PARA ELEGIR QUÉ MERCANCÍA SPOILEAR
				GameData.gameStatus = GameStatus.ROLE_CAPTAIN_PLAYER_CHOOSE_SPOIL;
				Debug.Log("GameStatus = " + GameData.gameStatus);

				// Esperamos hasta que el jugador elige los barriles a spoilear
				while(GameData.gameStatus == GameStatus.ROLE_CAPTAIN_PLAYER_CHOOSE_SPOIL) {
					yield return null;
				}

				// UI
				player.UIPlayerBoard.GetComponent<UIPlayerBoard>().RefreshBarrels(player.playerBoard);
				player.UIPlayerBoard.GetComponent<UIPlayerBoard>().DeselectFramesBarrels();
				player.UIPlayerBoard.GetComponent<UIPlayerBoard>().ActivateSpoilFrames(false);
				barrelReservation.GetComponent<UIBarrelReservation>().RefreshBarrels();

				// TODO ANIMACIÓN SPOILEAR
				GameData.gameStatus = GameStatus.ROLE_CAPTAIN_ANIM_PLAYER_SPOIL;
				Debug.Log("GameStatus = " + GameData.gameStatus);

				// UI
				player.UIPlayerBoard.GetComponent<UIPlayerBoard>().UISelectedFrame.SetActive(false);

			} else {
				Debug.Log("Como no tiene mercancías para spoilear, pasa al siguiente jugador");
			}
			// UI
			player.UIPlayerBoard.GetComponent<UIPlayerBoard>().UIPanelFinished.SetActive(true);
			// Reseteo la variable para el próximo Capitán
			player.playerBoard.continueSendingGoods = true;
		}

		// Ahora vaciamos los barcos llenos
		Debug.Log("VACIADO DE BARCOS");
		captain.EmptyFullShips();

		// UI
		shipBoard.GetComponent<UIShipBoard>().ClearEmptyShips();
		barrelReservation.GetComponent<UIBarrelReservation>().RefreshBarrels();
		ResetPanelFinishedAndSelectedFrameAllPlayers();

		// TODO ANIMACIÓN VACIAR BARCOS
		GameData.gameStatus = GameStatus.ROLE_CAPTAIN_ANIM_EMPTY_SHIP;
		Debug.Log("GameStatus = " + GameData.gameStatus);
		
		GameData.gameStatus = GameStatus.ROLE_CAPTAIN_FINISH;
		Debug.Log("Corrutina FIN RoleCaptain");
	}

	IEnumerator RoleSettler() {
		Debug.Log("Corrutina RoleSettler");
		GetScriptUIPlantationBoard().listPlantations = new List<Plantation>(GameData.plantationsShowed);

		foreach(Player player in GameData.actualRolePlayers) {
			Debug.Log("Jugador " + player.nickname);

			// Sumamos las monedas acumuladas
			if(player.playerBoard.roleBonus) {
				settler.AddStackedCoins(player, GetScriptUIRoleBoard().UIPanelCoinsSettler, GetScriptUIRoleBoard().UICoinsSettler);
			}

			// Comprueba si puede coger plantación e inicializa las variables de edificios activos
			if(settler.CheckPlantations(player)) {

				// Asignamos como jugadorRoleActual al jugador actual
				GameData.actualRolePlayer = player;

				// UI
				player.UIPlayerBoard.GetComponent<UIPlayerBoard>().UISelectedFrame.SetActive(true);

				// (OPCIONAL)
				// Si es el jugador con el bonus de Role y quedan plantaciones o canteras en la reserva
				if(settler.canPickExtraPlantation) {
					Debug.Log("Se le da a elegir al jugador si quiere una extra");

					GetScriptUIPlantationBoard().SelectPlantationReservation();

					// ACCIÓN GUI PARA ELEGIR SI QUIERE PLANTACIÓN EXTRA
					GameData.gameStatus = GameStatus.ROLE_SETTLER_PLAYER_CHOOSE_EXTRA;
					Debug.Log("GameStatus = " + GameData.gameStatus);

					// Esperamos hasta que el jugador elige si quiere Plantación extra o no
					while(GameData.gameStatus == GameStatus.ROLE_SETTLER_PLAYER_CHOOSE_EXTRA) {
						yield return null;
					}

					GetScriptUIPlantationBoard().DeselectFrames();
				}

				if(player.playerBoard.plantations.Count < player.playerBoard.plantations.Capacity) {
					GetScriptUIPlantationBoard().quarrySelectable = settler.canPickQuarry;
					GetScriptUIPlantationBoard().SelectFirstSlotAvailable();

					// ACCIÓN GUI PARA ELEGIR LA PLANTACIÓN A COGER
					GameData.gameStatus = GameStatus.ROLE_SETTLER_PLAYER_CHOOSE_PLANTATION;
					Debug.Log("GameStatus = " + GameData.gameStatus);

					// Esperamos hasta que el jugador elige la Plantación
					while(GameData.gameStatus == GameStatus.ROLE_SETTLER_PLAYER_CHOOSE_PLANTATION) {
						yield return null;
					}
				}
			}
			// UI
			GetScriptUIPlantationBoard().DeselectFrames();
			player.UIPlayerBoard.GetComponent<UIPlayerBoard>().UIPanelFinished.SetActive(true);
			player.UIPlayerBoard.GetComponent<UIPlayerBoard>().UISelectedFrame.SetActive(false);
		}

		Debug.Log("Reiniciamos plantaciones");
		GameData.ResetPlantations();
		// UI
		GetScriptUIPlantationBoard().RefreshPlantations();
		ResetPanelFinishedAndSelectedFrameAllPlayers();

		// TODO ANIMACIÓN MEZCLA
		GameData.gameStatus = GameStatus.ROLE_SETTLER_ANIM_MIXING;

		// TODO ANIMACIÓN DESCUBRIR
		GameData.gameStatus = GameStatus.ROLE_SETTLER_ANIM_REVEALING;

		GameData.gameStatus = GameStatus.ROLE_SETTLER_FINISH;
		Debug.Log("Corrutina FIN RoleSettler");
	}

	IEnumerator RoleTrader() {
		Debug.Log("Corrutina RoleTrader");

		foreach(Player player in GameData.actualRolePlayers) {
			Debug.Log("Jugador " + player.nickname);

			// Sumamos las monedas acumuladas
			if(player.playerBoard.roleBonus) {
				trader.AddStackedCoins(player, GetScriptUIRoleBoard().UIPanelCoinsTrader, GetScriptUIRoleBoard().UICoinsTrader);
			}

			// Comprueba las mercancías que puede vender un jugador
			if(trader.CheckSellingGoods(player, sellHouse.GetComponent<UISellHouse>()) == ActionResult.OK) {
				
				// Asignamos como jugadorRoleActual al jugador actual
				GameData.actualRolePlayer = player;

				// UI
				player.UIPlayerBoard.GetComponent<UIPlayerBoard>().UISelectedFrame.SetActive(true);

				player.UIPlayerBoard.GetComponent<UIPlayerBoard>().SelectFirstSlotAvailableTrader(player.playerBoard, trader.activeOffice);
				
				// ACCIÓN GUI PARA ELEGIR LA MERCANCÍA A VENDER
				// AVISO! El jugador puede elegir no vender nada
				GameData.gameStatus = GameStatus.ROLE_TRADER_PLAYER_CHOOSE_BARREL;
				Debug.Log("GameStatus = " + GameData.gameStatus);

				// Esperamos hasta que el jugador elige el barril o cancela
				while(GameData.gameStatus == GameStatus.ROLE_TRADER_PLAYER_CHOOSE_BARREL) {
					yield return null;
				}

				if(trader.actionResult != ActionResult.TRADER_PLAYER_REFUSE) {
					// TODO ANIMACIÓN VENDER
					GameData.gameStatus = GameStatus.ROLE_TRADER_ANIM_PLAYER_SELLING;
				}

				// UI
				player.UIPlayerBoard.GetComponent<UIPlayerBoard>().DeselectFramesBarrels();
				player.UIPlayerBoard.GetComponent<UIPlayerBoard>().UISelectedFrame.SetActive(false);

				// Si no hay espacio en la casa de ventas, salimos del bucle
				if(trader.actionResult == ActionResult.TRADER_FULL) { break; }
			}
			// UI
			player.UIPlayerBoard.GetComponent<UIPlayerBoard>().UIPanelFinished.SetActive(true);
		}

		// TODO ANIMACIÓN VACIAR
		GameData.gameStatus = GameStatus.ROLE_TRADER_ANIM_EMPTY_SELL_HOUSE;

		sellHouse.GetComponent<UISellHouse>().ResetPrices();
		ResetPanelFinishedAndSelectedFrameAllPlayers();

		GameData.gameStatus = GameStatus.ROLE_TRADER_FINISH;
		Debug.Log("Corrutina FIN RoleTrader");
	}
	
	void RoundEnd() {
		// ROLE
		foreach(Role role in GameData.roles) {
			// Añade una moneda si no se había usado el Role y hay suficientes monedas en el banco
			if(!role.usedRole && GameData.bankCoins > 0) {
				role.stackedCoins++;
				GameData.bankCoins--;
				// UI
				GetScriptUIRoleBoard().RefreshCoins(role);
			} else if(role.usedRole) {
				// UI
				GetScriptUIRoleBoard().ActivateRole(role);
			}
			// Vuelve a activar los Roles
			role.usedRole = false;
		}
		// UI
		centralBoard.GetComponent<UICentralBoard>().UICoins.text = GameData.bankCoins.ToString();
		
		// Avanza la posición de los jugadores (pasar el gobernador)
		GameData.MovePlayerPosition();
	}
	
	void GameOver() {
		CalculateVP();

		ShowWinner();
		
		// finalizarGUI i mostrar el ganador
		
		GameData.guardarDatosNuevaPartida();
		
	}
	
	void CalculateVP() {
		// Bucle de jugadores
		foreach(Player player in GameData.players) {
			Debug.Log("Calculamos la puntuación final del jugador " + player.nickname);
			
			int chipsVP = player.playerBoard.vp;
			int buildingValueVP = 0;
			int guildHallVP1 = 0;
			int guildHallVP2 = 0;
			int fortressVP = 0;
			int cityHallVP = 0;
			Debug.Log("Fichas PV = " + chipsVP);
			foreach(Building building in player.playerBoard.buildings) {
				// Suma los PV de los edificios
				player.playerBoard.vp += building.vp;
				buildingValueVP += building.vp;
				
				// Ejecuta efecto de los edificios especiales, si tiene
				if(building.colonists > 0) {
					switch(building.type) {
						case BuildingType.GUILD_HALL:
							// 1 PV por cada Fábrica pequeña
							guildHallVP1 = player.playerBoard.buildings.FindAll(i => i.category == BuildingCategory.SMALL_FACTORY).Count;
							player.playerBoard.vp += guildHallVP1;
							// 2 PV por cada Fábrica grande
							guildHallVP2 = (player.playerBoard.buildings.FindAll(i => i.category == BuildingCategory.LARGE_FACTORY).Count * 2);
							player.playerBoard.vp += guildHallVP2;
							Debug.Log("COFRADÍA ACTIVA (Fábricas pequeñas +" + guildHallVP1 + " PV / Fábricas grandes +" + guildHallVP2 + " PV)");
							break;
						case BuildingType.RESIDENCE:
							int numPlantations = player.playerBoard.plantations.Count;
							if(numPlantations <= 9) { // Por 9 plantaciones o menos, 4 PV
								Debug.Log("RESIDENCIA ACTIVA (+4 PV por 9 plantaciones o menos)");
								player.playerBoard.vp += 4;
							} else if(numPlantations == 10) { // Por 10 plantaciones, 5 PV
								Debug.Log("RESIDENCIA ACTIVA (+5 PV por 10 plantaciones)");
								player.playerBoard.vp += 5;
							} else if(numPlantations == 11) { // Por 11 plantaciones, 6 PV
								Debug.Log("RESIDENCIA ACTIVA (+6 PV por 11 plantaciones)");
								player.playerBoard.vp += 6;
							} else if(numPlantations == 12) { // Por 12 plantaciones, 7 PV
								Debug.Log("RESIDENCIA ACTIVA (+7 PV por 12 plantaciones)");
								player.playerBoard.vp += 7;
							}
							break;
						case BuildingType.FORTRESS:
							if(player.playerBoard.totalColonists >= 3) {
								// 1 PV por cada 3 colonos totales
								fortressVP += Mathf.RoundToInt(player.playerBoard.totalColonists / 3);
								player.playerBoard.vp += fortressVP;
								Debug.Log("COFRADÍA ACTIVA (" + player.playerBoard.totalColonists + "/3 = +" + fortressVP + " PV)");
							}
							break;
						case BuildingType.CUSTOMS_HOUSE:
							if(chipsVP >= 4) {
								// 1 PV por cada 4 PV conseguidos
								Debug.Log("ADUANA ACTIVA (" + chipsVP + "/4 = +" + Mathf.RoundToInt(chipsVP / 4) + " PV)");
								player.playerBoard.vp += Mathf.RoundToInt(chipsVP / 4);
							}
							break;
						case BuildingType.CITY_HALL:
							// 1 PV por cada Edificio lila
							cityHallVP += player.playerBoard.buildings.FindAll(i => i.category == BuildingCategory.PURPLE).Count;
							player.playerBoard.vp += cityHallVP;
							Debug.Log("AYUNTAMIENTO ACTIVO (+" + cityHallVP + " PV por edificios lilas)");
							break;
						default:
							break;
					}
				}
			}
			Debug.Log("PV valor Edificios = " + buildingValueVP);

			Debug.Log("*** TOTAL = " + player.playerBoard.vp + " PV ***");
		}
	}

	void ShowWinner() {
		GameData.players.Sort((p1,p2) => (-1) * p1.playerBoard.vp.CompareTo(p2.playerBoard.vp));

		int nextPlayerIndex = 0;
		for(int actualPlayerIndex = 0; actualPlayerIndex < GameData.players.Count; actualPlayerIndex++) {
			Debug.Log("El jugador a calcular = " + GameData.players[actualPlayerIndex].nickname);
			if(GameData.players[actualPlayerIndex].finalPosition == 0) {
				nextPlayerIndex = actualPlayerIndex + 1;
				if(nextPlayerIndex < GameData.players.Count) {
					Debug.Log("No es el último jugador a calcular");
					// Si el jugador actual tiene más PV que el siguiente jugador, lo añado
					if(GameData.players[actualPlayerIndex].playerBoard.vp > GameData.players[nextPlayerIndex].playerBoard.vp) {
						Debug.Log("El jugador actual tiene más PV que el siguiente, lo añado a la posición " + (actualPlayerIndex+1));
						GameData.players[actualPlayerIndex].finalPosition = actualPlayerIndex+1;
						GameData.finalPlayers.Add(GameData.players[actualPlayerIndex]);
					// Si el jugador actual tiene los mismos PV que el siguiente jugador, calculo monedas y barriles
					} else if(GameData.players[actualPlayerIndex].playerBoard.vp == GameData.players[nextPlayerIndex].playerBoard.vp) {
						Debug.Log("El jugador actual tiene los mismos PV que el siguiente (" + GameData.players[actualPlayerIndex].playerBoard.vp + "=" + GameData.players[nextPlayerIndex].playerBoard.vp + ")");
						GameData.players[actualPlayerIndex].playerBoard.coinsPlusBarrels = GameData.players[actualPlayerIndex].playerBoard.coins + GameData.players[actualPlayerIndex].playerBoard.cornBarrels.Count + GameData.players[actualPlayerIndex].playerBoard.indigoBarrels.Count + GameData.players[actualPlayerIndex].playerBoard.sugarBarrels.Count + GameData.players[actualPlayerIndex].playerBoard.tobaccoBarrels.Count + GameData.players[actualPlayerIndex].playerBoard.coffeeBarrels.Count;
						GameData.players[nextPlayerIndex].playerBoard.coinsPlusBarrels = GameData.players[nextPlayerIndex].playerBoard.coins + GameData.players[nextPlayerIndex].playerBoard.cornBarrels.Count + GameData.players[nextPlayerIndex].playerBoard.indigoBarrels.Count + GameData.players[nextPlayerIndex].playerBoard.sugarBarrels.Count + GameData.players[nextPlayerIndex].playerBoard.tobaccoBarrels.Count + GameData.players[nextPlayerIndex].playerBoard.coffeeBarrels.Count;
						Debug.Log("Jugador actual coinsPlusBarrels = " + GameData.players[actualPlayerIndex].playerBoard.coinsPlusBarrels);
						Debug.Log("Jugador siguiente coinsPlusBarrels = " + GameData.players[nextPlayerIndex].playerBoard.coinsPlusBarrels);
						// Si el jugador actual tiene más monedas y mercancías que el siguiente jugador, lo añado
						if(GameData.players[actualPlayerIndex].playerBoard.coinsPlusBarrels > GameData.players[nextPlayerIndex].playerBoard.coinsPlusBarrels) {
							Debug.Log("El jugador actual tiene más coinsPlusBarrels que el siguiente, lo añado a la posición " + (actualPlayerIndex+1) + " y el siguiente a la posición " + (actualPlayerIndex+2));
							GameData.players[actualPlayerIndex].finalPosition = actualPlayerIndex+1;
							GameData.finalPlayers.Add(GameData.players[actualPlayerIndex]);
							GameData.players[nextPlayerIndex].finalPosition = actualPlayerIndex+2;
							GameData.finalPlayers.Add(GameData.players[nextPlayerIndex]);
						// Si el jugador actual tiene menos monedas y mercancías que el siguiente jugador, los añado
						} else if(GameData.players[actualPlayerIndex].playerBoard.coinsPlusBarrels < GameData.players[nextPlayerIndex].playerBoard.coinsPlusBarrels) {
							Debug.Log("El jugador actual tiene menos coinsPlusBarrels que el siguiente, añado al siguiente a la posición " + (actualPlayerIndex+2) + " y al actual a la posición " + (actualPlayerIndex+1));
							GameData.players[nextPlayerIndex].finalPosition = actualPlayerIndex+2;
							GameData.finalPlayers.Add(GameData.players[nextPlayerIndex]);
							GameData.players[actualPlayerIndex].finalPosition = actualPlayerIndex+1;
							GameData.finalPlayers.Add(GameData.players[actualPlayerIndex]);
						// Si el jugador actual tiene la misma cantidad de monedas y mercancías, los dos han quedado en la misma posición y los añado
						} else if(GameData.players[actualPlayerIndex].playerBoard.coinsPlusBarrels == GameData.players[nextPlayerIndex].playerBoard.coinsPlusBarrels) {
							Debug.Log("El jugador actual tiene la misma cantidad de coinsPlusBarrels que el siguiente, los añado a los dos a la posición " + (actualPlayerIndex+1));
							GameData.players[actualPlayerIndex].finalPosition = actualPlayerIndex+1;
							GameData.finalPlayers.Add(GameData.players[actualPlayerIndex]);
							GameData.players[nextPlayerIndex].finalPosition = actualPlayerIndex+1;
							GameData.finalPlayers.Add(GameData.players[nextPlayerIndex]);
						}
					}
				} else {
					Debug.Log("Es el último jugador a calcular");
					if((actualPlayerIndex-1) >= 0) {
						// Si tenían los mismos PV
						if(GameData.players[actualPlayerIndex].playerBoard.vp == GameData.players[actualPlayerIndex-1].playerBoard.vp) {
							Debug.Log("Tiene los mismos PV que el jugador anterior (" + GameData.players[actualPlayerIndex].playerBoard.vp + "=" + GameData.players[actualPlayerIndex-1].playerBoard.vp + ")");
							GameData.players[actualPlayerIndex].playerBoard.coinsPlusBarrels = GameData.players[actualPlayerIndex].playerBoard.coins + GameData.players[actualPlayerIndex].playerBoard.cornBarrels.Count + GameData.players[actualPlayerIndex].playerBoard.indigoBarrels.Count + GameData.players[actualPlayerIndex].playerBoard.sugarBarrels.Count + GameData.players[actualPlayerIndex].playerBoard.tobaccoBarrels.Count + GameData.players[actualPlayerIndex].playerBoard.coffeeBarrels.Count;
							Debug.Log("Jugador actual coinsPlusBarrels = " + GameData.players[actualPlayerIndex].playerBoard.coinsPlusBarrels);
							Debug.Log("Jugador anterior coinsPlusBarrels = " + GameData.players[actualPlayerIndex-1].playerBoard.coinsPlusBarrels);
							// Si el jugador actual tiene menos monedas y mercancías que el jugador anterior, lo añado
							if(GameData.players[actualPlayerIndex].playerBoard.coinsPlusBarrels < GameData.players[actualPlayerIndex-1].playerBoard.coinsPlusBarrels) {
								Debug.Log("El jugador actual tiene menos coinsPlusBarrels que el anterior, así que lo añado a la posición " + (actualPlayerIndex+1));
								GameData.players[actualPlayerIndex].finalPosition = actualPlayerIndex+1;
								GameData.finalPlayers.Add(GameData.players[actualPlayerIndex]);
							// Si el jugador actual tiene la misma cantidad de monedas y mercancías que el jugador anterior, los dos han quedado en la misma posición
							} else if(GameData.players[actualPlayerIndex].playerBoard.coinsPlusBarrels == GameData.players[actualPlayerIndex-1].playerBoard.coinsPlusBarrels) {
								Debug.Log("El jugador actual tiene los mismos coinsPlusBarrels que el anterior, así que lo añado a la misma posición " + GameData.players[actualPlayerIndex-1].finalPosition);
								GameData.players[actualPlayerIndex].finalPosition = GameData.players[actualPlayerIndex-1].finalPosition;
								GameData.finalPlayers.Add(GameData.players[actualPlayerIndex]);
							}
						// Si no, añado el actual
						} else {
							Debug.Log("Tiene menos PV que el jugador anterior, lo añado a la posición " + (actualPlayerIndex+1));
							GameData.players[actualPlayerIndex].finalPosition = actualPlayerIndex+1;
							GameData.finalPlayers.Add(GameData.players[actualPlayerIndex]);
						}
					} // En principio aquí no tendría que llegar a hacer falta un else
				}
			} else {
				Debug.Log("A este jugador ya se le ha calculado, paso al siguiente");
			}
		}
		Debug.Log("=============");
		foreach(Player player in GameData.finalPlayers) {
			Debug.Log(player.finalPosition + "ª POSICIÓN = " + player.nickname);
		}
	}

	// ==============================
	// 				UI
	// ==============================

	void UIactualizarLabelsInicial() {
		// PLAYER 1
		playerBoard1.GetComponent<UIPlayerBoard>().UIPlayerName.text = GameData.playersByController[0].nickname;
		playerBoard1.GetComponent<UIPlayerBoard>().UIGovernor.SetActive(GameData.playersByController[0].playerBoard.governor);
		playerBoard1.GetComponent<UIPlayerBoard>().UICoins.text = GameData.playersByController[0].playerBoard.coins.ToString();
		playerBoard1.GetComponent<UIPlayerBoard>().UIPlantation1.SetActive(true);
		switch(GameData.playersByController[0].playerBoard.plantations[0].type) {
			case PlantationType.CORN:
				playerBoard1.GetComponent<UIPlayerBoard>().UIPlantation1.GetComponent<Image>().sprite = playerBoard1.GetComponent<UIPlayerBoard>().UIPlantation1.GetComponent<UIPlantation>().UIPlantationCorn;
				break;
			case PlantationType.INDIGO:
				playerBoard1.GetComponent<UIPlayerBoard>().UIPlantation1.GetComponent<Image>().sprite = playerBoard1.GetComponent<UIPlayerBoard>().UIPlantation1.GetComponent<UIPlantation>().UIPlantationIndigo;
				break;
		}

		// PLAYER 2
		playerBoard2.GetComponent<UIPlayerBoard>().UIPlayerName.text = GameData.playersByController[1].nickname;
		playerBoard2.GetComponent<UIPlayerBoard>().UIGovernor.SetActive(GameData.playersByController[1].playerBoard.governor);
		playerBoard2.GetComponent<UIPlayerBoard>().UICoins.text = GameData.playersByController[1].playerBoard.coins.ToString();
		playerBoard2.GetComponent<UIPlayerBoard>().UIPlantation1.SetActive(true);
		switch(GameData.playersByController[1].playerBoard.plantations[0].type) {
			case PlantationType.CORN:
				playerBoard2.GetComponent<UIPlayerBoard>().UIPlantation1.GetComponent<Image>().sprite = playerBoard2.GetComponent<UIPlayerBoard>().UIPlantation1.GetComponent<UIPlantation>().UIPlantationCorn;
				break;
			case PlantationType.INDIGO:
				playerBoard2.GetComponent<UIPlayerBoard>().UIPlantation1.GetComponent<Image>().sprite = playerBoard2.GetComponent<UIPlayerBoard>().UIPlantation1.GetComponent<UIPlantation>().UIPlantationIndigo;
				break;
		}
		
		if(GameData.totalPlayers > 2) {
			// PLAYER 3
			playerBoard3.GetComponent<UIPlayerBoard>().UIPlayerName.text = GameData.playersByController[2].nickname;
			playerBoard3.GetComponent<UIPlayerBoard>().UIGovernor.SetActive(GameData.playersByController[2].playerBoard.governor);
			playerBoard3.GetComponent<UIPlayerBoard>().UICoins.text = GameData.playersByController[2].playerBoard.coins.ToString();
			playerBoard3.GetComponent<UIPlayerBoard>().UIPlantation1.SetActive(true);
			switch(GameData.playersByController[2].playerBoard.plantations[0].type) {
				case PlantationType.CORN:
					playerBoard3.GetComponent<UIPlayerBoard>().UIPlantation1.GetComponent<Image>().sprite = playerBoard3.GetComponent<UIPlayerBoard>().UIPlantation1.GetComponent<UIPlantation>().UIPlantationCorn;
					break;
				case PlantationType.INDIGO:
					playerBoard3.GetComponent<UIPlayerBoard>().UIPlantation1.GetComponent<Image>().sprite = playerBoard3.GetComponent<UIPlayerBoard>().UIPlantation1.GetComponent<UIPlantation>().UIPlantationIndigo;
					break;
			}
			
			if(GameData.totalPlayers > 3) {
				// PLAYER 4
				playerBoard4.GetComponent<UIPlayerBoard>().UIPlayerName.text = GameData.playersByController[3].nickname;
				playerBoard4.GetComponent<UIPlayerBoard>().UIGovernor.SetActive(GameData.playersByController[3].playerBoard.governor);
				playerBoard4.GetComponent<UIPlayerBoard>().UICoins.text = GameData.playersByController[3].playerBoard.coins.ToString();
				playerBoard4.GetComponent<UIPlayerBoard>().UIPlantation1.SetActive(true);
				switch(GameData.playersByController[3].playerBoard.plantations[0].type) {
					case PlantationType.CORN:
						playerBoard4.GetComponent<UIPlayerBoard>().UIPlantation1.GetComponent<Image>().sprite = playerBoard4.GetComponent<UIPlayerBoard>().UIPlantation1.GetComponent<UIPlantation>().UIPlantationCorn;
						break;
					case PlantationType.INDIGO:
						playerBoard4.GetComponent<UIPlayerBoard>().UIPlantation1.GetComponent<Image>().sprite = playerBoard4.GetComponent<UIPlayerBoard>().UIPlantation1.GetComponent<UIPlantation>().UIPlantationIndigo;
						break;
				}
				
				if(GameData.totalPlayers > 4) {
					// PLAYER 5
					playerBoard5.GetComponent<UIPlayerBoard>().UIPlayerName.text = GameData.playersByController[4].nickname;
					playerBoard5.GetComponent<UIPlayerBoard>().UIGovernor.SetActive(GameData.playersByController[4].playerBoard.governor);
					playerBoard5.GetComponent<UIPlayerBoard>().UICoins.text = GameData.playersByController[4].playerBoard.coins.ToString();
					playerBoard5.GetComponent<UIPlayerBoard>().UIPlantation1.SetActive(true);
					switch(GameData.playersByController[4].playerBoard.plantations[0].type) {
						case PlantationType.CORN:
							playerBoard5.GetComponent<UIPlayerBoard>().UIPlantation1.GetComponent<Image>().sprite = playerBoard5.GetComponent<UIPlayerBoard>().UIPlantation1.GetComponent<UIPlantation>().UIPlantationCorn;
							break;
						case PlantationType.INDIGO:
							playerBoard5.GetComponent<UIPlayerBoard>().UIPlantation1.GetComponent<Image>().sprite = playerBoard5.GetComponent<UIPlayerBoard>().UIPlantation1.GetComponent<UIPlantation>().UIPlantationIndigo;
							break;
					}
				}
			}
		}

		// Plantaciones descubiertas
		GetScriptUIPlantationBoard().RefreshPlantations();

		// Barriles de la reserva
		barrelReservation.GetComponent<UIBarrelReservation>().UICornBarrels.text = GameData.cornBarrels.Count.ToString();
		barrelReservation.GetComponent<UIBarrelReservation>().UIIndigoBarrels.text = GameData.indigoBarrels.Count.ToString();
		barrelReservation.GetComponent<UIBarrelReservation>().UISugarBarrels.text = GameData.sugarBarrels.Count.ToString();
		barrelReservation.GetComponent<UIBarrelReservation>().UITobaccoBarrels.text = GameData.tobaccoBarrels.Count.ToString();
		barrelReservation.GetComponent<UIBarrelReservation>().UICoffeeBarrels.text = GameData.coffeeBarrels.Count.ToString();

		// Puntos de victoria
		VPReservation.GetComponent<UIVPReservation>().UIVP.text = GameData.victoryPoinsReserve.ToString();

		// Monedas banco
		centralBoard.GetComponent<UICentralBoard>().UICoins.text = GameData.bankCoins.ToString();

		// Edificios mercado
		centralBoard.GetComponent<UICentralBoard>().UISmallIndigoPlant.GetComponent<UIBuilding>().UIPrice.text = GameData.listSmallIndigoPlant[0].price.ToString();
		centralBoard.GetComponent<UICentralBoard>().UISmallIndigoPlant.GetComponent<UIBuilding>().UIQuantity.text = GameData.listSmallIndigoPlant.Count.ToString();
		centralBoard.GetComponent<UICentralBoard>().UISmallSugarMill.GetComponent<UIBuilding>().UIPrice.text = GameData.listSmallSugarMill[0].price.ToString();
		centralBoard.GetComponent<UICentralBoard>().UISmallSugarMill.GetComponent<UIBuilding>().UIQuantity.text = GameData.listSmallSugarMill.Count.ToString();
		centralBoard.GetComponent<UICentralBoard>().UISmallMarket.GetComponent<UIBuilding>().UIPrice.text = GameData.listSmallMarket[0].price.ToString();
		centralBoard.GetComponent<UICentralBoard>().UISmallMarket.GetComponent<UIBuilding>().UIQuantity.text = GameData.listSmallMarket.Count.ToString();
		centralBoard.GetComponent<UICentralBoard>().UIHacienda.GetComponent<UIBuilding>().UIPrice.text = GameData.listHacienda[0].price.ToString();
		centralBoard.GetComponent<UICentralBoard>().UIHacienda.GetComponent<UIBuilding>().UIQuantity.text = GameData.listHacienda.Count.ToString();
		centralBoard.GetComponent<UICentralBoard>().UIConstructionHut.GetComponent<UIBuilding>().UIPrice.text = GameData.listConstructionHut[0].price.ToString();
		centralBoard.GetComponent<UICentralBoard>().UIConstructionHut.GetComponent<UIBuilding>().UIQuantity.text = GameData.listConstructionHut.Count.ToString();
		centralBoard.GetComponent<UICentralBoard>().UISmallWarehouse.GetComponent<UIBuilding>().UIPrice.text = GameData.listSmallWarehouse[0].price.ToString();
		centralBoard.GetComponent<UICentralBoard>().UISmallWarehouse.GetComponent<UIBuilding>().UIQuantity.text = GameData.listSmallWarehouse.Count.ToString();
		
		centralBoard.GetComponent<UICentralBoard>().UIIndigoPlant.GetComponent<UIBuilding>().UIPrice.text = GameData.listIndigoPlant[0].price.ToString();
		centralBoard.GetComponent<UICentralBoard>().UIIndigoPlant.GetComponent<UIBuilding>().UIQuantity.text = GameData.listIndigoPlant.Count.ToString();
		centralBoard.GetComponent<UICentralBoard>().UISugarMill.GetComponent<UIBuilding>().UIPrice.text = GameData.listSugarMill[0].price.ToString();
		centralBoard.GetComponent<UICentralBoard>().UISugarMill.GetComponent<UIBuilding>().UIQuantity.text = GameData.listSugarMill.Count.ToString();
		centralBoard.GetComponent<UICentralBoard>().UIHospice.GetComponent<UIBuilding>().UIPrice.text = GameData.listHospice[0].price.ToString();
		centralBoard.GetComponent<UICentralBoard>().UIHospice.GetComponent<UIBuilding>().UIQuantity.text = GameData.listHospice.Count.ToString();
		centralBoard.GetComponent<UICentralBoard>().UIOffice.GetComponent<UIBuilding>().UIPrice.text = GameData.listOffice[0].price.ToString();
		centralBoard.GetComponent<UICentralBoard>().UIOffice.GetComponent<UIBuilding>().UIQuantity.text = GameData.listOffice.Count.ToString();
		centralBoard.GetComponent<UICentralBoard>().UILargeMarket.GetComponent<UIBuilding>().UIPrice.text = GameData.listLargeMarket[0].price.ToString();
		centralBoard.GetComponent<UICentralBoard>().UILargeMarket.GetComponent<UIBuilding>().UIQuantity.text = GameData.listLargeMarket.Count.ToString();
		centralBoard.GetComponent<UICentralBoard>().UILargeWarehouse.GetComponent<UIBuilding>().UIPrice.text = GameData.listLargeWarehouse[0].price.ToString();
		centralBoard.GetComponent<UICentralBoard>().UILargeWarehouse.GetComponent<UIBuilding>().UIQuantity.text = GameData.listLargeWarehouse.Count.ToString();

		centralBoard.GetComponent<UICentralBoard>().UITobaccoStorage.GetComponent<UIBuilding>().UIPrice.text = GameData.listTobaccoStorage[0].price.ToString();
		centralBoard.GetComponent<UICentralBoard>().UITobaccoStorage.GetComponent<UIBuilding>().UIQuantity.text = GameData.listTobaccoStorage.Count.ToString();
		centralBoard.GetComponent<UICentralBoard>().UICoffeeToaster.GetComponent<UIBuilding>().UIPrice.text = GameData.listCoffeeToaster[0].price.ToString();
		centralBoard.GetComponent<UICentralBoard>().UICoffeeToaster.GetComponent<UIBuilding>().UIQuantity.text = GameData.listCoffeeToaster.Count.ToString();
		centralBoard.GetComponent<UICentralBoard>().UIFactory.GetComponent<UIBuilding>().UIPrice.text = GameData.listFactory[0].price.ToString();
		centralBoard.GetComponent<UICentralBoard>().UIFactory.GetComponent<UIBuilding>().UIQuantity.text = GameData.listFactory.Count.ToString();
		centralBoard.GetComponent<UICentralBoard>().UIUniversity.GetComponent<UIBuilding>().UIPrice.text = GameData.listUniversity[0].price.ToString();
		centralBoard.GetComponent<UICentralBoard>().UIUniversity.GetComponent<UIBuilding>().UIQuantity.text = GameData.listUniversity.Count.ToString();
		centralBoard.GetComponent<UICentralBoard>().UIHarbor.GetComponent<UIBuilding>().UIPrice.text = GameData.listHarbor[0].price.ToString();
		centralBoard.GetComponent<UICentralBoard>().UIHarbor.GetComponent<UIBuilding>().UIQuantity.text = GameData.listHarbor.Count.ToString();
		centralBoard.GetComponent<UICentralBoard>().UIWharf.GetComponent<UIBuilding>().UIPrice.text = GameData.listWharf[0].price.ToString();
		centralBoard.GetComponent<UICentralBoard>().UIWharf.GetComponent<UIBuilding>().UIQuantity.text = GameData.listWharf.Count.ToString();

		centralBoard.GetComponent<UICentralBoard>().UIGuildHall.GetComponent<UIBuilding>().UIPrice.text = GameData.guildHall.price.ToString();
		centralBoard.GetComponent<UICentralBoard>().UIResidence.GetComponent<UIBuilding>().UIPrice.text = GameData.residence.price.ToString();
		centralBoard.GetComponent<UICentralBoard>().UIFortress.GetComponent<UIBuilding>().UIPrice.text = GameData.fortress.price.ToString();
		centralBoard.GetComponent<UICentralBoard>().UICustomsHouse.GetComponent<UIBuilding>().UIPrice.text = GameData.customsHouse.price.ToString();
		centralBoard.GetComponent<UICentralBoard>().UICityHall.GetComponent<UIBuilding>().UIPrice.text = GameData.cityHall.price.ToString();

		GetScriptUIColonistShip().RefreshShipLabels(GameData.colonistShip);
	}
}