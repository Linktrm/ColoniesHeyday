
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIRoleBoard3P : UIRoleBoard {

	// Use this for initialization
	void Start () {
		DeselectFrameRoles();
		UICoinsBuilder.text = "0";
		UICoinsCaptain.text = "0";
		UICoinsCraftsman.text = "0";
		UICoinsMayor.text = "0";
		UICoinsSettler.text = "0";
		UICoinsTrader.text = "0";

		UIPanelCoinsBuilder.SetActive(false);
		UIPanelCoinsCaptain.SetActive(false);
		UIPanelCoinsCraftsman.SetActive(false);
		UIPanelCoinsMayor.SetActive(false);
		UIPanelCoinsSettler.SetActive(false);
		UIPanelCoinsTrader.SetActive(false);
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
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIRoleCraftsman.activeSelf) {
					SelectRole(RoleTypes.CRAFTSMAN, UIFrameCraftsman);
					return InputManager.GetDone(playerController);
				} else if(UIRoleSettler.activeSelf) {
					SelectRole(RoleTypes.SETTLER, UIFrameSettler);
					return InputManager.GetDone(playerController);
				} else if(UIRoleMayor.activeSelf) {
					SelectRole(RoleTypes.MAYOR, UIFrameMayor);
					return InputManager.GetDone(playerController);
				} else if(UIRoleTrader.activeSelf) {
					SelectRole(RoleTypes.TRADER, UIFrameTrader);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIRoleSettler.activeSelf) {
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
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIRoleMayor.activeSelf) {
					SelectRole(RoleTypes.MAYOR, UIFrameMayor);
					return InputManager.GetDone(playerController);
				} else if(UIRoleTrader.activeSelf) {
					SelectRole(RoleTypes.TRADER, UIFrameTrader);
					return InputManager.GetDone(playerController);
				} else if(UIRoleCraftsman.activeSelf) {
					SelectRole(RoleTypes.CRAFTSMAN, UIFrameCraftsman);
					return InputManager.GetDone(playerController);
				} else if(UIRoleSettler.activeSelf) {
					SelectRole(RoleTypes.SETTLER, UIFrameSettler);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIRoleTrader.activeSelf) {
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
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIRoleSettler.activeSelf) {
					SelectRole(RoleTypes.SETTLER, UIFrameSettler);
					return InputManager.GetDone(playerController);
				} else if(UIRoleTrader.activeSelf) {
					SelectRole(RoleTypes.TRADER, UIFrameTrader);
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
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIRoleTrader.activeSelf) {
					SelectRole(RoleTypes.TRADER, UIFrameTrader);
					return InputManager.GetDone(playerController);
				} else if(UIRoleSettler.activeSelf) {
					SelectRole(RoleTypes.SETTLER, UIFrameSettler);
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
		}
	}
}