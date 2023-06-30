using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControllerManager : MonoBehaviour {

	public GameObject PanelPlayer1NoSelected;
	public GameObject PanelPlayer2NoSelected;
	public GameObject PanelPlayer3NoSelected;
	public GameObject PanelPlayer4NoSelected;
	public GameObject PanelPlayer5NoSelected;

	public GameObject PanelPlayer1;
	public GameObject PanelPlayer2;
	public GameObject PanelPlayer3;
	public GameObject PanelPlayer4;
	public GameObject PanelPlayer5;

	public List<Player> listPlayersAvailable { get; set; }

	public bool player1Finished { get; set; }
	public bool player2Finished { get; set; }
	public bool player3Finished { get; set; }
	public bool player4Finished { get; set; }
	public bool player5Finished { get; set; }

	public int player1SelectedPlayer { get; set; }
	public int player2SelectedPlayer { get; set; }
	public int player3SelectedPlayer { get; set; }
	public int player4SelectedPlayer { get; set; }
	public int player5SelectedPlayer { get; set; }

	public int controllerPlayer1 { get; set; }
	public int controllerPlayer2 { get; set; }
	public int controllerPlayer3 { get; set; }
	public int controllerPlayer4 { get; set; }
	public int controllerPlayer5 { get; set; }

	InputType controller1Input { get; set; }
	InputType controller2Input { get; set; }
	InputType controller3Input { get; set; }
	InputType controller4Input { get; set; }
	InputType controller5Input { get; set; }

	InputType player1Input { get; set; }
	InputType player2Input { get; set; }
	InputType player3Input { get; set; }
	InputType player4Input { get; set; }
	InputType player5Input { get; set; }

	// Use this for initialization
	void Start () {
		listPlayersAvailable = new List<Player>(5);
		listPlayersAvailable.Add(new Player("Toni", 1));
		listPlayersAvailable.Add(new Player("Alva", 2));
		listPlayersAvailable.Add(new Player("Edu", 3));
		listPlayersAvailable.Add(new Player("Sergio", 4));
		listPlayersAvailable.Add(new Player("Óscar", 5));

		player1Finished = false;
		player2Finished = false;
		player3Finished = false;
		player4Finished = false;
		player5Finished = false;

		player1SelectedPlayer = 0;
		player2SelectedPlayer = 0;
		player3SelectedPlayer = 0;
		player4SelectedPlayer = 0;
		player5SelectedPlayer = 0;

		controllerPlayer1 = -1;
		controllerPlayer2 = -1;
		controllerPlayer3 = -1;
		controllerPlayer4 = -1;
		controllerPlayer5 = -1;

		controller1Input = InputType.PLAYER1_IDLE;
		controller2Input = InputType.PLAYER2_IDLE;
		controller3Input = InputType.PLAYER3_IDLE;
		controller4Input = InputType.PLAYER4_IDLE;
		controller5Input = InputType.PLAYER5_IDLE;

		player1Input = InputType.PLAYER1_IDLE;
		player2Input = InputType.PLAYER2_IDLE;
		player3Input = InputType.PLAYER3_IDLE;
		player4Input = InputType.PLAYER4_IDLE;
		player5Input = InputType.PLAYER5_IDLE;

		PanelPlayer1NoSelected.SetActive(true);
		PanelPlayer2NoSelected.SetActive(true);
		PanelPlayer3NoSelected.SetActive(true);
		PanelPlayer4NoSelected.SetActive(true);
		PanelPlayer5NoSelected.SetActive(true);
		PanelPlayer1NoSelected.GetComponentInChildren<Text>().text = "PLAYER 1";
		PanelPlayer2NoSelected.GetComponentInChildren<Text>().text = "PLAYER 2";
		PanelPlayer3NoSelected.GetComponentInChildren<Text>().text = "PLAYER 3";
		PanelPlayer4NoSelected.GetComponentInChildren<Text>().text = "PLAYER 4";
		PanelPlayer5NoSelected.GetComponentInChildren<Text>().text = "PLAYER 5";

		PanelPlayer1.SetActive(false);
		PanelPlayer2.SetActive(false);
		PanelPlayer3.SetActive(false);
		PanelPlayer4.SetActive(false);
		PanelPlayer5.SetActive(false);
		PanelPlayer1.transform.Find("PlayerName").gameObject.GetComponent<Text>().text = listPlayersAvailable[player1SelectedPlayer].nickname;
		PanelPlayer2.transform.Find("PlayerName").gameObject.GetComponent<Text>().text = listPlayersAvailable[player2SelectedPlayer].nickname;
		PanelPlayer3.transform.Find("PlayerName").gameObject.GetComponent<Text>().text = listPlayersAvailable[player3SelectedPlayer].nickname;
		PanelPlayer4.transform.Find("PlayerName").gameObject.GetComponent<Text>().text = listPlayersAvailable[player4SelectedPlayer].nickname;
		PanelPlayer5.transform.Find("PlayerName").gameObject.GetComponent<Text>().text = listPlayersAvailable[player5SelectedPlayer].nickname;
	}
	
	// Update is called once per frame
	void Update () {
		// ===================
		// CONTROLLER PLAYER 1
		// ===================

		// Si ya se ha asignado un mando al Player 1
		if(controllerPlayer1 != -1) {
			// Si aún no ha elegido Player, puede mover el cursor
			if(!player1Finished) {
				player1Input = InputManager.CalculateIdle(controllerPlayer1, player1Input);

				if(player1Input != InputManager.GetIdle(controllerPlayer1))
					player1Input = MoveCursor(player1Input, controllerPlayer1, 1, PanelPlayer1);

				// SUBMIT
				if(InputManager.Submit(controllerPlayer1)) {
					// Si el Player seleccionado no ha sido seleccionado por otro, lo selecciona
					if(!listPlayersAvailable[player1SelectedPlayer].selected) {
						Debug.Log("¡PLAYER 1 HA SELECCIONADO NOMBRE!");
						player1Finished = true;
						listPlayersAvailable[player1SelectedPlayer].selected = true;
						listPlayersAvailable[player1SelectedPlayer].controller = controllerPlayer1;
						PanelPlayer1.transform.Find("PanelFinished").gameObject.SetActive(true);
					} else {
						// TODO SONIDO NO SELECCIONABLE
						Debug.Log("¡PLAYER 1 NO PUEDE ELEGIR ESE NOMBRE!");
					}
				}
			}
			// CANCEL
			if(InputManager.Cancel(controllerPlayer1)) {
				// Si el Player ya había acabado, desactiva FINISHED
				if(player1Finished) {
					Debug.Log("¡PLAYER 1 HA CANCELADO EL NOMBRE!");
					player1Finished = false;
					listPlayersAvailable[player1SelectedPlayer].selected = false;
					listPlayersAvailable[player1SelectedPlayer].controller = -1;
					PanelPlayer1.transform.Find("PanelFinished").gameObject.SetActive(false);
				// Si aún no se había elegido Player, desasigna el mando
				} else {
					Debug.Log("¡PLAYER 1 SE HA IDO!");
					controllerPlayer1 = -1;
					PanelPlayer1NoSelected.SetActive(true);
					PanelPlayer1.SetActive(false);
				}
			}
		// Si no se ha asignado mando al Player 1
		} else {
			// Debug.Log("Esperando Input para Player 1...");
			if(ControllerNotAssigned(1)) { // Si el mando 1 no está asignado a nadie
				controller1Input = InputManager.CalculateIdle(1, controller1Input);
				// En cuanto se reciba un input, se asigna el número del mando al Player
				if(controller1Input == InputManager.GetIdle(1)) {
					controller1Input = DetectInput(controller1Input, 1);
				} else {
					controllerPlayer1 = 1;
					PanelPlayer1NoSelected.SetActive(false);
					PanelPlayer1.SetActive(true);
					Debug.Log("PLAYER 1 ACTIVADO CON MANDO "+controllerPlayer1);
				}
			}
			if(ControllerNotAssigned(2)) { // Si el mando 2 no está asignado a nadie
				controller2Input = InputManager.CalculateIdle(2, controller2Input);
				// En cuanto se reciba un input, se asigna el número del mando al Player
				if(controller2Input == InputManager.GetIdle(2)) {
					controller2Input = DetectInput(controller2Input, 2);
				} else {
					controllerPlayer1 = 2;
					PanelPlayer1NoSelected.SetActive(false);
					PanelPlayer1.SetActive(true);
					Debug.Log("PLAYER 1 ACTIVADO CON MANDO "+controllerPlayer1);
				}
			}
			if(ControllerNotAssigned(3)) { // Si el mando 3 no está asignado a nadie
				controller3Input = InputManager.CalculateIdle(3, controller3Input);
				// En cuanto se reciba un input, se asigna el número del mando al Player
				if(controller3Input == InputManager.GetIdle(3)) {
					controller3Input = DetectInput(controller3Input, 3);
				} else {
					controllerPlayer1 = 3;
					PanelPlayer1NoSelected.SetActive(false);
					PanelPlayer1.SetActive(true);
					Debug.Log("PLAYER 1 ACTIVADO CON MANDO "+controllerPlayer1);
				}
			}
			if(ControllerNotAssigned(4)) { // Si el mando 4 no está asignado a nadie
				controller4Input = InputManager.CalculateIdle(4, controller4Input);
				// En cuanto se reciba un input, se asigna el número del mando al Player
				if(controller4Input == InputManager.GetIdle(4)) {
					controller4Input = DetectInput(controller4Input, 4);
				} else {
					controllerPlayer1 = 4;
					PanelPlayer1NoSelected.SetActive(false);
					PanelPlayer1.SetActive(true);
					Debug.Log("PLAYER 1 ACTIVADO CON MANDO "+controllerPlayer1);
				}
			}
			if(ControllerNotAssigned(5)) { // Si el mando 5 no está asignado a nadie
				controller5Input = InputManager.CalculateIdle(5, controller5Input);
				// En cuanto se reciba un input, se asigna el número del mando al Player
				if(controller5Input == InputManager.GetIdle(5)) {
					controller5Input = DetectInput(controller5Input, 5);
				} else {
					controllerPlayer1 = 5;
					PanelPlayer1NoSelected.SetActive(false);
					PanelPlayer1.SetActive(true);
					Debug.Log("PLAYER 1 ACTIVADO CON MANDO "+controllerPlayer1);
				}
			}
		}

		// ===================
		// CONTROLLER PLAYER 2
		// ===================
		
		// Si ya he asignado un mando al Player 1
		if(controllerPlayer1 != -1) {
			// Si ya se ha asignado un mando al Player 2
			if(controllerPlayer2 != -1) {
				// Si aún no ha elegido Player, puede mover el cursor
				if(!player2Finished) {
					player2Input = InputManager.CalculateIdle(controllerPlayer2, player2Input);

					if(player2Input != InputManager.GetIdle(controllerPlayer2))
						player2Input = MoveCursor(player2Input, controllerPlayer2, 2, PanelPlayer2);

					// SUBMIT
					if(InputManager.Submit(controllerPlayer2)) {
						// Si el Player seleccionado no ha sido seleccionado por otro, lo selecciona
						if(!listPlayersAvailable[player2SelectedPlayer].selected) {
							Debug.Log("¡PLAYER 2 HA SELECCIONADO NOMBRE!");
							player2Finished = true;
							listPlayersAvailable[player2SelectedPlayer].selected = true;
							listPlayersAvailable[player2SelectedPlayer].controller = controllerPlayer2;
							PanelPlayer2.transform.Find("PanelFinished").gameObject.SetActive(true);
						} else {
							// TODO SONIDO NO SELECCIONABLE
							Debug.Log("¡PLAYER 2 NO PUEDE ELEGIR ESE NOMBRE!");
						}
					}
				}
				// CANCEL
				if(InputManager.Cancel(controllerPlayer2)) {
					// Si el Player ya había acabado, desactiva FINISHED
					if(player2Finished) {
						Debug.Log("¡PLAYER 2 HA CANCELADO EL NOMBRE!");
						player2Finished = false;
						listPlayersAvailable[player2SelectedPlayer].selected = false;
						listPlayersAvailable[player2SelectedPlayer].controller = -1;
						PanelPlayer2.transform.Find("PanelFinished").gameObject.SetActive(false);
					// Si aún no se había elegido Player, desasigna el mando
					} else {
						Debug.Log("¡PLAYER 2 SE HA IDO!");
						controllerPlayer2 = -1;
						PanelPlayer2NoSelected.SetActive(true);
						PanelPlayer2.SetActive(false);
					}
				}
			// Si no se ha asignado mando al Player 2 y los Player anteriores ya están asignados
			} else if(controllerPlayer1 != -1) {
				//Debug.Log("Esperando Input para Player 2");
				if(ControllerNotAssigned(1)) { // Si el mando 1 no está asignado a nadie
					controller1Input = InputManager.CalculateIdle(1, controller1Input);
					// En cuanto se reciba un input, se asigna el número del mando al Player
					if(controller1Input == InputManager.GetIdle(1)) {
						controller1Input = DetectInput(controller1Input, 1);
					} else {
						controllerPlayer2 = 1;
						PanelPlayer2NoSelected.SetActive(false);
						PanelPlayer2.SetActive(true);
						Debug.Log("PLAYER 2 ACTIVADO CON MANDO "+controllerPlayer1);
					}
				}
				if(ControllerNotAssigned(2)) { // Si el mando 2 no está asignado a nadie
					controller2Input = InputManager.CalculateIdle(2, controller2Input);
					// En cuanto se reciba un input, se asigna el número del mando al Player
					if(controller2Input == InputManager.GetIdle(2)) {
						controller2Input = DetectInput(controller2Input, 2);
					} else {
						controllerPlayer2 = 2;
						PanelPlayer2NoSelected.SetActive(false);
						PanelPlayer2.SetActive(true);
						Debug.Log("PLAYER 2 ACTIVADO CON MANDO "+controllerPlayer1);
					}
				}
				if(ControllerNotAssigned(3)) { // Si el mando 3 no está asignado a nadie
					controller3Input = InputManager.CalculateIdle(3, controller3Input);
					// En cuanto se reciba un input, se asigna el número del mando al Player
					if(controller3Input == InputManager.GetIdle(3)) {
						controller3Input = DetectInput(controller3Input, 3);
					} else {
						controllerPlayer2 = 3;
						PanelPlayer2NoSelected.SetActive(false);
						PanelPlayer2.SetActive(true);
						Debug.Log("PLAYER 2 ACTIVADO CON MANDO "+controllerPlayer1);
					}
				}
				if(ControllerNotAssigned(4)) { // Si el mando 4 no está asignado a nadie
					controller4Input = InputManager.CalculateIdle(4, controller4Input);
					// En cuanto se reciba un input, se asigna el número del mando al Player
					if(controller4Input == InputManager.GetIdle(4)) {
						controller4Input = DetectInput(controller4Input, 4);
					} else {
						controllerPlayer2 = 4;
						PanelPlayer2NoSelected.SetActive(false);
						PanelPlayer2.SetActive(true);
						Debug.Log("PLAYER 2 ACTIVADO CON MANDO "+controllerPlayer1);
					}
				}
				if(ControllerNotAssigned(5)) { // Si el mando 5 no está asignado a nadie
					controller5Input = InputManager.CalculateIdle(5, controller5Input);
					// En cuanto se reciba un input, se asigna el número del mando al Player
					if(controller5Input == InputManager.GetIdle(5)) {
						controller5Input = DetectInput(controller5Input, 5);
					} else {
						controllerPlayer2 = 5;
						PanelPlayer2NoSelected.SetActive(false);
						PanelPlayer2.SetActive(true);
						Debug.Log("PLAYER 2 ACTIVADO CON MANDO "+controllerPlayer1);
					}
				}
			}
		}

		// ===================
		// CONTROLLER PLAYER 3
		// ===================
		
		// Si ya he asignado un mando al Player 2
		if(controllerPlayer2 != -1) {
			// Si ya se ha asignado un mando al Player 3
			if(controllerPlayer3 != -1) {
				// Si aún no ha elegido Player, puede mover el cursor
				if(!player3Finished) {
					player3Input = InputManager.CalculateIdle(controllerPlayer3, player3Input);

					if(player3Input != InputManager.GetIdle(controllerPlayer3))
						player3Input = MoveCursor(player3Input, controllerPlayer3, 3, PanelPlayer3);

					// SUBMIT
					if(InputManager.Submit(controllerPlayer3)) {
						// Si el Player seleccionado no ha sido seleccionado por otro, lo selecciona
						if(!listPlayersAvailable[player3SelectedPlayer].selected) {
							Debug.Log("¡PLAYER 3 HA SELECCIONADO NOMBRE!");
							player3Finished = true;
							listPlayersAvailable[player3SelectedPlayer].selected = true;
							listPlayersAvailable[player3SelectedPlayer].controller = controllerPlayer3;
							PanelPlayer3.transform.Find("PanelFinished").gameObject.SetActive(true);
						} else {
							// TODO SONIDO NO SELECCIONABLE
							Debug.Log("¡PLAYER 3 NO PUEDE ELEGIR ESE NOMBRE!");
						}
					}
				}
				// CANCEL
				if(InputManager.Cancel(controllerPlayer3)) {
					// Si el Player ya había acabado, desactiva FINISHED
					if(player3Finished) {
						Debug.Log("¡PLAYER 3 HA CANCELADO EL NOMBRE!");
						player3Finished = false;
						listPlayersAvailable[player3SelectedPlayer].selected = false;
						listPlayersAvailable[player3SelectedPlayer].controller = -1;
						PanelPlayer3.transform.Find("PanelFinished").gameObject.SetActive(false);
					// Si aún no se había elegido Player, desasigna el mando
					} else {
						Debug.Log("¡PLAYER 3 SE HA IDO!");
						controllerPlayer3 = -1;
						PanelPlayer3NoSelected.SetActive(true);
						PanelPlayer3.SetActive(false);
					}
				}
			// Si no se ha asignado mando al Player 3 y los Player anteriores ya están asignados
			} else if(controllerPlayer1 != -1 && controllerPlayer2 != -1) {
				//Debug.Log("Esperando Input para Player 3");
				if(ControllerNotAssigned(1)) { // Si el mando 1 no está asignado a nadie
					controller1Input = InputManager.CalculateIdle(1, controller1Input);
					// En cuanto se reciba un input, se asigna el número del mando al Player
					if(controller1Input == InputManager.GetIdle(1)) {
						controller1Input = DetectInput(controller1Input, 1);
					} else {
						controllerPlayer3 = 1;
						PanelPlayer3NoSelected.SetActive(false);
						PanelPlayer3.SetActive(true);
						Debug.Log("PLAYER 3 ACTIVADO CON MANDO "+controllerPlayer1);
					}
				}
				if(ControllerNotAssigned(2)) { // Si el mando 2 no está asignado a nadie
					controller2Input = InputManager.CalculateIdle(2, controller2Input);
					// En cuanto se reciba un input, se asigna el número del mando al Player
					if(controller2Input == InputManager.GetIdle(2)) {
						controller2Input = DetectInput(controller2Input, 2);
					} else {
						controllerPlayer3 = 2;
						PanelPlayer3NoSelected.SetActive(false);
						PanelPlayer3.SetActive(true);
						Debug.Log("PLAYER 3 ACTIVADO CON MANDO "+controllerPlayer1);
					}
				}
				if(ControllerNotAssigned(3)) { // Si el mando 3 no está asignado a nadie
					controller3Input = InputManager.CalculateIdle(3, controller3Input);
					// En cuanto se reciba un input, se asigna el número del mando al Player
					if(controller3Input == InputManager.GetIdle(3)) {
						controller3Input = DetectInput(controller3Input, 3);
					} else {
						controllerPlayer3 = 3;
						PanelPlayer3NoSelected.SetActive(false);
						PanelPlayer3.SetActive(true);
						Debug.Log("PLAYER 3 ACTIVADO CON MANDO "+controllerPlayer1);
					}
				}
				if(ControllerNotAssigned(4)) { // Si el mando 4 no está asignado a nadie
					controller4Input = InputManager.CalculateIdle(4, controller4Input);
					// En cuanto se reciba un input, se asigna el número del mando al Player
					if(controller4Input == InputManager.GetIdle(4)) {
						controller4Input = DetectInput(controller4Input, 4);
					} else {
						controllerPlayer3 = 4;
						PanelPlayer3NoSelected.SetActive(false);
						PanelPlayer3.SetActive(true);
						Debug.Log("PLAYER 3 ACTIVADO CON MANDO "+controllerPlayer1);
					}
				}
				if(ControllerNotAssigned(5)) { // Si el mando 5 no está asignado a nadie
					controller5Input = InputManager.CalculateIdle(5, controller5Input);
					// En cuanto se reciba un input, se asigna el número del mando al Player
					if(controller5Input == InputManager.GetIdle(5)) {
						controller5Input = DetectInput(controller5Input, 5);
					} else {
						controllerPlayer3 = 5;
						PanelPlayer3NoSelected.SetActive(false);
						PanelPlayer3.SetActive(true);
						Debug.Log("PLAYER 3 ACTIVADO CON MANDO "+controllerPlayer1);
					}
				}
			}
		}

		// ===================
		// CONTROLLER PLAYER 4
		// ===================
		
		// Si ya he asignado un mando al Player 3
		if(controllerPlayer3 != -1) {
			// Si ya se ha asignado un mando al Player 4
			if(controllerPlayer4 != -1) {
				// Si aún no ha elegido Player, puede mover el cursor
				if(!player4Finished) {
					player4Input = InputManager.CalculateIdle(controllerPlayer4, player4Input);

					if(player4Input != InputManager.GetIdle(controllerPlayer4))
						player4Input = MoveCursor(player4Input, controllerPlayer4, 4, PanelPlayer4);

					// SUBMIT
					if(InputManager.Submit(controllerPlayer4)) {
						// Si el Player seleccionado no ha sido seleccionado por otro, lo selecciona
						if(!listPlayersAvailable[player4SelectedPlayer].selected) {
							Debug.Log("¡PLAYER 4 HA SELECCIONADO NOMBRE!");
							player4Finished = true;
							listPlayersAvailable[player4SelectedPlayer].selected = true;
							listPlayersAvailable[player4SelectedPlayer].controller = controllerPlayer4;
							PanelPlayer4.transform.Find("PanelFinished").gameObject.SetActive(true);
						} else {
							// TODO SONIDO NO SELECCIONABLE
							Debug.Log("¡PLAYER 4 NO PUEDE ELEGIR ESE NOMBRE!");
						}
					}
				}
				// CANCEL
				if(InputManager.Cancel(controllerPlayer4)) {
					// Si el Player ya había acabado, desactiva FINISHED
					if(player4Finished) {
						Debug.Log("¡PLAYER 4 HA CANCELADO EL NOMBRE!");
						player4Finished = false;
						listPlayersAvailable[player4SelectedPlayer].selected = false;
						listPlayersAvailable[player4SelectedPlayer].controller = -1;
						PanelPlayer4.transform.Find("PanelFinished").gameObject.SetActive(false);
					// Si aún no se había elegido Player, desasigna el mando
					} else {
						Debug.Log("¡PLAYER 4 SE HA IDO!");
						controllerPlayer4 = -1;
						PanelPlayer4NoSelected.SetActive(true);
						PanelPlayer4.SetActive(false);
					}
				}
			// Si no se ha asignado mando al Player 4 y los Player anteriores ya están asignados
			} else if(controllerPlayer1 != -1 && controllerPlayer2 != -1 && controllerPlayer3 != -1) {
				//Debug.Log("Esperando Input para Player 4");
				if(ControllerNotAssigned(1)) { // Si el mando 1 no está asignado a nadie
					controller1Input = InputManager.CalculateIdle(1, controller1Input);
					// En cuanto se reciba un input, se asigna el número del mando al Player
					if(controller1Input == InputManager.GetIdle(1)) {
						controller1Input = DetectInput(controller1Input, 1);
					} else {
						controllerPlayer4 = 1;
						PanelPlayer4NoSelected.SetActive(false);
						PanelPlayer4.SetActive(true);
						Debug.Log("PLAYER 4 ACTIVADO CON MANDO "+controllerPlayer1);
					}
				}
				if(ControllerNotAssigned(2)) { // Si el mando 2 no está asignado a nadie
					controller2Input = InputManager.CalculateIdle(2, controller2Input);
					// En cuanto se reciba un input, se asigna el número del mando al Player
					if(controller2Input == InputManager.GetIdle(2)) {
						controller2Input = DetectInput(controller2Input, 2);
					} else {
						controllerPlayer4 = 2;
						PanelPlayer4NoSelected.SetActive(false);
						PanelPlayer4.SetActive(true);
						Debug.Log("PLAYER 4 ACTIVADO CON MANDO "+controllerPlayer1);
					}
				}
				if(ControllerNotAssigned(3)) { // Si el mando 3 no está asignado a nadie
					controller3Input = InputManager.CalculateIdle(3, controller3Input);
					// En cuanto se reciba un input, se asigna el número del mando al Player
					if(controller3Input == InputManager.GetIdle(3)) {
						controller3Input = DetectInput(controller3Input, 3);
					} else {
						controllerPlayer4 = 3;
						PanelPlayer4NoSelected.SetActive(false);
						PanelPlayer4.SetActive(true);
						Debug.Log("PLAYER 4 ACTIVADO CON MANDO "+controllerPlayer1);
					}
				}
				if(ControllerNotAssigned(4)) { // Si el mando 4 no está asignado a nadie
					controller4Input = InputManager.CalculateIdle(4, controller4Input);
					// En cuanto se reciba un input, se asigna el número del mando al Player
					if(controller4Input == InputManager.GetIdle(4)) {
						controller4Input = DetectInput(controller4Input, 4);
					} else {
						controllerPlayer4 = 4;
						PanelPlayer4NoSelected.SetActive(false);
						PanelPlayer4.SetActive(true);
						Debug.Log("PLAYER 4 ACTIVADO CON MANDO "+controllerPlayer1);
					}
				}
				if(ControllerNotAssigned(5)) { // Si el mando 5 no está asignado a nadie
					controller5Input = InputManager.CalculateIdle(5, controller5Input);
					// En cuanto se reciba un input, se asigna el número del mando al Player
					if(controller5Input == InputManager.GetIdle(5)) {
						controller5Input = DetectInput(controller5Input, 5);
					} else {
						controllerPlayer4 = 5;
						PanelPlayer4NoSelected.SetActive(false);
						PanelPlayer4.SetActive(true);
						Debug.Log("PLAYER 4 ACTIVADO CON MANDO "+controllerPlayer1);
					}
				}
			}
		}

		// ===================
		// CONTROLLER PLAYER 5
		// ===================
		
		// Si ya he asignado un mando al Player 4
		if(controllerPlayer4 != -1) {
			// Si ya se ha asignado un mando al Player 5
			if(controllerPlayer5 != -1) {
				// Si aún no ha elegido Player, puede mover el cursor
				if(!player5Finished) {
					player5Input = InputManager.CalculateIdle(controllerPlayer5, player5Input);

					if(player5Input != InputManager.GetIdle(controllerPlayer5))
						player5Input = MoveCursor(player5Input, controllerPlayer5, 5, PanelPlayer5);

					// SUBMIT
					if(InputManager.Submit(controllerPlayer5)) {
						// Si el Player seleccionado no ha sido seleccionado por otro, lo selecciona
						if(!listPlayersAvailable[player5SelectedPlayer].selected) {
							Debug.Log("¡PLAYER 5 HA SELECCIONADO NOMBRE!");
							player5Finished = true;
							listPlayersAvailable[player5SelectedPlayer].selected = true;
							listPlayersAvailable[player5SelectedPlayer].controller = controllerPlayer5;
							PanelPlayer5.transform.Find("PanelFinished").gameObject.SetActive(true);
						} else {
							// TODO SONIDO NO SELECCIONABLE
							Debug.Log("¡PLAYER 5 NO PUEDE ELEGIR ESE NOMBRE!");
						}
					}
				}
				// CANCEL
				if(InputManager.Cancel(controllerPlayer5)) {
					// Si el Player ya había acabado, desactiva FINISHED
					if(player5Finished) {
						Debug.Log("¡PLAYER 5 HA CANCELADO EL NOMBRE!");
						player5Finished = false;
						listPlayersAvailable[player5SelectedPlayer].selected = false;
						listPlayersAvailable[player5SelectedPlayer].controller = -1;
						PanelPlayer5.transform.Find("PanelFinished").gameObject.SetActive(false);
					// Si aún no se había elegido Player, desasigna el mando
					} else {
						Debug.Log("¡PLAYER 5 SE HA IDO!");
						controllerPlayer5 = -1;
						PanelPlayer5NoSelected.SetActive(true);
						PanelPlayer5.SetActive(false);
					}
				}
			// Si no se ha asignado mando al Player 5 y los Player anteriores ya están asignados
			} else if(controllerPlayer1 != -1 && controllerPlayer2 != -1 && controllerPlayer3 != -1 && controllerPlayer4 != -1) {
				//Debug.Log("Esperando Input para Player 5");
				if(ControllerNotAssigned(1)) { // Si el mando 1 no está asignado a nadie
					controller1Input = InputManager.CalculateIdle(1, controller1Input);
					// En cuanto se reciba un input, se asigna el número del mando al Player
					if(controller1Input == InputManager.GetIdle(1)) {
						controller1Input = DetectInput(controller1Input, 1);
					} else {
						controllerPlayer5 = 1;
						PanelPlayer5NoSelected.SetActive(false);
						PanelPlayer5.SetActive(true);
						Debug.Log("PLAYER 5 ACTIVADO CON MANDO "+controllerPlayer1);
					}
				}
				if(ControllerNotAssigned(2)) { // Si el mando 2 no está asignado a nadie
					controller2Input = InputManager.CalculateIdle(2, controller2Input);
					// En cuanto se reciba un input, se asigna el número del mando al Player
					if(controller2Input == InputManager.GetIdle(2)) {
						controller2Input = DetectInput(controller2Input, 2);
					} else {
						controllerPlayer5 = 2;
						PanelPlayer5NoSelected.SetActive(false);
						PanelPlayer5.SetActive(true);
						Debug.Log("PLAYER 5 ACTIVADO CON MANDO "+controllerPlayer1);
					}
				}
				if(ControllerNotAssigned(3)) { // Si el mando 3 no está asignado a nadie
					controller3Input = InputManager.CalculateIdle(3, controller3Input);
					// En cuanto se reciba un input, se asigna el número del mando al Player
					if(controller3Input == InputManager.GetIdle(3)) {
						controller3Input = DetectInput(controller3Input, 3);
					} else {
						controllerPlayer5 = 3;
						PanelPlayer5NoSelected.SetActive(false);
						PanelPlayer5.SetActive(true);
						Debug.Log("PLAYER 5 ACTIVADO CON MANDO "+controllerPlayer1);
					}
				}
				if(ControllerNotAssigned(4)) { // Si el mando 4 no está asignado a nadie
					controller4Input = InputManager.CalculateIdle(4, controller4Input);
					// En cuanto se reciba un input, se asigna el número del mando al Player
					if(controller4Input == InputManager.GetIdle(4)) {
						controller4Input = DetectInput(controller4Input, 4);
					} else {
						controllerPlayer5 = 4;
						PanelPlayer5NoSelected.SetActive(false);
						PanelPlayer5.SetActive(true);
						Debug.Log("PLAYER 5 ACTIVADO CON MANDO "+controllerPlayer1);
					}
				}
				if(ControllerNotAssigned(5)) { // Si el mando 5 no está asignado a nadie
					controller5Input = InputManager.CalculateIdle(5, controller5Input);
					// En cuanto se reciba un input, se asigna el número del mando al Player
					if(controller5Input == InputManager.GetIdle(5)) {
						controller5Input = DetectInput(controller5Input, 5);
					} else {
						controllerPlayer5 = 5;
						PanelPlayer5NoSelected.SetActive(false);
						PanelPlayer5.SetActive(true);
						Debug.Log("PLAYER 5 ACTIVADO CON MANDO "+controllerPlayer1);
					}
				}
			}
		}
	}

	bool ControllerNotAssigned(int controllerNumber) {
		return controllerPlayer1 != controllerNumber 
			&& controllerPlayer2 != controllerNumber 
			&& controllerPlayer3 != controllerNumber 
			&& controllerPlayer4 != controllerNumber 
			&& controllerPlayer5 != controllerNumber;
	}

	public InputType MoveCursor(InputType input, int playerController, int player, GameObject panelPlayer) {
		if(input == InputManager.GetLeft(playerController)) { // Izquierda
			// Debug.Log("ACCIÓN IZQUIERDA");
			string playerText = "";
			switch(player) {
				case 1:
					player1SelectedPlayer--;
					if(player1SelectedPlayer < 0) player1SelectedPlayer = listPlayersAvailable.Count-1;
					playerText = listPlayersAvailable[player1SelectedPlayer].nickname;
					break;
				case 2:
					player2SelectedPlayer--;
					if(player2SelectedPlayer < 0) player2SelectedPlayer = listPlayersAvailable.Count-1;
					playerText = listPlayersAvailable[player2SelectedPlayer].nickname;
					break;
				case 3:
					player3SelectedPlayer--;
					if(player3SelectedPlayer < 0) player3SelectedPlayer = listPlayersAvailable.Count-1;
					playerText = listPlayersAvailable[player3SelectedPlayer].nickname;
					break;
				case 4:
					player4SelectedPlayer--;
					if(player4SelectedPlayer < 0) player4SelectedPlayer = listPlayersAvailable.Count-1;
					playerText = listPlayersAvailable[player4SelectedPlayer].nickname;
					break;
				case 5:
					player5SelectedPlayer--;
					if(player5SelectedPlayer < 0) player5SelectedPlayer = listPlayersAvailable.Count-1;
					playerText = listPlayersAvailable[player5SelectedPlayer].nickname;
					break;
			}
			// TODO ANIM LEFT ARROW
			panelPlayer.transform.Find("PlayerName").GetComponent<Text>().text = playerText; // UI
			return InputManager.GetDone(playerController);
		} else if(input == InputManager.GetRight(playerController)) { // Derecha
			// Debug.Log("ACCIÓN DERECHA");
			string playerText = "";
			switch(player) {
				case 1:
					player1SelectedPlayer++;
					if(player1SelectedPlayer == listPlayersAvailable.Count) player1SelectedPlayer = 0;
					playerText = listPlayersAvailable[player1SelectedPlayer].nickname;
					break;
				case 2:
					player2SelectedPlayer++;
					if(player2SelectedPlayer == listPlayersAvailable.Count) player2SelectedPlayer = 0;
					playerText = listPlayersAvailable[player2SelectedPlayer].nickname;
					break;
				case 3:
					player3SelectedPlayer++;
					if(player3SelectedPlayer == listPlayersAvailable.Count) player3SelectedPlayer = 0;
					playerText = listPlayersAvailable[player3SelectedPlayer].nickname;
					break;
				case 4:
					player4SelectedPlayer++;
					if(player4SelectedPlayer == listPlayersAvailable.Count) player4SelectedPlayer = 0;
					playerText = listPlayersAvailable[player4SelectedPlayer].nickname;
					break;
				case 5:
					player5SelectedPlayer++;
					if(player5SelectedPlayer == listPlayersAvailable.Count) player5SelectedPlayer = 0;
					playerText = listPlayersAvailable[player5SelectedPlayer].nickname;
					break;
			}
			// TODO ANIM RIGHT ARROW
			panelPlayer.transform.Find("PlayerName").GetComponent<Text>().text = playerText; // UI
			return InputManager.GetDone(playerController);
		}
		return input;
	}

	public InputType DetectInput(InputType input, int playerController) {
		// Debug.Log("Detectando input para el mando " + playerController);
		if(input == InputManager.GetLeft(playerController)) { // Izquierda
			// Debug.Log("DETECTO IZQUIERDA!");
			return InputManager.GetDone(playerController);
		} else if(input == InputManager.GetRight(playerController)) { // Derecha
			// Debug.Log("DETECTO DERECHA!");
			return InputManager.GetDone(playerController);
		} else if(input == InputManager.GetUp(playerController)) { // Arriba
			// Debug.Log("DETECTO ARRIBA!");
			return InputManager.GetDone(playerController);
		} else if(input == InputManager.GetDown(playerController)) { // Abajo
			// Debug.Log("DETECTO ABAJO!");
			return InputManager.GetDone(playerController);
		}
		return InputManager.GetIdle(playerController);
	}

}