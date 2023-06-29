using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPlantationBoard3P : UIPlantationBoard {

	public GameObject UIPlantation4;

	public GameObject UIFramePlantation4;

	// Use this for initialization
	void Start () {
		DeselectFrames();
		UIQuarry.text = "8";
	}

	public override void RefreshPlantations() {
		UIPlantation1.SetActive(false);
		UIPlantation2.SetActive(false);
		UIPlantation3.SetActive(false);
		UIPlantation4.SetActive(false);
		if(GameData.plantationsShowed.Count > 0) {
			UIPlantation1.SetActive(true);
			UIPlantation1.GetComponent<Image>().sprite = UIGetPlantationSpriteByType(GameData.plantationsShowed[0].type);
			if(GameData.plantationsShowed.Count > 1) {
				UIPlantation2.SetActive(true);
				UIPlantation2.GetComponent<Image>().sprite = UIGetPlantationSpriteByType(GameData.plantationsShowed[1].type);
				if(GameData.plantationsShowed.Count > 2) {
					UIPlantation3.SetActive(true);
					UIPlantation3.GetComponent<Image>().sprite = UIGetPlantationSpriteByType(GameData.plantationsShowed[2].type);
					if(GameData.plantationsShowed.Count > 3) {
						UIPlantation4.SetActive(true);
						UIPlantation4.GetComponent<Image>().sprite = UIGetPlantationSpriteByType(GameData.plantationsShowed[3].type);
					}
				}
			}
		}
		if(GameData.plantationReserve.Count <= 0) {
			UIFramePlantationReservation.SetActive(false);
		}
	}
	
	public override void SelectFirstSlotAvailable() {
		DeselectFrames();
		if(quarrySelectable && GameData.quarryReserve.Count > 0) {
			SelectPlantation(UIFramePlantationQuarry, SettlerObjectType.QUARRY, 0, UIFramePlantationQuarry);
		} else if(UIPlantation1.activeSelf) {
			SelectPlantation(UIPlantation1, SettlerObjectType.PLANTATION_1, 1, UIFramePlantation1);
		} else if(UIPlantation2.activeSelf) {
			SelectPlantation(UIPlantation2, SettlerObjectType.PLANTATION_2, 2, UIFramePlantation2);
		} else if(UIPlantation3.activeSelf) {
			SelectPlantation(UIPlantation3, SettlerObjectType.PLANTATION_3, 3, UIFramePlantation3);
		} else if(UIPlantation4.activeSelf) {
			SelectPlantation(UIPlantation4, SettlerObjectType.PLANTATION_4, 4, UIFramePlantation4);
		}
	}
	
	public override InputType MoveCursor(InputType inputX, InputType inputY, int playerController) {
		if(objectTypeSelected == SettlerObjectType.QUARRY) { // QUARRY
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UIPlantation3.activeSelf) {
					SelectPlantation(UIPlantation3, SettlerObjectType.PLANTATION_3, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectPlantation(UIPlantation2, SettlerObjectType.PLANTATION_2, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectPlantation(UIPlantation4, SettlerObjectType.PLANTATION_4, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectPlantation(UIPlantation1, SettlerObjectType.PLANTATION_1, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UIPlantation4.activeSelf) {
					SelectPlantation(UIPlantation4, SettlerObjectType.PLANTATION_4, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectPlantation(UIPlantation1, SettlerObjectType.PLANTATION_1, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectPlantation(UIPlantation2, SettlerObjectType.PLANTATION_2, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectPlantation(UIPlantation3, SettlerObjectType.PLANTATION_3, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				}
			}
			/*
			 else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIPlantation1.activeSelf) {
					selectPlantation(UIPlantation1, SettlerObjectType.PLANTATION_1, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					selectPlantation(UIPlantation2, SettlerObjectType.PLANTATION_2, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					selectPlantation(UIPlantation3, SettlerObjectType.PLANTATION_3, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					selectPlantation(UIPlantation4, SettlerObjectType.PLANTATION_4, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIPlantation4.activeSelf) {
					selectPlantation(UIPlantation4, SettlerObjectType.PLANTATION_4, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					selectPlantation(UIPlantation3, SettlerObjectType.PLANTATION_3, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					selectPlantation(UIPlantation2, SettlerObjectType.PLANTATION_2, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					selectPlantation(UIPlantation1, SettlerObjectType.PLANTATION_1, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				}
			}
			*/
		} else if(objectTypeSelected == SettlerObjectType.PLANTATION_1) { // PLANTATION 1
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(quarrySelectable && GameData.quarryReserve.Count > 0) {
					SelectPlantation(UIFramePlantationQuarry, SettlerObjectType.QUARRY, 0, UIFramePlantationQuarry);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectPlantation(UIPlantation3, SettlerObjectType.PLANTATION_3, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectPlantation(UIPlantation2, SettlerObjectType.PLANTATION_2, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectPlantation(UIPlantation4, SettlerObjectType.PLANTATION_4, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UIPlantation2.activeSelf) {
					SelectPlantation(UIPlantation2, SettlerObjectType.PLANTATION_2, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectPlantation(UIPlantation3, SettlerObjectType.PLANTATION_3, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectPlantation(UIPlantation4, SettlerObjectType.PLANTATION_4, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(quarrySelectable && GameData.quarryReserve.Count > 0) {
					SelectPlantation(UIFramePlantationQuarry, SettlerObjectType.QUARRY, 0, UIFramePlantationQuarry);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController) || inputY == InputManager.GetUp(playerController)) { // Abajo o Arriba
				if(UIPlantation4.activeSelf) {
					SelectPlantation(UIPlantation4, SettlerObjectType.PLANTATION_4, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(quarrySelectable && GameData.quarryReserve.Count > 0) {
					SelectPlantation(UIFramePlantationQuarry, SettlerObjectType.QUARRY, 0, UIFramePlantationQuarry);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectPlantation(UIPlantation2, SettlerObjectType.PLANTATION_2, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectPlantation(UIPlantation3, SettlerObjectType.PLANTATION_3, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(objectTypeSelected == SettlerObjectType.PLANTATION_2) { // PLANTATION 2
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UIPlantation1.activeSelf) {
					SelectPlantation(UIPlantation1, SettlerObjectType.PLANTATION_1, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectPlantation(UIPlantation4, SettlerObjectType.PLANTATION_4, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(quarrySelectable && GameData.quarryReserve.Count > 0) {
					SelectPlantation(UIFramePlantationQuarry, SettlerObjectType.QUARRY, 0, UIFramePlantationQuarry);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectPlantation(UIPlantation3, SettlerObjectType.PLANTATION_3, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UIPlantation3.activeSelf) {
					SelectPlantation(UIPlantation3, SettlerObjectType.PLANTATION_3, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(quarrySelectable && GameData.quarryReserve.Count > 0) {
					SelectPlantation(UIFramePlantationQuarry, SettlerObjectType.QUARRY, 0, UIFramePlantationQuarry);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectPlantation(UIPlantation1, SettlerObjectType.PLANTATION_1, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectPlantation(UIPlantation4, SettlerObjectType.PLANTATION_4, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController) || inputY == InputManager.GetUp(playerController)) { // Abajo o Arriba
				if(UIPlantation4.activeSelf) {
					SelectPlantation(UIPlantation4, SettlerObjectType.PLANTATION_4, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(quarrySelectable && GameData.quarryReserve.Count > 0) {
					SelectPlantation(UIFramePlantationQuarry, SettlerObjectType.QUARRY, 0, UIFramePlantationQuarry);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectPlantation(UIPlantation3, SettlerObjectType.PLANTATION_3, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectPlantation(UIPlantation1, SettlerObjectType.PLANTATION_1, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(objectTypeSelected == SettlerObjectType.PLANTATION_3) { // PLANTATION 3
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UIPlantation2.activeSelf) {
					SelectPlantation(UIPlantation2, SettlerObjectType.PLANTATION_2, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectPlantation(UIPlantation1, SettlerObjectType.PLANTATION_1, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectPlantation(UIPlantation4, SettlerObjectType.PLANTATION_4, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(quarrySelectable && GameData.quarryReserve.Count > 0) {
					SelectPlantation(UIFramePlantationQuarry, SettlerObjectType.QUARRY, 0, UIFramePlantationQuarry);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(quarrySelectable && GameData.quarryReserve.Count > 0) {
					SelectPlantation(UIFramePlantationQuarry, SettlerObjectType.QUARRY, 0, UIFramePlantationQuarry);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectPlantation(UIPlantation1, SettlerObjectType.PLANTATION_1, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectPlantation(UIPlantation4, SettlerObjectType.PLANTATION_4, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectPlantation(UIPlantation2, SettlerObjectType.PLANTATION_2, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController) || inputY == InputManager.GetUp(playerController)) { // Abajo o Arriba
				if(UIPlantation4.activeSelf) {
					SelectPlantation(UIPlantation4, SettlerObjectType.PLANTATION_4, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(quarrySelectable && GameData.quarryReserve.Count > 0) {
					SelectPlantation(UIFramePlantationQuarry, SettlerObjectType.QUARRY, 0, UIFramePlantationQuarry);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectPlantation(UIPlantation1, SettlerObjectType.PLANTATION_1, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectPlantation(UIPlantation2, SettlerObjectType.PLANTATION_2, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(objectTypeSelected == SettlerObjectType.PLANTATION_4) { // PLANTATION 4
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(quarrySelectable && GameData.quarryReserve.Count > 0) {
					SelectPlantation(UIFramePlantationQuarry, SettlerObjectType.QUARRY, 0, UIFramePlantationQuarry);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectPlantation(UIPlantation3, SettlerObjectType.PLANTATION_3, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectPlantation(UIPlantation2, SettlerObjectType.PLANTATION_2, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectPlantation(UIPlantation1, SettlerObjectType.PLANTATION_1, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UIPlantation2.activeSelf) {
					SelectPlantation(UIPlantation2, SettlerObjectType.PLANTATION_2, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectPlantation(UIPlantation3, SettlerObjectType.PLANTATION_3, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(quarrySelectable && GameData.quarryReserve.Count > 0) {
					SelectPlantation(UIFramePlantationQuarry, SettlerObjectType.QUARRY, 0, UIFramePlantationQuarry);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectPlantation(UIPlantation1, SettlerObjectType.PLANTATION_1, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController) || inputY == InputManager.GetUp(playerController)) { // Abajo o Arriba
				if(UIPlantation1.activeSelf) {
					SelectPlantation(UIPlantation1, SettlerObjectType.PLANTATION_1, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectPlantation(UIPlantation2, SettlerObjectType.PLANTATION_2, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectPlantation(UIPlantation3, SettlerObjectType.PLANTATION_3, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(quarrySelectable && GameData.quarryReserve.Count > 0) {
					SelectPlantation(UIFramePlantationQuarry, SettlerObjectType.QUARRY, 0, UIFramePlantationQuarry);
					return InputManager.GetDone(playerController);
				}
			}
		}
		return InputManager.GetIdle(playerController);
	}
	
	public override void DeselectFrames() {
		UIFramePlantation1.GetComponent<Image>().sprite = UIPlantationFrameTransparent;
		UIFramePlantation2.GetComponent<Image>().sprite = UIPlantationFrameTransparent;
		UIFramePlantation3.GetComponent<Image>().sprite = UIPlantationFrameTransparent;
		UIFramePlantation4.GetComponent<Image>().sprite = UIPlantationFrameTransparent;
		UIFramePlantationReservation.GetComponent<Image>().sprite = UIPlantationFrameTransparent;
		UIFramePlantationQuarry.GetComponent<Image>().sprite = UIQuarryPanelFrameTransparent;
	}
}