using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIRoleBoard5P : UIRoleBoard {

	//public GameObject UIRoleProspector1;
	//public GameObject UIRoleProspector2;

	//public GameObject UIFrameProspector1;
	//public GameObject UIFrameProspector2;

	//public GameObject UIPanelCoinsProspector1;
	//public GameObject UIPanelCoinsProspector2;

	//public Text UICoinsProspector1;
	//public Text UICoinsProspector2;

	// Use this for initialization
	void Start () {
		DeselectFrameRoles();
		UICoinsBuilder.text = "0";
		UICoinsCaptain.text = "0";
		UICoinsCraftsman.text = "0";
		UICoinsMayor.text = "0";
		UICoinsSettler.text = "0";
		UICoinsTrader.text = "0";
		UICoinsProspector1.text = "0";
		UICoinsProspector2.text = "0";

		UIPanelCoinsBuilder.SetActive(false);
		UIPanelCoinsCaptain.SetActive(false);
		UIPanelCoinsCraftsman.SetActive(false);
		UIPanelCoinsMayor.SetActive(false);
		UIPanelCoinsSettler.SetActive(false);
		UIPanelCoinsTrader.SetActive(false);
		UIPanelCoinsProspector1.SetActive(false);
		UIPanelCoinsProspector2.SetActive(false);
	}

	public override void SelectFirstRoleAvailable() {
		if(UIRoleBuilder.activeSelf) {
			UIFrameBuilder.GetComponent<Image>().sprite = UIRoleFrame;
			roleSelected = RoleTypes.BUILDER;
		} else if(UIRoleCaptain.activeSelf) {
			UIFrameCaptain.GetComponent<Image>().sprite = UIRoleFrame;
			roleSelected = RoleTypes.CAPTAIN;
		} else if(UIRoleCraftsman.activeSelf) {
			UIFrameCraftsman.GetComponent<Image>().sprite = UIRoleFrame;
			roleSelected = RoleTypes.CRAFTSMAN;
		} else if(UIRoleMayor.activeSelf) {
			UIFrameMayor.GetComponent<Image>().sprite = UIRoleFrame;
			roleSelected = RoleTypes.MAYOR;
		} else if(UIRoleSettler.activeSelf) {
			UIFrameSettler.GetComponent<Image>().sprite = UIRoleFrame;
			roleSelected = RoleTypes.SETTLER;
		} else if(UIRoleTrader.activeSelf) {
			UIFrameTrader.GetComponent<Image>().sprite = UIRoleFrame;
			roleSelected = RoleTypes.TRADER;
		} else if(UIRoleProspector1.activeSelf) {
			UIFrameProspector1.GetComponent<Image>().sprite = UIRoleFrame;
			roleSelected = RoleTypes.PROSPECTOR_1;
		} else if(UIRoleProspector2.activeSelf) {
			UIFrameProspector2.GetComponent<Image>().sprite = UIRoleFrame;
			roleSelected = RoleTypes.PROSPECTOR_2;
		}
	}

	public override InputType MoveCursor(InputType inputX, InputType inputY, int playerController) {
		if(roleSelected == RoleTypes.BUILDER) { // BUILDER
			// Izquierda o Derecha
			if(inputX == InputManager.GetLeft(playerController) || inputX == InputManager.GetRight(playerController)) {
				if(UIRoleCaptain.activeSelf) {
					SelectRole(RoleTypes.CAPTAIN, UIFrameCaptain);
					return InputManager.GetDone(playerController);
				} else if(UIRoleMayor.activeSelf) {
					SelectRole(RoleTypes.MAYOR, UIFrameMayor);
					return InputManager.GetDone(playerController);
				} else if(UIRoleTrader.activeSelf) {
					SelectRole(RoleTypes.TRADER, UIFrameTrader);
					return InputManager.GetDone(playerController);
				} else if(UIRoleProspector2.activeSelf) {
					SelectRole(RoleTypes.PROSPECTOR_2, UIFrameProspector2);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIRoleCraftsman.activeSelf) {
					SelectRole(RoleTypes.CRAFTSMAN, UIFrameCraftsman);
					return InputManager.GetDone(playerController);
				} else if(UIRoleSettler.activeSelf) {
					SelectRole(RoleTypes.SETTLER, UIFrameSettler);
					return InputManager.GetDone(playerController);
				} else if(UIRoleProspector1.activeSelf) {
					SelectRole(RoleTypes.PROSPECTOR_1, UIFrameProspector1);
					return InputManager.GetDone(playerController);
				} else if(UIRoleMayor.activeSelf) {
					SelectRole(RoleTypes.MAYOR, UIFrameMayor);
					return InputManager.GetDone(playerController);
				} else if(UIRoleTrader.activeSelf) {
					SelectRole(RoleTypes.TRADER, UIFrameTrader);
					return InputManager.GetDone(playerController);
				} else if(UIRoleProspector2.activeSelf) {
					SelectRole(RoleTypes.PROSPECTOR_2, UIFrameProspector2);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIRoleProspector1.activeSelf) {
					SelectRole(RoleTypes.PROSPECTOR_1, UIFrameProspector1);
					return InputManager.GetDone(playerController);
				} else if(UIRoleProspector2.activeSelf) {
					SelectRole(RoleTypes.PROSPECTOR_2, UIFrameProspector2);
					return InputManager.GetDone(playerController);
				} else if(UIRoleSettler.activeSelf) {
					SelectRole(RoleTypes.SETTLER, UIFrameSettler);
					return InputManager.GetDone(playerController);
				} else if(UIRoleTrader.activeSelf) {
					SelectRole(RoleTypes.TRADER, UIFrameTrader);
					return InputManager.GetDone(playerController);
				} else if(UIRoleCraftsman.activeSelf) {
					SelectRole(RoleTypes.CRAFTSMAN, UIFrameCraftsman);
					return InputManager.GetDone(playerController);
				} else if(UIRoleMayor.activeSelf) {
					SelectRole(RoleTypes.MAYOR, UIFrameMayor);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(roleSelected == RoleTypes.CAPTAIN) { // CAPTAIN
			// Izquierda o Derecha
			if(inputX == InputManager.GetLeft(playerController) || inputX == InputManager.GetRight(playerController)) {
				if(UIRoleBuilder.activeSelf) {
					SelectRole(RoleTypes.BUILDER, UIFrameBuilder);
					return InputManager.GetDone(playerController);
				} else if(UIRoleCraftsman.activeSelf) {
					SelectRole(RoleTypes.CRAFTSMAN, UIFrameCraftsman);
					return InputManager.GetDone(playerController);
				} else if(UIRoleSettler.activeSelf) {
					SelectRole(RoleTypes.SETTLER, UIFrameSettler);
					return InputManager.GetDone(playerController);
				} else if(UIRoleProspector1.activeSelf) {
					SelectRole(RoleTypes.PROSPECTOR_1, UIFrameProspector1);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIRoleMayor.activeSelf) {
					SelectRole(RoleTypes.MAYOR, UIFrameMayor);
					return InputManager.GetDone(playerController);
				} else if(UIRoleTrader.activeSelf) {
					SelectRole(RoleTypes.TRADER, UIFrameTrader);
					return InputManager.GetDone(playerController);
				} else if(UIRoleProspector2.activeSelf) {
					SelectRole(RoleTypes.PROSPECTOR_2, UIFrameProspector2);
					return InputManager.GetDone(playerController);
				} else if(UIRoleCraftsman.activeSelf) {
					SelectRole(RoleTypes.CRAFTSMAN, UIFrameCraftsman);
					return InputManager.GetDone(playerController);
				} else if(UIRoleSettler.activeSelf) {
					SelectRole(RoleTypes.SETTLER, UIFrameSettler);
					return InputManager.GetDone(playerController);
				} else if(UIRoleProspector1.activeSelf) {
					SelectRole(RoleTypes.PROSPECTOR_1, UIFrameProspector1);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIRoleProspector2.activeSelf) {
					SelectRole(RoleTypes.PROSPECTOR_2, UIFrameProspector2);
					return InputManager.GetDone(playerController);
				} else if(UIRoleProspector1.activeSelf) {
					SelectRole(RoleTypes.PROSPECTOR_1, UIFrameProspector1);
					return InputManager.GetDone(playerController);
				} else if(UIRoleTrader.activeSelf) {
					SelectRole(RoleTypes.TRADER, UIFrameTrader);
					return InputManager.GetDone(playerController);
				} else if(UIRoleSettler.activeSelf) {
					SelectRole(RoleTypes.SETTLER, UIFrameSettler);
					return InputManager.GetDone(playerController);
				} else if(UIRoleMayor.activeSelf) {
					SelectRole(RoleTypes.MAYOR, UIFrameMayor);
					return InputManager.GetDone(playerController);
				} else if(UIRoleCraftsman.activeSelf) {
					SelectRole(RoleTypes.CRAFTSMAN, UIFrameCraftsman);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(roleSelected == RoleTypes.CRAFTSMAN) { // CRAFTSMAN
			// Izquierda o Derecha
			if(inputX == InputManager.GetLeft(playerController) || inputX == InputManager.GetRight(playerController)) {
				if(UIRoleMayor.activeSelf) {
					SelectRole(RoleTypes.MAYOR, UIFrameMayor);
					return InputManager.GetDone(playerController);
				} else if(UIRoleCaptain.activeSelf) {
					SelectRole(RoleTypes.CAPTAIN, UIFrameCaptain);
					return InputManager.GetDone(playerController);
				} else if(UIRoleTrader.activeSelf) {
					SelectRole(RoleTypes.TRADER, UIFrameTrader);
					return InputManager.GetDone(playerController);
				} else if(UIRoleProspector2.activeSelf) {
					SelectRole(RoleTypes.PROSPECTOR_2, UIFrameProspector2);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIRoleSettler.activeSelf) {
					SelectRole(RoleTypes.SETTLER, UIFrameSettler);
					return InputManager.GetDone(playerController);
				} else if(UIRoleProspector1.activeSelf) {
					SelectRole(RoleTypes.PROSPECTOR_1, UIFrameProspector1);
					return InputManager.GetDone(playerController);
				} else if(UIRoleTrader.activeSelf) {
					SelectRole(RoleTypes.TRADER, UIFrameTrader);
					return InputManager.GetDone(playerController);
				} else if(UIRoleProspector2.activeSelf) {
					SelectRole(RoleTypes.PROSPECTOR_2, UIFrameProspector2);
					return InputManager.GetDone(playerController);
				} else if(UIRoleBuilder.activeSelf) {
					SelectRole(RoleTypes.BUILDER, UIFrameBuilder);
					return InputManager.GetDone(playerController);
				} else if(UIRoleCaptain.activeSelf) {
					SelectRole(RoleTypes.CAPTAIN, UIFrameCaptain);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIRoleBuilder.activeSelf) {
					SelectRole(RoleTypes.BUILDER, UIFrameBuilder);
					return InputManager.GetDone(playerController);
				} else if(UIRoleCaptain.activeSelf) {
					SelectRole(RoleTypes.CAPTAIN, UIFrameCaptain);
					return InputManager.GetDone(playerController);
				} else if(UIRoleProspector1.activeSelf) {
					SelectRole(RoleTypes.PROSPECTOR_1, UIFrameProspector1);
					return InputManager.GetDone(playerController);
				} else if(UIRoleProspector2.activeSelf) {
					SelectRole(RoleTypes.PROSPECTOR_2, UIFrameProspector2);
					return InputManager.GetDone(playerController);
				} else if(UIRoleSettler.activeSelf) {
					SelectRole(RoleTypes.SETTLER, UIFrameSettler);
					return InputManager.GetDone(playerController);
				} else if(UIRoleTrader.activeSelf) {
					SelectRole(RoleTypes.TRADER, UIFrameTrader);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(roleSelected == RoleTypes.MAYOR) { // MAYOR
			// Izquierda o Derecha
			if(inputX == InputManager.GetLeft(playerController) || inputX == InputManager.GetRight(playerController)) {
				if(UIRoleCraftsman.activeSelf) {
					SelectRole(RoleTypes.CRAFTSMAN, UIFrameCraftsman);
					return InputManager.GetDone(playerController);
				} else if(UIRoleBuilder.activeSelf) {
					SelectRole(RoleTypes.BUILDER, UIFrameBuilder);
					return InputManager.GetDone(playerController);
				} else if(UIRoleSettler.activeSelf) {
					SelectRole(RoleTypes.SETTLER, UIFrameSettler);
					return InputManager.GetDone(playerController);
				} else if(UIRoleProspector1.activeSelf) {
					SelectRole(RoleTypes.PROSPECTOR_1, UIFrameProspector1);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIRoleTrader.activeSelf) {
					SelectRole(RoleTypes.TRADER, UIFrameTrader);
					return InputManager.GetDone(playerController);
				} else if(UIRoleProspector2.activeSelf) {
					SelectRole(RoleTypes.PROSPECTOR_2, UIFrameProspector2);
					return InputManager.GetDone(playerController);
				} else if(UIRoleSettler.activeSelf) {
					SelectRole(RoleTypes.SETTLER, UIFrameSettler);
					return InputManager.GetDone(playerController);
				} else if(UIRoleProspector1.activeSelf) {
					SelectRole(RoleTypes.PROSPECTOR_1, UIFrameProspector1);
					return InputManager.GetDone(playerController);
				} else if(UIRoleCaptain.activeSelf) {
					SelectRole(RoleTypes.CAPTAIN, UIFrameCaptain);
					return InputManager.GetDone(playerController);
				} else if(UIRoleBuilder.activeSelf) {
					SelectRole(RoleTypes.BUILDER, UIFrameBuilder);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIRoleCaptain.activeSelf) {
					SelectRole(RoleTypes.CAPTAIN, UIFrameCaptain);
					return InputManager.GetDone(playerController);
				} else if(UIRoleBuilder.activeSelf) {
					SelectRole(RoleTypes.BUILDER, UIFrameBuilder);
					return InputManager.GetDone(playerController);
				} else if(UIRoleProspector2.activeSelf) {
					SelectRole(RoleTypes.PROSPECTOR_2, UIFrameProspector2);
					return InputManager.GetDone(playerController);
				} else if(UIRoleProspector1.activeSelf) {
					SelectRole(RoleTypes.PROSPECTOR_1, UIFrameProspector1);
					return InputManager.GetDone(playerController);
				} else if(UIRoleTrader.activeSelf) {
					SelectRole(RoleTypes.TRADER, UIFrameTrader);
					return InputManager.GetDone(playerController);
				} else if(UIRoleSettler.activeSelf) {
					SelectRole(RoleTypes.SETTLER, UIFrameSettler);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(roleSelected == RoleTypes.SETTLER) { // SETTLER
			// Izquierda o Derecha
			if(inputX == InputManager.GetLeft(playerController) || inputX == InputManager.GetRight(playerController)) {
				if(UIRoleTrader.activeSelf) {
					SelectRole(RoleTypes.TRADER, UIFrameTrader);
					return InputManager.GetDone(playerController);
				} else if(UIRoleMayor.activeSelf) {
					SelectRole(RoleTypes.MAYOR, UIFrameMayor);
					return InputManager.GetDone(playerController);
				} else if(UIRoleProspector2.activeSelf) {
					SelectRole(RoleTypes.PROSPECTOR_2, UIFrameProspector2);
					return InputManager.GetDone(playerController);
				} else if(UIRoleCaptain.activeSelf) {
					SelectRole(RoleTypes.CAPTAIN, UIFrameCaptain);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIRoleProspector1.activeSelf) {
					SelectRole(RoleTypes.PROSPECTOR_1, UIFrameProspector1);
					return InputManager.GetDone(playerController);
				} else if(UIRoleProspector2.activeSelf) {
					SelectRole(RoleTypes.PROSPECTOR_2, UIFrameProspector2);
					return InputManager.GetDone(playerController);
				} else if(UIRoleBuilder.activeSelf) {
					SelectRole(RoleTypes.BUILDER, UIFrameBuilder);
					return InputManager.GetDone(playerController);
				} else if(UIRoleCaptain.activeSelf) {
					SelectRole(RoleTypes.CAPTAIN, UIFrameCaptain);
					return InputManager.GetDone(playerController);
				} else if(UIRoleCraftsman.activeSelf) {
					SelectRole(RoleTypes.CRAFTSMAN, UIFrameCraftsman);
					return InputManager.GetDone(playerController);
				} else if(UIRoleMayor.activeSelf) {
					SelectRole(RoleTypes.MAYOR, UIFrameMayor);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIRoleCraftsman.activeSelf) {
					SelectRole(RoleTypes.CRAFTSMAN, UIFrameCraftsman);
					return InputManager.GetDone(playerController);
				} else if(UIRoleBuilder.activeSelf) {
					SelectRole(RoleTypes.BUILDER, UIFrameBuilder);
					return InputManager.GetDone(playerController);
				} else if(UIRoleMayor.activeSelf) {
					SelectRole(RoleTypes.MAYOR, UIFrameMayor);
					return InputManager.GetDone(playerController);
				} else if(UIRoleCaptain.activeSelf) {
					SelectRole(RoleTypes.CAPTAIN, UIFrameCaptain);
					return InputManager.GetDone(playerController);
				} else if(UIRoleProspector1.activeSelf) {
					SelectRole(RoleTypes.PROSPECTOR_1, UIFrameProspector1);
					return InputManager.GetDone(playerController);
				} else if(UIRoleProspector2.activeSelf) {
					SelectRole(RoleTypes.PROSPECTOR_2, UIFrameProspector2);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(roleSelected == RoleTypes.TRADER) { // TRADER
			// Izquierda o Derecha
			if(inputX == InputManager.GetLeft(playerController) || inputX == InputManager.GetRight(playerController)) {
				if(UIRoleSettler.activeSelf) {
					SelectRole(RoleTypes.SETTLER, UIFrameSettler);
					return InputManager.GetDone(playerController);
				} else if(UIRoleCraftsman.activeSelf) {
					SelectRole(RoleTypes.CRAFTSMAN, UIFrameCraftsman);
					return InputManager.GetDone(playerController);
				} else if(UIRoleProspector1.activeSelf) {
					SelectRole(RoleTypes.PROSPECTOR_1, UIFrameProspector1);
					return InputManager.GetDone(playerController);
				} else if(UIRoleBuilder.activeSelf) {
					SelectRole(RoleTypes.BUILDER, UIFrameBuilder);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIRoleProspector2.activeSelf) {
					SelectRole(RoleTypes.PROSPECTOR_2, UIFrameProspector2);
					return InputManager.GetDone(playerController);
				} else if(UIRoleProspector1.activeSelf) {
					SelectRole(RoleTypes.PROSPECTOR_1, UIFrameProspector1);
					return InputManager.GetDone(playerController);
				} else if(UIRoleCaptain.activeSelf) {
					SelectRole(RoleTypes.CAPTAIN, UIFrameCaptain);
					return InputManager.GetDone(playerController);
				} else if(UIRoleBuilder.activeSelf) {
					SelectRole(RoleTypes.BUILDER, UIFrameBuilder);
					return InputManager.GetDone(playerController);
				} else if(UIRoleMayor.activeSelf) {
					SelectRole(RoleTypes.MAYOR, UIFrameMayor);
					return InputManager.GetDone(playerController);
				} else if(UIRoleCraftsman.activeSelf) {
					SelectRole(RoleTypes.CRAFTSMAN, UIFrameCraftsman);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIRoleMayor.activeSelf) {
					SelectRole(RoleTypes.MAYOR, UIFrameMayor);
					return InputManager.GetDone(playerController);
				} else if(UIRoleCaptain.activeSelf) {
					SelectRole(RoleTypes.CAPTAIN, UIFrameCaptain);
					return InputManager.GetDone(playerController);
				} else if(UIRoleCraftsman.activeSelf) {
					SelectRole(RoleTypes.CRAFTSMAN, UIFrameCraftsman);
					return InputManager.GetDone(playerController);
				} else if(UIRoleBuilder.activeSelf) {
					SelectRole(RoleTypes.BUILDER, UIFrameBuilder);
					return InputManager.GetDone(playerController);
				} else if(UIRoleProspector2.activeSelf) {
					SelectRole(RoleTypes.PROSPECTOR_2, UIFrameProspector2);
					return InputManager.GetDone(playerController);
				} else if(UIRoleProspector1.activeSelf) {
					SelectRole(RoleTypes.PROSPECTOR_1, UIFrameProspector1);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(roleSelected == RoleTypes.PROSPECTOR_1) { // PROSPECTOR 1
			// Izquierda o Derecha
			if(inputX == InputManager.GetLeft(playerController) || inputX == InputManager.GetRight(playerController)) {
				if(UIRoleProspector2.activeSelf) {
					SelectRole(RoleTypes.PROSPECTOR_2, UIFrameProspector2);
					return InputManager.GetDone(playerController);
				} else if(UIRoleTrader.activeSelf) {
					SelectRole(RoleTypes.TRADER, UIFrameTrader);
					return InputManager.GetDone(playerController);
				} else if(UIRoleMayor.activeSelf) {
					SelectRole(RoleTypes.MAYOR, UIFrameMayor);
					return InputManager.GetDone(playerController);
				} else if(UIRoleCaptain.activeSelf) {
					SelectRole(RoleTypes.CAPTAIN, UIFrameCaptain);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIRoleBuilder.activeSelf) {
					SelectRole(RoleTypes.BUILDER, UIFrameBuilder);
					return InputManager.GetDone(playerController);
				} else if(UIRoleCaptain.activeSelf) {
					SelectRole(RoleTypes.CAPTAIN, UIFrameCaptain);
					return InputManager.GetDone(playerController);
				} else if(UIRoleCraftsman.activeSelf) {
					SelectRole(RoleTypes.CRAFTSMAN, UIFrameCraftsman);
					return InputManager.GetDone(playerController);
				} else if(UIRoleMayor.activeSelf) {
					SelectRole(RoleTypes.MAYOR, UIFrameMayor);
					return InputManager.GetDone(playerController);
				} else if(UIRoleSettler.activeSelf) {
					SelectRole(RoleTypes.SETTLER, UIFrameSettler);
					return InputManager.GetDone(playerController);
				} else if(UIRoleTrader.activeSelf) {
					SelectRole(RoleTypes.TRADER, UIFrameTrader);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIRoleSettler.activeSelf) {
					SelectRole(RoleTypes.SETTLER, UIFrameSettler);
					return InputManager.GetDone(playerController);
				} else if(UIRoleCraftsman.activeSelf) {
					SelectRole(RoleTypes.CRAFTSMAN, UIFrameCraftsman);
					return InputManager.GetDone(playerController);
				} else if(UIRoleBuilder.activeSelf) {
					SelectRole(RoleTypes.BUILDER, UIFrameBuilder);
					return InputManager.GetDone(playerController);
				} else if(UIRoleTrader.activeSelf) {
					SelectRole(RoleTypes.TRADER, UIFrameTrader);
					return InputManager.GetDone(playerController);
				} else if(UIRoleMayor.activeSelf) {
					SelectRole(RoleTypes.MAYOR, UIFrameMayor);
					return InputManager.GetDone(playerController);
				} else if(UIRoleCaptain.activeSelf) {
					SelectRole(RoleTypes.CAPTAIN, UIFrameCaptain);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(roleSelected == RoleTypes.PROSPECTOR_2) { // PROSPECTOR 2
			// Izquierda o Derecha
			if(inputX == InputManager.GetLeft(playerController) || inputX == InputManager.GetRight(playerController)) {
				if(UIRoleProspector1.activeSelf) {
					SelectRole(RoleTypes.PROSPECTOR_1, UIFrameProspector1);
					return InputManager.GetDone(playerController);
				} else if(UIRoleSettler.activeSelf) {
					SelectRole(RoleTypes.SETTLER, UIFrameSettler);
					return InputManager.GetDone(playerController);
				} else if(UIRoleCraftsman.activeSelf) {
					SelectRole(RoleTypes.CRAFTSMAN, UIFrameCraftsman);
					return InputManager.GetDone(playerController);
				} else if(UIRoleBuilder.activeSelf) {
					SelectRole(RoleTypes.BUILDER, UIFrameBuilder);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIRoleCaptain.activeSelf) {
					SelectRole(RoleTypes.CAPTAIN, UIFrameCaptain);
					return InputManager.GetDone(playerController);
				} else if(UIRoleBuilder.activeSelf) {
					SelectRole(RoleTypes.BUILDER, UIFrameBuilder);
					return InputManager.GetDone(playerController);
				} else if(UIRoleMayor.activeSelf) {
					SelectRole(RoleTypes.MAYOR, UIFrameMayor);
					return InputManager.GetDone(playerController);
				} else if(UIRoleCraftsman.activeSelf) {
					SelectRole(RoleTypes.CRAFTSMAN, UIFrameCraftsman);
					return InputManager.GetDone(playerController);
				} else if(UIRoleTrader.activeSelf) {
					SelectRole(RoleTypes.TRADER, UIFrameTrader);
					return InputManager.GetDone(playerController);
				} else if(UIRoleSettler.activeSelf) {
					SelectRole(RoleTypes.SETTLER, UIFrameSettler);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIRoleTrader.activeSelf) {
					SelectRole(RoleTypes.TRADER, UIFrameTrader);
					return InputManager.GetDone(playerController);
				} else if(UIRoleMayor.activeSelf) {
					SelectRole(RoleTypes.MAYOR, UIFrameMayor);
					return InputManager.GetDone(playerController);
				} else if(UIRoleCaptain.activeSelf) {
					SelectRole(RoleTypes.CAPTAIN, UIFrameCaptain);
					return InputManager.GetDone(playerController);
				} else if(UIRoleSettler.activeSelf) {
					SelectRole(RoleTypes.SETTLER, UIFrameSettler);
					return InputManager.GetDone(playerController);
				} else if(UIRoleCraftsman.activeSelf) {
					SelectRole(RoleTypes.CRAFTSMAN, UIFrameCraftsman);
					return InputManager.GetDone(playerController);
				} else if(UIRoleBuilder.activeSelf) {
					SelectRole(RoleTypes.BUILDER, UIFrameBuilder);
					return InputManager.GetDone(playerController);
				}
			}
		}
		return InputManager.GetIdle(playerController);
	}

	protected override void DeselectFrameRoles() {
		UIFrameBuilder.GetComponent<Image>().sprite = UIRoleFrameTransparent;
		UIFrameCaptain.GetComponent<Image>().sprite = UIRoleFrameTransparent;
		UIFrameCraftsman.GetComponent<Image>().sprite = UIRoleFrameTransparent;
		UIFrameMayor.GetComponent<Image>().sprite = UIRoleFrameTransparent;
		UIFrameSettler.GetComponent<Image>().sprite = UIRoleFrameTransparent;
		UIFrameTrader.GetComponent<Image>().sprite = UIRoleFrameTransparent;
		UIFrameProspector1.GetComponent<Image>().sprite = UIRoleFrameTransparent;
		UIFrameProspector2.GetComponent<Image>().sprite = UIRoleFrameTransparent;
	}

	public override void ActivateRole(Role role) {
		switch(role.type) {
			case RoleTypes.BUILDER:
				UIRoleBuilder.SetActive(true);
				UIPanelCoinsBuilder.SetActive(false);
				break;
			case RoleTypes.CAPTAIN:
				UIRoleCaptain.SetActive(true);
				UIPanelCoinsCaptain.SetActive(false);
				break;
			case RoleTypes.CRAFTSMAN:
				UIRoleCraftsman.SetActive(true);
				UIPanelCoinsCraftsman.SetActive(false);
				break;
			case RoleTypes.MAYOR:
				UIRoleMayor.SetActive(true);
				UIPanelCoinsMayor.SetActive(false);
				break;
			case RoleTypes.SETTLER:
				UIRoleSettler.SetActive(true);
				UIPanelCoinsSettler.SetActive(false);
				break;
			case RoleTypes.TRADER:
				UIRoleTrader.SetActive(true);
				UIPanelCoinsTrader.SetActive(false);
				break;
			case RoleTypes.PROSPECTOR_1:
				UIRoleProspector1.SetActive(true);
				UIPanelCoinsProspector1.SetActive(false);
				break;
			case RoleTypes.PROSPECTOR_2:
				UIRoleProspector2.SetActive(true);
				UIPanelCoinsProspector2.SetActive(false);
				break;
		}
	}

	public override void RefreshCoins(Role role) {
		switch(role.type) {
			case RoleTypes.BUILDER:
				UIRoleBuilder.SetActive(true);
				if(role.stackedCoins > 0) {
					UIPanelCoinsBuilder.SetActive(true);
					UICoinsBuilder.text = role.stackedCoins.ToString();
				}
				break;
			case RoleTypes.CAPTAIN:
				UIRoleCaptain.SetActive(true);
				UICoinsCaptain.text = role.stackedCoins.ToString();
				if(role.stackedCoins > 0) {
					UIPanelCoinsCaptain.SetActive(true);
					UICoinsCaptain.text = role.stackedCoins.ToString();
				}
				break;
			case RoleTypes.CRAFTSMAN:
				UIRoleCraftsman.SetActive(true);
				UICoinsCraftsman.text = role.stackedCoins.ToString();
				if(role.stackedCoins > 0) {
					UIPanelCoinsCraftsman.SetActive(true);
					UICoinsCraftsman.text = role.stackedCoins.ToString();
				}
				break;
			case RoleTypes.MAYOR:
				UIRoleMayor.SetActive(true);
				UICoinsMayor.text = role.stackedCoins.ToString();
				if(role.stackedCoins > 0) {
					UIPanelCoinsMayor.SetActive(true);
					UICoinsMayor.text = role.stackedCoins.ToString();
				}
				break;
			case RoleTypes.SETTLER:
				UIRoleSettler.SetActive(true);
				UICoinsSettler.text = role.stackedCoins.ToString();
				if(role.stackedCoins > 0) {
					UIPanelCoinsSettler.SetActive(true);
					UICoinsSettler.text = role.stackedCoins.ToString();
				}
				break;
			case RoleTypes.TRADER:
				UIRoleTrader.SetActive(true);
				UICoinsTrader.text = role.stackedCoins.ToString();
				if(role.stackedCoins > 0) {
					UIPanelCoinsTrader.SetActive(true);
					UICoinsTrader.text = role.stackedCoins.ToString();
				}
				break;
			case RoleTypes.PROSPECTOR_1:
				UIRoleProspector1.SetActive(true);
				UICoinsProspector1.text = role.stackedCoins.ToString();
				if(role.stackedCoins > 0) {
					UIPanelCoinsProspector1.SetActive(true);
					UICoinsProspector1.text = role.stackedCoins.ToString();
				}
				break;
			case RoleTypes.PROSPECTOR_2:
				UIRoleProspector2.SetActive(true);
				UICoinsProspector2.text = role.stackedCoins.ToString();
				if(role.stackedCoins > 0) {
					UIPanelCoinsProspector2.SetActive(true);
					UICoinsProspector2.text = role.stackedCoins.ToString();
				}
				break;
		}
	}
}