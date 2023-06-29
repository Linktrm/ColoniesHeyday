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

		player1SelectedPlayer = 1;
		player2SelectedPlayer = 1;
		player3SelectedPlayer = 1;
		player4SelectedPlayer = 1;
		player5SelectedPlayer = 1;

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

				if(player1Input == InputManager.GetIdle(controllerPlayer1)) {
					player1Input = MoveCursor(InputManager.Horizontal(controllerPlayer1, player1Input), InputManager.Vertical(controllerPlayer1, player1Input), controllerPlayer1, player1SelectedPlayer, PanelPlayer1);
				}

				// SUBMIT
				if(InputManager.Submit(controllerPlayer1)) {
					// Si el Player seleccionado no ha sido seleccionado por otro, lo selecciona
					if(!listPlayersAvailable[player1SelectedPlayer].selected) {
						player1Finished = true;
						listPlayersAvailable[player1SelectedPlayer].selected = true;
						listPlayersAvailable[player1SelectedPlayer].controller = controllerPlayer1;
						PanelPlayer1.transform.Find("PanelFinished").gameObject.SetActive(true);
					} else {
						// TODO SONIDO NO SELECCIONABLE
					}
				}
			}
			// CANCEL
			if(InputManager.Cancel(controllerPlayer1)) {
				// Si el Player ya había acabado, desactiva FINISHED
				if(player1Finished) {
					player1Finished = false;
					listPlayersAvailable[player1SelectedPlayer].selected = false;
					listPlayersAvailable[player1SelectedPlayer].controller = -1;
					PanelPlayer1.transform.Find("PanelFinished").gameObject.SetActive(false);
				// Si aún no se había elegido Player, desasigna el mando
				} else {
					controllerPlayer1 = -1;
					PanelPlayer1NoSelected.SetActive(true);
					PanelPlayer1.SetActive(false);
				}
			}
		// Si no se ha asignado mando al Player 1
		} else {
			//Debug.Log("Esperando Input para Player 1");
			if(ControllerNotAssigned(1)) { // Si el mando 1 no está asignado a nadie
				controller1Input = InputManager.Submit(1) ? InputManager.GetDone(1) : InputManager.GetIdle(1);
				controller1Input = InputManager.Horizontal(1, controller1Input);
				controller1Input = InputManager.Vertical(1, controller1Input);
				// En cuanto se reciba un input, se asigna el número del mando al Player
				if(controller1Input != InputManager.GetIdle(1)) {
					controllerPlayer1 = 1;
					PanelPlayer1NoSelected.SetActive(false);
					PanelPlayer1.SetActive(true);
					Debug.Log("Asignamos el mando "+controllerPlayer1+" al Player 1");
				}
			}
			if(ControllerNotAssigned(2)) { // Si el mando 2 no está asignado a nadie
				controller2Input = InputManager.Submit(2) ? InputManager.GetDone(2) : InputManager.GetIdle(2);
				controller2Input = InputManager.Horizontal(2, controller2Input);
				controller2Input = InputManager.Vertical(2, controller2Input);
				// En cuanto se reciba un input, se asigna el número del mando al Player
				if(controller2Input != InputManager.GetIdle(2)) {
					controllerPlayer1 = 2;
					PanelPlayer1NoSelected.SetActive(false);
					PanelPlayer1.SetActive(true);
					Debug.Log("Asignamos el mando "+controllerPlayer1+" al Player 1");
				}
			}
			if(ControllerNotAssigned(3)) { // Si el mando 3 no está asignado a nadie
				controller3Input = InputManager.Submit(3) ? InputManager.GetDone(3) : InputManager.GetIdle(3);
				controller3Input = InputManager.Horizontal(3, controller3Input);
				controller3Input = InputManager.Vertical(3, controller3Input);
				// En cuanto se reciba un input, se asigna el número del mando al Player
				if(controller3Input != InputManager.GetIdle(3)) {
					controllerPlayer1 = 3;
					PanelPlayer1NoSelected.SetActive(false);
					PanelPlayer1.SetActive(true);
					Debug.Log("Asignamos el mando "+controllerPlayer1+" al Player 1");
				}
			}
			if(ControllerNotAssigned(4)) { // Si el mando 4 no está asignado a nadie
				controller4Input = InputManager.Submit(4) ? InputManager.GetDone(4) : InputManager.GetIdle(4);
				controller4Input = InputManager.Horizontal(4, controller4Input);
				controller4Input = InputManager.Vertical(4, controller4Input);
				// En cuanto se reciba un input, se asigna el número del mando al Player
				if(controller4Input != InputManager.GetIdle(4)) {
					controllerPlayer1 = 4;
					PanelPlayer1NoSelected.SetActive(false);
					PanelPlayer1.SetActive(true);
					Debug.Log("Asignamos el mando "+controllerPlayer1+" al Player 1");
				}
			}
			if(ControllerNotAssigned(5)) { // Si el mando 5 no está asignado a nadie
				controller5Input = InputManager.Submit(5) ? InputManager.GetDone(5) : InputManager.GetIdle(5);
				controller5Input = InputManager.Horizontal(5, controller5Input);
				controller5Input = InputManager.Vertical(5, controller5Input);
				// En cuanto se reciba un input, se asigna el número del mando al Player
				if(controller5Input != InputManager.GetIdle(5)) {
					controllerPlayer1 = 5;
					PanelPlayer1NoSelected.SetActive(false);
					PanelPlayer1.SetActive(true);
					Debug.Log("Asignamos el mando "+controllerPlayer1+" al Player 1");
				}
			}
		}

		// ===================
		// CONTROLLER PLAYER 2
		// ===================
		
		// Si ya se ha asignado un mando al Player 2
		if(controllerPlayer2 != -1) {
			// Si aún no ha elegido Player, puede mover el cursor
			if(!player2Finished) {
				player2Input = InputManager.CalculateIdle(controllerPlayer2, player2Input);

				if(player2Input == InputManager.GetIdle(controllerPlayer2)) {
					player2Input = MoveCursor(InputManager.Horizontal(controllerPlayer2, player2Input), InputManager.Vertical(controllerPlayer2, player2Input), controllerPlayer2, player2SelectedPlayer, PanelPlayer2);
				}

				// SUBMIT
				if(InputManager.Submit(controllerPlayer2)) {
					// Si el Player seleccionado no ha sido seleccionado por otro, lo selecciona
					if(!listPlayersAvailable[player2SelectedPlayer].selected) {
						player2Finished = true;
						listPlayersAvailable[player2SelectedPlayer].selected = true;
						listPlayersAvailable[player2SelectedPlayer].controller = controllerPlayer2;
						PanelPlayer2.transform.Find("PanelFinished").gameObject.SetActive(true);
					} else {
						// TODO SONIDO NO SELECCIONABLE
					}
				}
			}
			// CANCEL
			if(InputManager.Cancel(controllerPlayer2)) {
				// Si el Player ya había acabado, desactiva FINISHED
				if(player2Finished) {
					player2Finished = false;
					listPlayersAvailable[player2SelectedPlayer].selected = false;
					listPlayersAvailable[player2SelectedPlayer].controller = -1;
					PanelPlayer2.transform.Find("PanelFinished").gameObject.SetActive(false);
				// Si aún no se había elegido Player, desasigna el mando
				} else {
					controllerPlayer2 = -1;
					PanelPlayer2NoSelected.SetActive(true);
					PanelPlayer2.SetActive(false);
				}
			}
		// Si no se ha asignado mando al Player 2 y los Player anteriores ya están asignados
		} else if(controllerPlayer1 != -1) {
			//Debug.Log("Esperando Input para Player 2");
			if(ControllerNotAssigned(1)) { // Si el mando 1 no está asignado a nadie
				controller1Input = InputManager.Submit(1) ? InputManager.GetDone(1) : InputManager.GetIdle(1);
				controller1Input = InputManager.Horizontal(1, controller1Input);
				controller1Input = InputManager.Vertical(1, controller1Input);
				// En cuanto se reciba un input, se asigna el número del mando al Player
				if(controller1Input != InputManager.GetIdle(1)) {
					controllerPlayer2 = 1;
					PanelPlayer2NoSelected.SetActive(false);
					PanelPlayer2.SetActive(true);
					Debug.Log("Asignamos el mando "+controllerPlayer2+" al Player 2");
				}
			}
			if(ControllerNotAssigned(2)) { // Si el mando 2 no está asignado a nadie
				controller2Input = InputManager.Submit(2) ? InputManager.GetDone(2) : InputManager.GetIdle(2);
				controller2Input = InputManager.Horizontal(2, controller2Input);
				controller2Input = InputManager.Vertical(2, controller2Input);
				// En cuanto se reciba un input, se asigna el número del mando al Player
				if(controller2Input != InputManager.GetIdle(2)) {
					controllerPlayer2 = 2;
					PanelPlayer2NoSelected.SetActive(false);
					PanelPlayer2.SetActive(true);
					Debug.Log("Asignamos el mando "+controllerPlayer2+" al Player 2");
				}
			}
			if(ControllerNotAssigned(3)) { // Si el mando 3 no está asignado a nadie
				controller3Input = InputManager.Submit(3) ? InputManager.GetDone(3) : InputManager.GetIdle(3);
				controller3Input = InputManager.Horizontal(3, controller3Input);
				controller3Input = InputManager.Vertical(3, controller3Input);
				// En cuanto se reciba un input, se asigna el número del mando al Player
				if(controller3Input != InputManager.GetIdle(3)) {
					controllerPlayer2 = 3;
					PanelPlayer2NoSelected.SetActive(false);
					PanelPlayer2.SetActive(true);
					Debug.Log("Asignamos el mando "+controllerPlayer2+" al Player 2");
				}
			}
			if(ControllerNotAssigned(4)) { // Si el mando 4 no está asignado a nadie
				controller4Input = InputManager.Submit(4) ? InputManager.GetDone(4) : InputManager.GetIdle(4);
				controller4Input = InputManager.Horizontal(4, controller4Input);
				controller4Input = InputManager.Vertical(4, controller4Input);
				// En cuanto se reciba un input, se asigna el número del mando al Player
				if(controller4Input != InputManager.GetIdle(4)) {
					controllerPlayer2 = 4;
					PanelPlayer2NoSelected.SetActive(false);
					PanelPlayer2.SetActive(true);
					Debug.Log("Asignamos el mando "+controllerPlayer2+" al Player 2");
				}
			}
			if(ControllerNotAssigned(5)) { // Si el mando 5 no está asignado a nadie
				controller5Input = InputManager.Submit(5) ? InputManager.GetDone(5) : InputManager.GetIdle(5);
				controller5Input = InputManager.Horizontal(5, controller5Input);
				controller5Input = InputManager.Vertical(5, controller5Input);
				// En cuanto se reciba un input, se asigna el número del mando al Player
				if(controller5Input != InputManager.GetIdle(5)) {
					controllerPlayer2 = 5;
					PanelPlayer2NoSelected.SetActive(false);
					PanelPlayer2.SetActive(true);
					Debug.Log("Asignamos el mando "+controllerPlayer2+" al Player 2");
				}
			}
		}

		// ===================
		// CONTROLLER PLAYER 3
		// ===================
		
		// Si ya se ha asignado un mando al Player 3
		if(controllerPlayer3 != -1) {
			// Si aún no ha elegido Player, puede mover el cursor
			if(!player3Finished) {
				player3Input = InputManager.CalculateIdle(controllerPlayer3, player3Input);

				if(player3Input == InputManager.GetIdle(controllerPlayer3)) {
					player3Input = MoveCursor(InputManager.Horizontal(controllerPlayer3, player3Input), InputManager.Vertical(controllerPlayer3, player3Input), controllerPlayer3, player3SelectedPlayer, PanelPlayer3);
				}

				// SUBMIT
				if(InputManager.Submit(controllerPlayer3)) {
					// Si el Player seleccionado no ha sido seleccionado por otro, lo selecciona
					if(!listPlayersAvailable[player3SelectedPlayer].selected) {
						player3Finished = true;
						listPlayersAvailable[player3SelectedPlayer].selected = true;
						listPlayersAvailable[player3SelectedPlayer].controller = controllerPlayer3;
						PanelPlayer3.transform.Find("PanelFinished").gameObject.SetActive(true);
					} else {
						// TODO SONIDO NO SELECCIONABLE
					}
				}
			}
			// CANCEL
			if(InputManager.Cancel(controllerPlayer3)) {
				// Si el Player ya había acabado, desactiva FINISHED
				if(player3Finished) {
					player3Finished = false;
					listPlayersAvailable[player3SelectedPlayer].selected = false;
					listPlayersAvailable[player3SelectedPlayer].controller = -1;
					PanelPlayer3.transform.Find("PanelFinished").gameObject.SetActive(false);
				// Si aún no se había elegido Player, desasigna el mando
				} else {
					controllerPlayer3 = -1;
					PanelPlayer3NoSelected.SetActive(true);
					PanelPlayer3.SetActive(false);
				}
			}
		// Si no se ha asignado mando al Player 3 y los Player anteriores ya están asignados
		} else if(controllerPlayer1 != -1 && controllerPlayer2 != -1) {
			//Debug.Log("Esperando Input para Player 3");
			if(ControllerNotAssigned(1)) { // Si el mando 1 no está asignado a nadie
				controller1Input = InputManager.Submit(1) ? InputManager.GetDone(1) : InputManager.GetIdle(1);
				controller1Input = InputManager.Horizontal(1, controller1Input);
				controller1Input = InputManager.Vertical(1, controller1Input);
				// En cuanto se reciba un input, se asigna el número del mando al Player
				if(controller1Input != InputManager.GetIdle(1)) {
					controllerPlayer3 = 1;
					PanelPlayer3NoSelected.SetActive(false);
					PanelPlayer3.SetActive(true);
					Debug.Log("Asignamos el mando "+controllerPlayer3+" al Player 3");
				}
			}
			if(ControllerNotAssigned(2)) { // Si el mando 2 no está asignado a nadie
				controller2Input = InputManager.Submit(2) ? InputManager.GetDone(2) : InputManager.GetIdle(2);
				controller2Input = InputManager.Horizontal(2, controller2Input);
				controller2Input = InputManager.Vertical(2, controller2Input);
				// En cuanto se reciba un input, se asigna el número del mando al Player
				if(controller2Input != InputManager.GetIdle(2)) {
					controllerPlayer3 = 2;
					PanelPlayer3NoSelected.SetActive(false);
					PanelPlayer3.SetActive(true);
					Debug.Log("Asignamos el mando "+controllerPlayer3+" al Player 3");
				}
			}
			if(ControllerNotAssigned(3)) { // Si el mando 3 no está asignado a nadie
				controller3Input = InputManager.Submit(3) ? InputManager.GetDone(3) : InputManager.GetIdle(3);
				controller3Input = InputManager.Horizontal(3, controller3Input);
				controller3Input = InputManager.Vertical(3, controller3Input);
				// En cuanto se reciba un input, se asigna el número del mando al Player
				if(controller3Input != InputManager.GetIdle(3)) {
					controllerPlayer3 = 3;
					PanelPlayer3NoSelected.SetActive(false);
					PanelPlayer3.SetActive(true);
					Debug.Log("Asignamos el mando "+controllerPlayer3+" al Player 3");
				}
			}
			if(ControllerNotAssigned(4)) { // Si el mando 4 no está asignado a nadie
				controller4Input = InputManager.Submit(4) ? InputManager.GetDone(4) : InputManager.GetIdle(4);
				controller4Input = InputManager.Horizontal(4, controller4Input);
				controller4Input = InputManager.Vertical(4, controller4Input);
				// En cuanto se reciba un input, se asigna el número del mando al Player
				if(controller4Input != InputManager.GetIdle(4)) {
					controllerPlayer3 = 4;
					PanelPlayer3NoSelected.SetActive(false);
					PanelPlayer3.SetActive(true);
					Debug.Log("Asignamos el mando "+controllerPlayer3+" al Player 3");
				}
			}
			if(ControllerNotAssigned(5)) { // Si el mando 5 no está asignado a nadie
				controller5Input = InputManager.Submit(5) ? InputManager.GetDone(5) : InputManager.GetIdle(5);
				controller5Input = InputManager.Horizontal(5, controller5Input);
				controller5Input = InputManager.Vertical(5, controller5Input);
				// En cuanto se reciba un input, se asigna el número del mando al Player
				if(controller5Input != InputManager.GetIdle(5)) {
					controllerPlayer3 = 5;
					PanelPlayer3NoSelected.SetActive(false);
					PanelPlayer3.SetActive(true);
					Debug.Log("Asignamos el mando "+controllerPlayer3+" al Player 3");
				}
			}
		}

		// ===================
		// CONTROLLER PLAYER 4
		// ===================
		
		// Si ya se ha asignado un mando al Player 4
		if(controllerPlayer4 != -1) {
			// Si aún no ha elegido Player, puede mover el cursor
			if(!player4Finished) {
				player4Input = InputManager.CalculateIdle(controllerPlayer4, player4Input);

				if(player4Input == InputManager.GetIdle(controllerPlayer4)) {
					player4Input = MoveCursor(InputManager.Horizontal(controllerPlayer4, player4Input), InputManager.Vertical(controllerPlayer4, player4Input), controllerPlayer4, player4SelectedPlayer, PanelPlayer4);
				}

				// SUBMIT
				if(InputManager.Submit(controllerPlayer4)) {
					// Si el Player seleccionado no ha sido seleccionado por otro, lo selecciona
					if(!listPlayersAvailable[player4SelectedPlayer].selected) {
						player4Finished = true;
						listPlayersAvailable[player4SelectedPlayer].selected = true;
						listPlayersAvailable[player4SelectedPlayer].controller = controllerPlayer4;
						PanelPlayer4.transform.Find("PanelFinished").gameObject.SetActive(true);
					} else {
						// TODO SONIDO NO SELECCIONABLE
					}
				}
			}
			// CANCEL
			if(InputManager.Cancel(controllerPlayer4)) {
				// Si el Player ya había acabado, desactiva FINISHED
				if(player4Finished) {
					player4Finished = false;
					listPlayersAvailable[player4SelectedPlayer].selected = false;
					listPlayersAvailable[player4SelectedPlayer].controller = -1;
					PanelPlayer4.transform.Find("PanelFinished").gameObject.SetActive(false);
				// Si aún no se había elegido Player, desasigna el mando
				} else {
					controllerPlayer4 = -1;
					PanelPlayer4NoSelected.SetActive(true);
					PanelPlayer4.SetActive(false);
				}
			}
		// Si no se ha asignado mando al Player 4 y los Player anteriores ya están asignados
		} else if(controllerPlayer1 != -1 && controllerPlayer2 != -1 && controllerPlayer3 != -1) {
			//Debug.Log("Esperando Input para Player 4");
			if(ControllerNotAssigned(1)) { // Si el mando 1 no está asignado a nadie
				controller1Input = InputManager.Submit(1) ? InputManager.GetDone(1) : InputManager.GetIdle(1);
				controller1Input = InputManager.Horizontal(1, controller1Input);
				controller1Input = InputManager.Vertical(1, controller1Input);
				// En cuanto se reciba un input, se asigna el número del mando al Player
				if(controller1Input != InputManager.GetIdle(1)) {
					controllerPlayer4 = 1;
					PanelPlayer4NoSelected.SetActive(false);
					PanelPlayer4.SetActive(true);
					Debug.Log("Asignamos el mando "+controllerPlayer4+" al Player 4");
				}
			}
			if(ControllerNotAssigned(2)) { // Si el mando 2 no está asignado a nadie
				controller2Input = InputManager.Submit(2) ? InputManager.GetDone(2) : InputManager.GetIdle(2);
				controller2Input = InputManager.Horizontal(2, controller2Input);
				controller2Input = InputManager.Vertical(2, controller2Input);
				// En cuanto se reciba un input, se asigna el número del mando al Player
				if(controller2Input != InputManager.GetIdle(2)) {
					controllerPlayer4 = 2;
					PanelPlayer4NoSelected.SetActive(false);
					PanelPlayer4.SetActive(true);
					Debug.Log("Asignamos el mando "+controllerPlayer4+" al Player 4");
				}
			}
			if(ControllerNotAssigned(3)) { // Si el mando 3 no está asignado a nadie
				controller3Input = InputManager.Submit(3) ? InputManager.GetDone(3) : InputManager.GetIdle(3);
				controller3Input = InputManager.Horizontal(3, controller3Input);
				controller3Input = InputManager.Vertical(3, controller3Input);
				// En cuanto se reciba un input, se asigna el número del mando al Player
				if(controller3Input != InputManager.GetIdle(3)) {
					controllerPlayer4 = 3;
					PanelPlayer4NoSelected.SetActive(false);
					PanelPlayer4.SetActive(true);
					Debug.Log("Asignamos el mando "+controllerPlayer4+" al Player 4");
				}
			}
			if(ControllerNotAssigned(4)) { // Si el mando 4 no está asignado a nadie
				controller4Input = InputManager.Submit(4) ? InputManager.GetDone(4) : InputManager.GetIdle(4);
				controller4Input = InputManager.Horizontal(4, controller4Input);
				controller4Input = InputManager.Vertical(4, controller4Input);
				// En cuanto se reciba un input, se asigna el número del mando al Player
				if(controller4Input != InputManager.GetIdle(4)) {
					controllerPlayer4 = 4;
					PanelPlayer4NoSelected.SetActive(false);
					PanelPlayer4.SetActive(true);
					Debug.Log("Asignamos el mando "+controllerPlayer4+" al Player 4");
				}
			}
			if(ControllerNotAssigned(5)) { // Si el mando 5 no está asignado a nadie
				controller5Input = InputManager.Submit(5) ? InputManager.GetDone(5) : InputManager.GetIdle(5);
				controller5Input = InputManager.Horizontal(5, controller5Input);
				controller5Input = InputManager.Vertical(5, controller5Input);
				// En cuanto se reciba un input, se asigna el número del mando al Player
				if(controller5Input != InputManager.GetIdle(5)) {
					controllerPlayer4 = 5;
					PanelPlayer4NoSelected.SetActive(false);
					PanelPlayer4.SetActive(true);
					Debug.Log("Asignamos el mando "+controllerPlayer4+" al Player 4");
				}
			}
		}

		// ===================
		// CONTROLLER PLAYER 5
		// ===================
		
		// Si ya se ha asignado un mando al Player 5
		if(controllerPlayer5 != -1) {
			// Si aún no ha elegido Player, puede mover el cursor
			if(!player5Finished) {
				player5Input = InputManager.CalculateIdle(controllerPlayer5, player5Input);

				if(player5Input == InputManager.GetIdle(controllerPlayer5)) {
					player5Input = MoveCursor(InputManager.Horizontal(controllerPlayer5, player5Input), InputManager.Vertical(controllerPlayer5, player5Input), controllerPlayer5, player5SelectedPlayer, PanelPlayer5);
				}

				// SUBMIT
				if(InputManager.Submit(controllerPlayer5)) {
					// Si el Player seleccionado no ha sido seleccionado por otro, lo selecciona
					if(!listPlayersAvailable[player5SelectedPlayer].selected) {
						player5Finished = true;
						listPlayersAvailable[player5SelectedPlayer].selected = true;
						listPlayersAvailable[player5SelectedPlayer].controller = controllerPlayer5;
						PanelPlayer5.transform.Find("PanelFinished").gameObject.SetActive(true);
					} else {
						// TODO SONIDO NO SELECCIONABLE
					}
				}
			}
			// CANCEL
			if(InputManager.Cancel(controllerPlayer5)) {
				// Si el Player ya había acabado, desactiva FINISHED
				if(player5Finished) {
					player5Finished = false;
					listPlayersAvailable[player5SelectedPlayer].selected = false;
					listPlayersAvailable[player5SelectedPlayer].controller = -1;
					PanelPlayer5.transform.Find("PanelFinished").gameObject.SetActive(false);
				// Si aún no se había elegido Player, desasigna el mando
				} else {
					controllerPlayer5 = -1;
					PanelPlayer5NoSelected.SetActive(true);
					PanelPlayer5.SetActive(false);
				}
			}
		// Si no se ha asignado mando al Player 5 y los Player anteriores ya están asignados
		} else if(controllerPlayer1 != -1 && controllerPlayer2 != -1 && controllerPlayer3 != -1 && controllerPlayer4 != -1) {
			//Debug.Log("Esperando Input para Player 5");
			if(ControllerNotAssigned(1)) { // Si el mando 1 no está asignado a nadie
				controller1Input = InputManager.Submit(1) ? InputManager.GetDone(1) : InputManager.GetIdle(1);
				controller1Input = InputManager.Horizontal(1, controller1Input);
				controller1Input = InputManager.Vertical(1, controller1Input);
				// En cuanto se reciba un input, se asigna el número del mando al Player
				if(controller1Input != InputManager.GetIdle(1)) {
					controllerPlayer5 = 1;
					PanelPlayer5NoSelected.SetActive(false);
					PanelPlayer5.SetActive(true);
					Debug.Log("Asignamos el mando "+controllerPlayer5+" al Player 5");
				}
			}
			if(ControllerNotAssigned(2)) { // Si el mando 2 no está asignado a nadie
				controller2Input = InputManager.Submit(2) ? InputManager.GetDone(2) : InputManager.GetIdle(2);
				controller2Input = InputManager.Horizontal(2, controller2Input);
				controller2Input = InputManager.Vertical(2, controller2Input);
				// En cuanto se reciba un input, se asigna el número del mando al Player
				if(controller2Input != InputManager.GetIdle(2)) {
					controllerPlayer5 = 2;
					PanelPlayer5NoSelected.SetActive(false);
					PanelPlayer5.SetActive(true);
					Debug.Log("Asignamos el mando "+controllerPlayer5+" al Player 5");
				}
			}
			if(ControllerNotAssigned(3)) { // Si el mando 3 no está asignado a nadie
				controller3Input = InputManager.Submit(3) ? InputManager.GetDone(3) : InputManager.GetIdle(3);
				controller3Input = InputManager.Horizontal(3, controller3Input);
				controller3Input = InputManager.Vertical(3, controller3Input);
				// En cuanto se reciba un input, se asigna el número del mando al Player
				if(controller3Input != InputManager.GetIdle(3)) {
					controllerPlayer5 = 3;
					PanelPlayer5NoSelected.SetActive(false);
					PanelPlayer5.SetActive(true);
					Debug.Log("Asignamos el mando "+controllerPlayer5+" al Player 5");
				}
			}
			if(ControllerNotAssigned(4)) { // Si el mando 4 no está asignado a nadie
				controller4Input = InputManager.Submit(4) ? InputManager.GetDone(4) : InputManager.GetIdle(4);
				controller4Input = InputManager.Horizontal(4, controller4Input);
				controller4Input = InputManager.Vertical(4, controller4Input);
				// En cuanto se reciba un input, se asigna el número del mando al Player
				if(controller4Input != InputManager.GetIdle(4)) {
					controllerPlayer5 = 4;
					PanelPlayer5NoSelected.SetActive(false);
					PanelPlayer5.SetActive(true);
					Debug.Log("Asignamos el mando "+controllerPlayer5+" al Player 5");
				}
			}
			if(ControllerNotAssigned(5)) { // Si el mando 5 no está asignado a nadie
				controller5Input = InputManager.Submit(5) ? InputManager.GetDone(5) : InputManager.GetIdle(5);
				controller5Input = InputManager.Horizontal(5, controller5Input);
				controller5Input = InputManager.Vertical(5, controller5Input);
				// En cuanto se reciba un input, se asigna el número del mando al Player
				if(controller5Input != InputManager.GetIdle(5)) {
					controllerPlayer5 = 5;
					PanelPlayer5NoSelected.SetActive(false);
					PanelPlayer5.SetActive(true);
					Debug.Log("Asignamos el mando "+controllerPlayer5+" al Player 5");
				}
			}
		}
	}

	bool ControllerNotAssigned(int controllerNumber) {
		if(controllerPlayer1 != controllerNumber && controllerPlayer2 != controllerNumber && controllerPlayer3 != controllerNumber && controllerPlayer4 != controllerNumber && controllerPlayer5 != controllerNumber) {
			return true;
		}
		return false;
	}

	public InputType MoveCursor(InputType inputX, InputType inputY, int playerController, int playerSelected, GameObject panelPlayer) {
		if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
			while(!listPlayersAvailable[playerSelected].selected) {
				if(playerSelected-1 < 0) {
					playerSelected = listPlayersAvailable.Count-1;
				} else {
					playerSelected--;
				}
			}
			
			// TODO ANIM LEFT ARROW
			
			// UI
			panelPlayer.transform.Find("PlayerName").GetComponent<Text>().text = listPlayersAvailable[playerSelected].nickname;

			return InputManager.GetDone(playerController);
		} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
			while(!listPlayersAvailable[playerSelected].selected) {
				if(playerSelected+1 == listPlayersAvailable.Count) {
					playerSelected = 0;
				} else {
					playerSelected++;
				}
			}

			// TODO ANIM RIGHT ARROW
			
			// UI
			panelPlayer.transform.Find("PlayerName").gameObject.GetComponent<Text>().text = listPlayersAvailable[playerSelected].nickname;

			return InputManager.GetDone(playerController);
		}
		return InputManager.GetIdle(playerController);
	}
}