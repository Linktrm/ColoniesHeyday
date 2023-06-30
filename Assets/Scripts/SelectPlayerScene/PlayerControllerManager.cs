using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControllerManager : MonoBehaviour {
	
	public GameObject PanelNoSelected1;
	public GameObject PanelNoSelected2;
	public GameObject PanelNoSelected3;
	public GameObject PanelNoSelected4;
	public GameObject PanelNoSelected5;
	public GameObject Panel1;
	public GameObject Panel2;
	public GameObject Panel3;
	public GameObject Panel4;
	public GameObject Panel5;

	public List<Player> listPlayersAvailable { get; set; }

	PlayerController player1;
	PlayerController player2;
	PlayerController player3;
	PlayerController player4;
	PlayerController player5;

	InputType controller1Input;
	InputType controller2Input;
	InputType controller3Input;
	InputType controller4Input;
	InputType controller5Input;

	void Start () {
		listPlayersAvailable = new List<Player>(5);
		listPlayersAvailable.Add(new Player("Toni", 1));
		listPlayersAvailable.Add(new Player("Alva", 2));
		listPlayersAvailable.Add(new Player("Edu", 3));
		listPlayersAvailable.Add(new Player("Sergio", 4));
		listPlayersAvailable.Add(new Player("Óscar", 5));

		player1 = new PlayerController(1, InputType.PLAYER1_IDLE);
		player1.InitializePanels(PanelNoSelected1, Panel1);
		player2 = new PlayerController(2, InputType.PLAYER2_IDLE);
		player2.InitializePanels(PanelNoSelected2, Panel2);
		player3 = new PlayerController(3, InputType.PLAYER3_IDLE);
		player3.InitializePanels(PanelNoSelected3, Panel3);
		player4 = new PlayerController(4, InputType.PLAYER4_IDLE);
		player4.InitializePanels(PanelNoSelected4, Panel4);
		player5 = new PlayerController(5, InputType.PLAYER5_IDLE);
		player5.InitializePanels(PanelNoSelected5, Panel5);

		controller1Input = InputType.PLAYER1_IDLE;
		controller2Input = InputType.PLAYER2_IDLE;
		controller3Input = InputType.PLAYER3_IDLE;
		controller4Input = InputType.PLAYER4_IDLE;
		controller5Input = InputType.PLAYER5_IDLE;
	}
	
	void Update () {
		// Player 1
		PlayerManager(ref player1);
		// Si ya he asignado un mando al Player 1
		if(player1.controller != -1)
			PlayerManager(ref player2);
		// Si ya he asignado un mando al Player 2
		if(player2.controller != -1)
			PlayerManager(ref player3);
		// Si ya he asignado un mando al Player 3
		if(player3.controller != -1)
			PlayerManager(ref player4);
		// Si ya he asignado un mando al Player 4
		if(player4.controller != -1)
			PlayerManager(ref player5);
	}

	void PlayerManager(ref PlayerController player) {
		// Si ya se ha asignado un mando al Player
		if(player.controller != -1) {
			// Si aún no ha elegido Player, puede mover el cursor
			if(!player.finished) {
				player.input = InputManager.CalculateIdle(player.controller, player.input);

				if(player.input != InputManager.GetIdle(player.controller))
					player.input = MoveCursor(player.input, player.controller, ref player.selectedPlayer, player.Panel);

				// SUBMIT
				if(InputManager.Submit(player.controller)) {
					// Si el Player seleccionado no ha sido seleccionado por otro, lo selecciona
					if(!listPlayersAvailable[player.selectedPlayer].selected) {
						Debug.Log("¡PLAYER " + player.number + " HA SELECCIONADO NOMBRE!");
						player.finished = true;
						listPlayersAvailable[player.selectedPlayer].selected = true;
						listPlayersAvailable[player.selectedPlayer].controller = player1.controller;
						player.Panel.transform.Find("PanelFinished").gameObject.SetActive(true);
					} else {
						// TODO SONIDO NO SELECCIONABLE
						Debug.Log("¡PLAYER " + player.number + " NO PUEDE ELEGIR ESE NOMBRE!");
					}
				}
			}
			// CANCEL
			if(InputManager.Cancel(player.controller)) {
				// Si el Player ya había acabado, desactiva FINISHED
				if(player.finished) {
					Debug.Log("¡PLAYER " + player.number + " HA CANCELADO EL NOMBRE!");
					player.finished = false;
					listPlayersAvailable[player.selectedPlayer].selected = false;
					listPlayersAvailable[player.selectedPlayer].controller = -1;
					player.Panel.transform.Find("PanelFinished").gameObject.SetActive(false);
				// Si aún no se había elegido Player, desasigna el mando
				} else {
					Debug.Log("¡PLAYER " + player.number + " SE HA IDO!");
					player.controller = -1;
					player.PanelNoSelected.SetActive(true);
					player.Panel.SetActive(false);
				}
			}
		} else {
			// Si no se ha asignado mando al Player
			ControllerManager(1, controller1Input, ref player);
			ControllerManager(2, controller2Input, ref player);
			ControllerManager(3, controller3Input, ref player);
			ControllerManager(4, controller4Input, ref player);
			ControllerManager(5, controller5Input, ref player);
		}
	}

	void ControllerManager(int controllerNumber, InputType controllerInput, ref PlayerController player) {
		if(ControllerNotAssigned(controllerNumber)) { // Si el mando no está asignado a nadie
			controllerInput = InputManager.CalculateIdle(controllerNumber, controllerInput);
			// En cuanto se reciba un input, se asigna el número del mando al Player
			if(controllerInput == InputManager.GetIdle(controllerNumber))
				controllerInput = DetectInput(controllerInput, controllerNumber);
			else {
				player.controller = controllerNumber;
				player.PanelNoSelected.SetActive(false);
				player.Panel.SetActive(true);
				Debug.Log("PLAYER " + player.number + " ACTIVADO CON MANDO " + player.controller);
			}
		}
	}

	bool ControllerNotAssigned(int controllerNumber) {
		return player1.controller != controllerNumber 
			&& player2.controller != controllerNumber 
			&& player3.controller != controllerNumber 
			&& player4.controller != controllerNumber 
			&& player5.controller != controllerNumber;
	}

	public InputType MoveCursor(InputType input, int playerController, ref int selectedPlayer, GameObject panelPlayer) {
		if(input == InputManager.GetLeft(playerController)) { // Izquierda
			selectedPlayer--;
			if(selectedPlayer < 0) selectedPlayer = listPlayersAvailable.Count-1;
			// TODO ANIM LEFT ARROW
			panelPlayer.transform.Find("PlayerName").GetComponent<Text>().text = listPlayersAvailable[selectedPlayer].nickname; // UI
			return InputManager.GetDone(playerController);
		} else if(input == InputManager.GetRight(playerController)) { // Derecha
			selectedPlayer++;
			if(selectedPlayer == listPlayersAvailable.Count) selectedPlayer = 0;
			// TODO ANIM RIGHT ARROW
			panelPlayer.transform.Find("PlayerName").GetComponent<Text>().text = listPlayersAvailable[selectedPlayer].nickname; // UI
			return InputManager.GetDone(playerController);
		}
		return input;
	}

	public InputType DetectInput(InputType input, int playerController) {
		if(input == InputManager.GetLeft(playerController)) // Izquierda
			return InputManager.GetDone(playerController);
		else if(input == InputManager.GetRight(playerController)) // Derecha
			return InputManager.GetDone(playerController);
		else if(input == InputManager.GetUp(playerController)) // Arriba
			return InputManager.GetDone(playerController);
		else if(input == InputManager.GetDown(playerController)) // Abajo
			return InputManager.GetDone(playerController);
		return InputManager.GetIdle(playerController);
	}

}