using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController {

    public int number { get; set; }
	public bool finished { get; set; }
	public int controller { get; set; }
	public InputType input { get; set; }
	public int selectedPlayer;
	public GameObject PanelNoSelected;
	public GameObject Panel;
	
	public PlayerController(int playerNumber, InputType idle) {
        number = playerNumber;
		finished = false;
		selectedPlayer = 0;
		controller = -1;
		input = idle;
	}

    public void InitializePanels(GameObject newPanelNoSelected, GameObject newPanel) {
        PanelNoSelected = newPanelNoSelected;
		PanelNoSelected.SetActive(true);
		PanelNoSelected.GetComponentInChildren<Text>().text = "PLAYER " + number;
        Panel = newPanel;
		Panel.SetActive(false);
		Panel.transform.Find("PlayerName").gameObject.GetComponent<Text>().text = "defaultText";
    }
	
}