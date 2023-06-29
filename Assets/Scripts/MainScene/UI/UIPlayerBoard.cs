using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPlayerBoard : MonoBehaviour {

	public GameObject UISelectedFrame;
	public Sprite UIPlayerBoardFrame;

	public GameObject UIBuilding1;
	public GameObject UIBuilding2;
	public GameObject UIBuilding3;
	public GameObject UIBuilding4;
	public GameObject UIBuilding5;
	public GameObject UIBuilding6;
	public GameObject UIBuilding7;
	public GameObject UIBuilding8;
	public GameObject UIBuilding9;
	public GameObject UIBuilding10;
	public GameObject UIBuilding11;
	public GameObject UIBuilding12;

	public GameObject UIFrameBuilding1;
	public GameObject UIFrameBuilding2;
	public GameObject UIFrameBuilding3;
	public GameObject UIFrameBuilding4;
	public GameObject UIFrameBuilding5;
	public GameObject UIFrameBuilding6;
	public GameObject UIFrameBuilding7;
	public GameObject UIFrameBuilding8;
	public GameObject UIFrameBuilding9;
	public GameObject UIFrameBuilding10;
	public GameObject UIFrameBuilding11;
	public GameObject UIFrameBuilding12;
	
	public Sprite UIBuildingFrame;
	public Sprite UIBuildingFrameTransparent;

	public GameObject UIPlantation1;
	public GameObject UIPlantation2;
	public GameObject UIPlantation3;
	public GameObject UIPlantation4;
	public GameObject UIPlantation5;
	public GameObject UIPlantation6;
	public GameObject UIPlantation7;
	public GameObject UIPlantation8;
	public GameObject UIPlantation9;
	public GameObject UIPlantation10;
	public GameObject UIPlantation11;
	public GameObject UIPlantation12;

	public GameObject UIFramePlantation1;
	public GameObject UIFramePlantation2;
	public GameObject UIFramePlantation3;
	public GameObject UIFramePlantation4;
	public GameObject UIFramePlantation5;
	public GameObject UIFramePlantation6;
	public GameObject UIFramePlantation7;
	public GameObject UIFramePlantation8;
	public GameObject UIFramePlantation9;
	public GameObject UIFramePlantation10;
	public GameObject UIFramePlantation11;
	public GameObject UIFramePlantation12;

	public Sprite UIPlantationFrame;
	public Sprite UIPlantationFrameTransparent;

	public GameObject UIGovernor;
	public GameObject UIActualRole;
	public GameObject UIFrameActualRole;
	public Sprite UIRoleFrame;
	public Sprite UIRoleFrameTransparent;

	public Text UIPlayerName;

	public Text UIExtraColonist;

	public Text UICornBarrel;
	public Text UIIndigoBarrel;
	public Text UISugarBarrel;
	public Text UITobaccoBarrel;
	public Text UICoffeeBarrel;
	
	public Text UICornBarrelSpoil;
	public Text UIIndigoBarrelSpoil;
	public Text UISugarBarrelSpoil;
	public Text UITobaccoBarrelSpoil;
	public Text UICoffeeBarrelSpoil;

	public GameObject UIFrameBarrelCorn;
	public GameObject UIFrameBarrelIndigo;
	public GameObject UIFrameBarrelSugar;
	public GameObject UIFrameBarrelTobacco;
	public GameObject UIFrameBarrelCoffee;

	public GameObject UIFrameBarrelCornSpoil;
	public GameObject UIFrameBarrelIndigoSpoil;
	public GameObject UIFrameBarrelSugarSpoil;
	public GameObject UIFrameBarrelTobaccoSpoil;
	public GameObject UIFrameBarrelCoffeeSpoil;

	public Sprite UIBarrelFrame;
	public Sprite UIBarrelFrameSpoil;
	public Sprite UIBarrelFrameTransparent;

	public PlantationType selectedBarrel { get; set; }
	
	public Text UICoins;
	public Text UIVP;

	public GameObject UIPanelFinished;

	public int mayorGameObjectIndex { get; set; }
	public GameObject mayorGameObjectSelected { get; set; }
	public GameObjectType mayorGameObjectType { get; set; }

	// Use this for initialization
	void Start () {
		DeselectFramesBuildingsPlantations();
		DeselectFramesBarrels();
		DeselectFramesBarrelsSpoil();

		UISelectedFrame.SetActive(false);
		UIFrameActualRole.GetComponent<Image>().sprite = UIRoleFrameTransparent;

		UIGovernor.SetActive(false);
		UIActualRole.SetActive(false);
		UIActualRole.GetComponent<Image>().sprite = null;
		UIPlayerName.text = "";

		UICornBarrel.text = "0";
		UIIndigoBarrel.text = "0";
		UISugarBarrel.text = "0";
		UITobaccoBarrel.text = "0";
		UICoffeeBarrel.text = "0";

		UIExtraColonist.text = "0";

		UICornBarrelSpoil.text = "0";
		UIIndigoBarrelSpoil.text = "0";
		UISugarBarrelSpoil.text = "0";
		UITobaccoBarrelSpoil.text = "0";
		UICoffeeBarrelSpoil.text = "0";

		ActivateSpoilFrames(false);

		UICoins.text = "0";
		UIVP.text = "0";
	}

	public void UIAssignRole(Sprite roleSprite) {
		UIActualRole.GetComponent<Image>().sprite = roleSprite;
		UIActualRole.SetActive(true);
	}

	public void UIAssignBuilding(Building building) {
		if(building.size > 1) {
			if(!UIBuilding8.activeSelf && !UIBuilding12.activeSelf) {
				ActivateBuilding(UIBuilding8, building, true, false);
				ActivateBuilding(UIBuilding12, building, true, true);
				UIBuilding8.GetComponent<UIBuilding>().anotherPart = UIBuilding12;
				UIBuilding12.GetComponent<UIBuilding>().anotherPart = UIBuilding8;
			} else if(!UIBuilding7.activeSelf && !UIBuilding11.activeSelf) {
				ActivateBuilding(UIBuilding7, building, true, false);
				ActivateBuilding(UIBuilding11, building, true, true);
				UIBuilding7.GetComponent<UIBuilding>().anotherPart = UIBuilding11;
				UIBuilding11.GetComponent<UIBuilding>().anotherPart = UIBuilding7;
			} else if(!UIBuilding6.activeSelf && !UIBuilding10.activeSelf) {
				ActivateBuilding(UIBuilding6, building, true, false);
				ActivateBuilding(UIBuilding10, building, true, true);
				UIBuilding6.GetComponent<UIBuilding>().anotherPart = UIBuilding10;
				UIBuilding10.GetComponent<UIBuilding>().anotherPart = UIBuilding6;
			} else if(!UIBuilding5.activeSelf && !UIBuilding9.activeSelf) {
				ActivateBuilding(UIBuilding5, building, true, false);
				ActivateBuilding(UIBuilding9, building, true, true);
				UIBuilding5.GetComponent<UIBuilding>().anotherPart = UIBuilding9;
				UIBuilding9.GetComponent<UIBuilding>().anotherPart = UIBuilding5;
			} else if(!UIBuilding4.activeSelf && !UIBuilding8.activeSelf) {
				ActivateBuilding(UIBuilding4, building, true, false);
				ActivateBuilding(UIBuilding8, building, true, true);
				UIBuilding4.GetComponent<UIBuilding>().anotherPart = UIBuilding8;
				UIBuilding8.GetComponent<UIBuilding>().anotherPart = UIBuilding4;
			} else if(!UIBuilding3.activeSelf && !UIBuilding7.activeSelf) {
				ActivateBuilding(UIBuilding3, building, true, false);
				ActivateBuilding(UIBuilding7, building, true, true);
				UIBuilding3.GetComponent<UIBuilding>().anotherPart = UIBuilding7;
				UIBuilding7.GetComponent<UIBuilding>().anotherPart = UIBuilding3;
			} else if(!UIBuilding2.activeSelf && !UIBuilding6.activeSelf) {
				ActivateBuilding(UIBuilding2, building, true, false);
				ActivateBuilding(UIBuilding6, building, true, true);
				UIBuilding2.GetComponent<UIBuilding>().anotherPart = UIBuilding6;
				UIBuilding6.GetComponent<UIBuilding>().anotherPart = UIBuilding2;
			} else if(!UIBuilding1.activeSelf && !UIBuilding5.activeSelf) {
				ActivateBuilding(UIBuilding1, building, true, false);
				ActivateBuilding(UIBuilding5, building, true, true);
				UIBuilding1.GetComponent<UIBuilding>().anotherPart = UIBuilding1;
				UIBuilding5.GetComponent<UIBuilding>().anotherPart = UIBuilding5;
			}
		} else if(!UIBuilding1.activeSelf) {
			ActivateBuilding(UIBuilding1, building, false, true);
		} else if(!UIBuilding2.activeSelf) {
			ActivateBuilding(UIBuilding2, building, false, true);
		} else if(!UIBuilding3.activeSelf) {
			ActivateBuilding(UIBuilding3, building, false, true);
		} else if(!UIBuilding4.activeSelf) {
			ActivateBuilding(UIBuilding4, building, false, true);
		} else if(!UIBuilding5.activeSelf) {
			ActivateBuilding(UIBuilding5, building, false, true);
		} else if(!UIBuilding9.activeSelf) {
			ActivateBuilding(UIBuilding6, building, false, true);
		} else if(!UIBuilding6.activeSelf) {
			ActivateBuilding(UIBuilding7, building, false, true);
		} else if(!UIBuilding10.activeSelf) {
			ActivateBuilding(UIBuilding8, building, false, true);
		} else if(!UIBuilding7.activeSelf) {
			ActivateBuilding(UIBuilding9, building, false, true);
		} else if(!UIBuilding11.activeSelf) {
			ActivateBuilding(UIBuilding10, building, false, true);
		} else if(!UIBuilding8.activeSelf) {
			ActivateBuilding(UIBuilding11, building, false, true);
		} else if(!UIBuilding12.activeSelf) {
			ActivateBuilding(UIBuilding12, building, false, true);
		}
	}

	void ActivateBuilding(GameObject UIBuilding, Building building, bool doubleSize, bool lowerPart) {
		UIBuilding.GetComponent<Image>().sprite = UIBuilding.GetComponent<UIBuilding>().GetSpriteByBuildingType(building.type, doubleSize && lowerPart);
		UIBuilding.SetActive(true);
		UIBuilding.GetComponent<UIBuilding>().lowerPart = lowerPart;
		UIBuilding.GetComponent<UIBuilding>().type = building.type;
		if(building.colonists == 1 && lowerPart) {
			UIBuilding.GetComponent<UIBuilding>().UIColonist1.SetActive(true);
		}
	}

	public void UIAssignPlantation(Plantation plantation) {
		if(!UIPlantation1.activeSelf) {
			ActivatePlantation(UIPlantation1, plantation);
		} else if(!UIPlantation2.activeSelf) {
			ActivatePlantation(UIPlantation2, plantation);
		} else if(!UIPlantation3.activeSelf) {
			ActivatePlantation(UIPlantation3, plantation);
		} else if(!UIPlantation4.activeSelf) {
			ActivatePlantation(UIPlantation4, plantation);
		} else if(!UIPlantation5.activeSelf) {
			ActivatePlantation(UIPlantation5, plantation);
		} else if(!UIPlantation6.activeSelf) {
			ActivatePlantation(UIPlantation6, plantation);
		} else if(!UIPlantation7.activeSelf) {
			ActivatePlantation(UIPlantation7, plantation);
		} else if(!UIPlantation8.activeSelf) {
			ActivatePlantation(UIPlantation8, plantation);
		} else if(!UIPlantation9.activeSelf) {
			ActivatePlantation(UIPlantation9, plantation);
		} else if(!UIPlantation10.activeSelf) {
			ActivatePlantation(UIPlantation10, plantation);
		} else if(!UIPlantation11.activeSelf) {
			ActivatePlantation(UIPlantation11, plantation);
		} else if(!UIPlantation12.activeSelf) {
			ActivatePlantation(UIPlantation12, plantation);
		}
	}

	void ActivatePlantation(GameObject UIPlantation, Plantation plantation) {
		UIPlantation.GetComponent<Image>().sprite = UIPlantation.GetComponent<UIPlantation>().GetSpriteByPlantationType(plantation.type);
		UIPlantation.SetActive(true);
		if(plantation.colonist == 1) {
			UIPlantation.GetComponent<UIPlantation>().UIColonist.SetActive(true);
		}
	}

	// =======
	// CAPTAIN
	// =======

	public void SelectFirstSlotAvailableCaptain(PlayerBoard playerBoard, Captain captain) {
		DeselectFramesBarrels();

		// Si puede enviar por el cálculo de los barcos del Captain, o tiene barco privado sin usar
		// CORN
		if(captain.ship1CornShipments > 0 || captain.ship2CornShipments > 0 || captain.ship3CornShipments > 0 || 
			(playerBoard.cornBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
			UIFrameBarrelCorn.GetComponent<Image>().sprite = UIBarrelFrame;
			selectedBarrel = PlantationType.CORN;
		// INDIGO
		} else if(captain.ship1IndigoShipments > 0 || captain.ship2IndigoShipments > 0 || captain.ship3IndigoShipments > 0 || 
			(playerBoard.indigoBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
			UIFrameBarrelIndigo.GetComponent<Image>().sprite = UIBarrelFrame;
			selectedBarrel = PlantationType.INDIGO;
		// SUGAR
		} else if(captain.ship1SugarShipments > 0 || captain.ship2SugarShipments > 0 || captain.ship3SugarShipments > 0 || 
			(playerBoard.sugarBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
			UIFrameBarrelSugar.GetComponent<Image>().sprite = UIBarrelFrame;
			selectedBarrel = PlantationType.SUGAR;
		// TOBACCO
		} else if(captain.ship1TobaccoShipments > 0 || captain.ship2TobaccoShipments > 0 || captain.ship3TobaccoShipments > 0 || 
			(playerBoard.tobaccoBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
			UIFrameBarrelTobacco.GetComponent<Image>().sprite = UIBarrelFrame;
			selectedBarrel = PlantationType.TOBACCO;
		// COFFEE
		} else if(captain.ship1CoffeeShipments > 0 || captain.ship2CoffeeShipments > 0 || captain.ship3CoffeeShipments > 0 || 
			(playerBoard.coffeeBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
			UIFrameBarrelCoffee.GetComponent<Image>().sprite = UIBarrelFrame;
			selectedBarrel = PlantationType.COFFEE;
		}
	}
	
	public InputType MoveCursorCaptain(InputType inputX, InputType inputY, int playerController, PlayerBoard playerBoard, Captain captain) {
		if(selectedBarrel == PlantationType.CORN) { // CORN BARREL
			if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(captain.ship1IndigoShipments > 0 || captain.ship2IndigoShipments > 0 || captain.ship3IndigoShipments > 0 ||
					(playerBoard.indigoBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
					SelectBarrel(UIFrameBarrelIndigo, PlantationType.INDIGO);
					return InputManager.GetDone(playerController);
				} else if(captain.ship1SugarShipments > 0 || captain.ship2SugarShipments > 0 || captain.ship3SugarShipments > 0 ||
					(playerBoard.sugarBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
					SelectBarrel(UIFrameBarrelSugar, PlantationType.SUGAR);
					return InputManager.GetDone(playerController);
				} else if(captain.ship1TobaccoShipments > 0 || captain.ship2TobaccoShipments > 0 || captain.ship3TobaccoShipments > 0 ||
					(playerBoard.tobaccoBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
					SelectBarrel(UIFrameBarrelTobacco, PlantationType.TOBACCO);
					return InputManager.GetDone(playerController);
				} else if(captain.ship1CoffeeShipments > 0 || captain.ship2CoffeeShipments > 0 || captain.ship3CoffeeShipments > 0 ||
					(playerBoard.coffeeBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
					SelectBarrel(UIFrameBarrelCoffee, PlantationType.COFFEE);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(captain.ship1CoffeeShipments > 0 || captain.ship2CoffeeShipments > 0 || captain.ship3CoffeeShipments > 0 ||
					(playerBoard.coffeeBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
					SelectBarrel(UIFrameBarrelCoffee, PlantationType.COFFEE);
					return InputManager.GetDone(playerController);
				} else if(captain.ship1TobaccoShipments > 0 || captain.ship2TobaccoShipments > 0 || captain.ship3TobaccoShipments > 0 ||
					(playerBoard.tobaccoBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
					SelectBarrel(UIFrameBarrelTobacco, PlantationType.TOBACCO);
					return InputManager.GetDone(playerController);
				} else if(captain.ship1SugarShipments > 0 || captain.ship2SugarShipments > 0 || captain.ship3SugarShipments > 0 ||
					(playerBoard.sugarBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
					SelectBarrel(UIFrameBarrelSugar, PlantationType.SUGAR);
					return InputManager.GetDone(playerController);
				} else if(captain.ship1IndigoShipments > 0 || captain.ship2IndigoShipments > 0 || captain.ship3IndigoShipments > 0 ||
					(playerBoard.indigoBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
					SelectBarrel(UIFrameBarrelIndigo, PlantationType.INDIGO);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(selectedBarrel == PlantationType.INDIGO) { // INDIGO BARREL
			if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(captain.ship1SugarShipments > 0 || captain.ship2SugarShipments > 0 || captain.ship3SugarShipments > 0 ||
					(playerBoard.sugarBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
					SelectBarrel(UIFrameBarrelSugar, PlantationType.SUGAR);
					return InputManager.GetDone(playerController);
				} else if(captain.ship1TobaccoShipments > 0 || captain.ship2TobaccoShipments > 0 || captain.ship3TobaccoShipments > 0 ||
					(playerBoard.tobaccoBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
					SelectBarrel(UIFrameBarrelTobacco, PlantationType.TOBACCO);
					return InputManager.GetDone(playerController);
				} else if(captain.ship1CoffeeShipments > 0 || captain.ship2CoffeeShipments > 0 || captain.ship3CoffeeShipments > 0 ||
					(playerBoard.coffeeBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
					SelectBarrel(UIFrameBarrelCoffee, PlantationType.COFFEE);
					return InputManager.GetDone(playerController);
				} else if(captain.ship1CornShipments > 0 || captain.ship2CornShipments > 0 || captain.ship3CornShipments > 0 ||
					(playerBoard.cornBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
					SelectBarrel(UIFrameBarrelCorn, PlantationType.CORN);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(captain.ship1CornShipments > 0 || captain.ship2CornShipments > 0 || captain.ship3CornShipments > 0 ||
					(playerBoard.cornBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
					SelectBarrel(UIFrameBarrelCorn, PlantationType.CORN);
					return InputManager.GetDone(playerController);
				} else if(captain.ship1CoffeeShipments > 0 || captain.ship2CoffeeShipments > 0 || captain.ship3CoffeeShipments > 0 ||
					(playerBoard.coffeeBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
					SelectBarrel(UIFrameBarrelCoffee, PlantationType.COFFEE);
					return InputManager.GetDone(playerController);
				} else if(captain.ship1TobaccoShipments > 0 || captain.ship2TobaccoShipments > 0 || captain.ship3TobaccoShipments > 0 ||
					(playerBoard.tobaccoBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
					SelectBarrel(UIFrameBarrelTobacco, PlantationType.TOBACCO);
					return InputManager.GetDone(playerController);
				} else if(captain.ship1SugarShipments > 0 || captain.ship2SugarShipments > 0 || captain.ship3SugarShipments > 0 ||
					(playerBoard.sugarBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
					SelectBarrel(UIFrameBarrelSugar, PlantationType.SUGAR);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(selectedBarrel == PlantationType.SUGAR) { // SUGAR BARREL
			if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(captain.ship1TobaccoShipments > 0 || captain.ship2TobaccoShipments > 0 || captain.ship3TobaccoShipments > 0 ||
					(playerBoard.tobaccoBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
					SelectBarrel(UIFrameBarrelTobacco, PlantationType.TOBACCO);
					return InputManager.GetDone(playerController);
				} else if(captain.ship1CoffeeShipments > 0 || captain.ship2CoffeeShipments > 0 || captain.ship3CoffeeShipments > 0 ||
					(playerBoard.coffeeBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
					SelectBarrel(UIFrameBarrelCoffee, PlantationType.COFFEE);
					return InputManager.GetDone(playerController);
				} else if(captain.ship1CornShipments > 0 || captain.ship2CornShipments > 0 || captain.ship3CornShipments > 0 ||
					(playerBoard.cornBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
					SelectBarrel(UIFrameBarrelCorn, PlantationType.CORN);
					return InputManager.GetDone(playerController);
				} else if(captain.ship1IndigoShipments > 0 || captain.ship2IndigoShipments > 0 || captain.ship3IndigoShipments > 0 ||
					(playerBoard.indigoBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
					SelectBarrel(UIFrameBarrelIndigo, PlantationType.INDIGO);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(captain.ship1IndigoShipments > 0 || captain.ship2IndigoShipments > 0 || captain.ship3IndigoShipments > 0 ||
					(playerBoard.indigoBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
					SelectBarrel(UIFrameBarrelIndigo, PlantationType.INDIGO);
					return InputManager.GetDone(playerController);
				} else if(captain.ship1CornShipments > 0 || captain.ship2CornShipments > 0 || captain.ship3CornShipments > 0 ||
					(playerBoard.cornBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
					SelectBarrel(UIFrameBarrelCorn, PlantationType.CORN);
					return InputManager.GetDone(playerController);
				} else if(captain.ship1CoffeeShipments > 0 || captain.ship2CoffeeShipments > 0 || captain.ship3CoffeeShipments > 0 ||
					(playerBoard.coffeeBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
					SelectBarrel(UIFrameBarrelCoffee, PlantationType.COFFEE);
					return InputManager.GetDone(playerController);
				} else if(captain.ship1TobaccoShipments > 0 || captain.ship2TobaccoShipments > 0 || captain.ship3TobaccoShipments > 0 ||
					(playerBoard.tobaccoBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
					SelectBarrel(UIFrameBarrelTobacco, PlantationType.TOBACCO);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(selectedBarrel == PlantationType.TOBACCO) { // TOBACCO BARREL
			if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(captain.ship1CoffeeShipments > 0 || captain.ship2CoffeeShipments > 0 || captain.ship3CoffeeShipments > 0 ||
					(playerBoard.coffeeBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
					SelectBarrel(UIFrameBarrelCoffee, PlantationType.COFFEE);
					return InputManager.GetDone(playerController);
				} else if(captain.ship1CornShipments > 0 || captain.ship2CornShipments > 0 || captain.ship3CornShipments > 0 ||
					(playerBoard.cornBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
					SelectBarrel(UIFrameBarrelCorn, PlantationType.CORN);
					return InputManager.GetDone(playerController);
				} else if(captain.ship1IndigoShipments > 0 || captain.ship2IndigoShipments > 0 || captain.ship3IndigoShipments > 0 ||
					(playerBoard.indigoBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
					SelectBarrel(UIFrameBarrelIndigo, PlantationType.INDIGO);
					return InputManager.GetDone(playerController);
				} else if(captain.ship1SugarShipments > 0 || captain.ship2SugarShipments > 0 || captain.ship3SugarShipments > 0 ||
					(playerBoard.sugarBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
					SelectBarrel(UIFrameBarrelSugar, PlantationType.SUGAR);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(captain.ship1SugarShipments > 0 || captain.ship2SugarShipments > 0 || captain.ship3SugarShipments > 0 ||
					(playerBoard.sugarBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
					SelectBarrel(UIFrameBarrelSugar, PlantationType.SUGAR);
					return InputManager.GetDone(playerController);
				} else if(captain.ship1IndigoShipments > 0 || captain.ship2IndigoShipments > 0 || captain.ship3IndigoShipments > 0 ||
					(playerBoard.indigoBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
					SelectBarrel(UIFrameBarrelIndigo, PlantationType.INDIGO);
					return InputManager.GetDone(playerController);
				} else if(captain.ship1CornShipments > 0 || captain.ship2CornShipments > 0 || captain.ship3CornShipments > 0 ||
					(playerBoard.cornBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
					SelectBarrel(UIFrameBarrelCorn, PlantationType.CORN);
					return InputManager.GetDone(playerController);
				} else if(captain.ship1CoffeeShipments > 0 || captain.ship2CoffeeShipments > 0 || captain.ship3CoffeeShipments > 0 ||
					(playerBoard.coffeeBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
					SelectBarrel(UIFrameBarrelCoffee, PlantationType.COFFEE);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(selectedBarrel == PlantationType.COFFEE) { // COFFEE BARREL
			if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(captain.ship1CornShipments > 0 || captain.ship2CornShipments > 0 || captain.ship3CornShipments > 0 ||
					(playerBoard.cornBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
					SelectBarrel(UIFrameBarrelCorn, PlantationType.CORN);
					return InputManager.GetDone(playerController);
				} else if(captain.ship1IndigoShipments > 0 || captain.ship2IndigoShipments > 0 || captain.ship3IndigoShipments > 0 ||
					(playerBoard.indigoBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
					SelectBarrel(UIFrameBarrelIndigo, PlantationType.INDIGO);
					return InputManager.GetDone(playerController);
				} else if(captain.ship1SugarShipments > 0 || captain.ship2SugarShipments > 0 || captain.ship3SugarShipments > 0 ||
					(playerBoard.sugarBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
					SelectBarrel(UIFrameBarrelSugar, PlantationType.SUGAR);
					return InputManager.GetDone(playerController);
				} else if(captain.ship1TobaccoShipments > 0 || captain.ship2TobaccoShipments > 0 || captain.ship3TobaccoShipments > 0 ||
					(playerBoard.tobaccoBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
					SelectBarrel(UIFrameBarrelTobacco, PlantationType.TOBACCO);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(captain.ship1TobaccoShipments > 0 || captain.ship2TobaccoShipments > 0 || captain.ship3TobaccoShipments > 0 ||
					(playerBoard.tobaccoBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
					SelectBarrel(UIFrameBarrelTobacco, PlantationType.TOBACCO);
					return InputManager.GetDone(playerController);
				} else if(captain.ship1SugarShipments > 0 || captain.ship2SugarShipments > 0 || captain.ship3SugarShipments > 0 ||
					(playerBoard.sugarBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
					SelectBarrel(UIFrameBarrelSugar, PlantationType.SUGAR);
					return InputManager.GetDone(playerController);
				} else if(captain.ship1IndigoShipments > 0 || captain.ship2IndigoShipments > 0 || captain.ship3IndigoShipments > 0 ||
					(playerBoard.indigoBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
					SelectBarrel(UIFrameBarrelIndigo, PlantationType.INDIGO);
					return InputManager.GetDone(playerController);
				} else if(captain.ship1CornShipments > 0 || captain.ship2CornShipments > 0 || captain.ship3CornShipments > 0 ||
					(playerBoard.cornBarrels.Count > 0 && captain.activeWharf && !playerBoard.wharfUsed)) {
					SelectBarrel(UIFrameBarrelCorn, PlantationType.CORN);
					return InputManager.GetDone(playerController);
				}
			}
		}
		return InputManager.GetIdle(playerController);
	}

	public void RefreshBarrels(PlayerBoard playerBoard) {
		UICornBarrel.text = playerBoard.cornBarrels.Count.ToString();
		UIIndigoBarrel.text = playerBoard.indigoBarrels.Count.ToString();
		UISugarBarrel.text = playerBoard.sugarBarrels.Count.ToString();
		UITobaccoBarrel.text = playerBoard.tobaccoBarrels.Count.ToString();
		UICoffeeBarrel.text = playerBoard.coffeeBarrels.Count.ToString();
	}

	public void SelectFirstSpoilAvailable(PlayerBoard playerBoard) {
		// CORN
		if(playerBoard.cornBarrels.Count > 0) {
			SelectBarrelSpoil(UIFrameBarrelCornSpoil, PlantationType.CORN);
		// INDIGO
		} else if(playerBoard.indigoBarrels.Count > 0) {
			SelectBarrelSpoil(UIFrameBarrelIndigoSpoil, PlantationType.INDIGO);
		// SUGAR
		} else if(playerBoard.sugarBarrels.Count > 0) {
			SelectBarrelSpoil(UIFrameBarrelSugarSpoil, PlantationType.SUGAR);
		// TOBACCO
		} else if(playerBoard.tobaccoBarrels.Count > 0) {
			SelectBarrelSpoil(UIFrameBarrelTobaccoSpoil, PlantationType.TOBACCO);
		// COFFEE
		} else if(playerBoard.coffeeBarrels.Count > 0) {
			SelectBarrelSpoil(UIFrameBarrelCoffeeSpoil, PlantationType.COFFEE);
		}
	}
	
	public InputType MoveCursorSpoil(InputType inputX, InputType inputY, int playerController, PlayerBoard playerBoard) {
		if(selectedBarrel == PlantationType.CORN) { // CORN BARREL
			if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(playerBoard.indigoBarrels.Count > 0) {
					SelectBarrelSpoil(UIFrameBarrelIndigoSpoil, PlantationType.INDIGO);
					return InputManager.GetDone(playerController);
				} else if(playerBoard.sugarBarrels.Count > 0) {
					SelectBarrelSpoil(UIFrameBarrelSugarSpoil, PlantationType.SUGAR);
					return InputManager.GetDone(playerController);
				} else if(playerBoard.tobaccoBarrels.Count > 0) {
					SelectBarrelSpoil(UIFrameBarrelTobaccoSpoil, PlantationType.TOBACCO);
					return InputManager.GetDone(playerController);
				} else if(playerBoard.coffeeBarrels.Count > 0) {
					SelectBarrelSpoil(UIFrameBarrelCoffeeSpoil, PlantationType.COFFEE);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(playerBoard.coffeeBarrels.Count > 0) {
					SelectBarrelSpoil(UIFrameBarrelCoffeeSpoil, PlantationType.COFFEE);
					return InputManager.GetDone(playerController);
				} else if(playerBoard.tobaccoBarrels.Count > 0) {
					SelectBarrelSpoil(UIFrameBarrelTobaccoSpoil, PlantationType.TOBACCO);
					return InputManager.GetDone(playerController);
				} else if(playerBoard.sugarBarrels.Count > 0) {
					SelectBarrelSpoil(UIFrameBarrelSugarSpoil, PlantationType.SUGAR);
					return InputManager.GetDone(playerController);
				} else if(playerBoard.indigoBarrels.Count > 0) {
					SelectBarrelSpoil(UIFrameBarrelIndigoSpoil, PlantationType.INDIGO);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(selectedBarrel == PlantationType.INDIGO) { // INDIGO BARREL
			if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(playerBoard.sugarBarrels.Count > 0) {
					SelectBarrelSpoil(UIFrameBarrelSugarSpoil, PlantationType.SUGAR);
					return InputManager.GetDone(playerController);
				} else if(playerBoard.tobaccoBarrels.Count > 0) {
					SelectBarrelSpoil(UIFrameBarrelTobaccoSpoil, PlantationType.TOBACCO);
					return InputManager.GetDone(playerController);
				} else if(playerBoard.coffeeBarrels.Count > 0) {
					SelectBarrelSpoil(UIFrameBarrelCoffeeSpoil, PlantationType.COFFEE);
					return InputManager.GetDone(playerController);
				} else if(playerBoard.cornBarrels.Count > 0) {
					SelectBarrelSpoil(UIFrameBarrelCornSpoil, PlantationType.CORN);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(playerBoard.cornBarrels.Count > 0) {
					SelectBarrelSpoil(UIFrameBarrelCornSpoil, PlantationType.CORN);
					return InputManager.GetDone(playerController);
				} else if(playerBoard.coffeeBarrels.Count > 0) {
					SelectBarrelSpoil(UIFrameBarrelCoffeeSpoil, PlantationType.COFFEE);
					return InputManager.GetDone(playerController);
				} else if(playerBoard.tobaccoBarrels.Count > 0) {
					SelectBarrelSpoil(UIFrameBarrelTobaccoSpoil, PlantationType.TOBACCO);
					return InputManager.GetDone(playerController);
				} else if(playerBoard.sugarBarrels.Count > 0) {
					SelectBarrelSpoil(UIFrameBarrelSugarSpoil, PlantationType.SUGAR);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(selectedBarrel == PlantationType.SUGAR) { // SUGAR BARREL
			if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(playerBoard.tobaccoBarrels.Count > 0) {
					SelectBarrelSpoil(UIFrameBarrelTobaccoSpoil, PlantationType.TOBACCO);
					return InputManager.GetDone(playerController);
				} else if(playerBoard.coffeeBarrels.Count > 0) {
					SelectBarrelSpoil(UIFrameBarrelCoffeeSpoil, PlantationType.COFFEE);
					return InputManager.GetDone(playerController);
				} else if(playerBoard.cornBarrels.Count > 0) {
					SelectBarrelSpoil(UIFrameBarrelCornSpoil, PlantationType.CORN);
					return InputManager.GetDone(playerController);
				} else if(playerBoard.indigoBarrels.Count > 0) {
					SelectBarrelSpoil(UIFrameBarrelIndigoSpoil, PlantationType.INDIGO);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(playerBoard.indigoBarrels.Count > 0) {
					SelectBarrelSpoil(UIFrameBarrelIndigoSpoil, PlantationType.INDIGO);
					return InputManager.GetDone(playerController);
				} else if(playerBoard.cornBarrels.Count > 0) {
					SelectBarrelSpoil(UIFrameBarrelCornSpoil, PlantationType.CORN);
					return InputManager.GetDone(playerController);
				} else if(playerBoard.coffeeBarrels.Count > 0) {
					SelectBarrelSpoil(UIFrameBarrelCoffeeSpoil, PlantationType.COFFEE);
					return InputManager.GetDone(playerController);
				} else if(playerBoard.tobaccoBarrels.Count > 0) {
					SelectBarrelSpoil(UIFrameBarrelTobaccoSpoil, PlantationType.TOBACCO);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(selectedBarrel == PlantationType.TOBACCO) { // TOBACCO BARREL
			if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(playerBoard.coffeeBarrels.Count > 0) {
					SelectBarrelSpoil(UIFrameBarrelCoffeeSpoil, PlantationType.COFFEE);
					return InputManager.GetDone(playerController);
				} else if(playerBoard.cornBarrels.Count > 0) {
					SelectBarrelSpoil(UIFrameBarrelCornSpoil, PlantationType.CORN);
					return InputManager.GetDone(playerController);
				} else if(playerBoard.indigoBarrels.Count > 0) {
					SelectBarrelSpoil(UIFrameBarrelIndigoSpoil, PlantationType.INDIGO);
					return InputManager.GetDone(playerController);
				} else if(playerBoard.sugarBarrels.Count > 0) {
					SelectBarrelSpoil(UIFrameBarrelSugarSpoil, PlantationType.SUGAR);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(playerBoard.sugarBarrels.Count > 0) {
					SelectBarrelSpoil(UIFrameBarrelSugarSpoil, PlantationType.SUGAR);
					return InputManager.GetDone(playerController);
				} else if(playerBoard.indigoBarrels.Count > 0) {
					SelectBarrelSpoil(UIFrameBarrelIndigoSpoil, PlantationType.INDIGO);
					return InputManager.GetDone(playerController);
				} else if(playerBoard.cornBarrels.Count > 0) {
					SelectBarrelSpoil(UIFrameBarrelCornSpoil, PlantationType.CORN);
					return InputManager.GetDone(playerController);
				} else if(playerBoard.coffeeBarrels.Count > 0) {
					SelectBarrelSpoil(UIFrameBarrelCoffeeSpoil, PlantationType.COFFEE);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(selectedBarrel == PlantationType.COFFEE) { // COFFEE BARREL
			if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(playerBoard.cornBarrels.Count > 0) {
					SelectBarrelSpoil(UIFrameBarrelCornSpoil, PlantationType.CORN);
					return InputManager.GetDone(playerController);
				} else if(playerBoard.indigoBarrels.Count > 0) {
					SelectBarrelSpoil(UIFrameBarrelIndigoSpoil, PlantationType.INDIGO);
					return InputManager.GetDone(playerController);
				} else if(playerBoard.sugarBarrels.Count > 0) {
					SelectBarrelSpoil(UIFrameBarrelSugarSpoil, PlantationType.SUGAR);
					return InputManager.GetDone(playerController);
				} else if(playerBoard.tobaccoBarrels.Count > 0) {
					SelectBarrelSpoil(UIFrameBarrelTobaccoSpoil, PlantationType.TOBACCO);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(playerBoard.tobaccoBarrels.Count > 0) {
					SelectBarrelSpoil(UIFrameBarrelTobaccoSpoil, PlantationType.TOBACCO);
					return InputManager.GetDone(playerController);
				} else if(playerBoard.sugarBarrels.Count > 0) {
					SelectBarrelSpoil(UIFrameBarrelSugarSpoil, PlantationType.SUGAR);
					return InputManager.GetDone(playerController);
				} else if(playerBoard.indigoBarrels.Count > 0) {
					SelectBarrelSpoil(UIFrameBarrelIndigoSpoil, PlantationType.INDIGO);
					return InputManager.GetDone(playerController);
				} else if(playerBoard.cornBarrels.Count > 0) {
					SelectBarrelSpoil(UIFrameBarrelCornSpoil, PlantationType.CORN);
					return InputManager.GetDone(playerController);
				}
			}
		}
		return InputManager.GetIdle(playerController);
	}
	
	void SelectBarrelSpoil(GameObject UIFrame, PlantationType type) {
		DeselectFramesBarrelsSpoil();

		UIFrame.GetComponent<Image>().sprite = UIBarrelFrameSpoil;
		selectedBarrel = type;

		Debug.Log("GameObject seleccionado: " + selectedBarrel);
	}

	public void ActivateSpoilFrames(bool activate) {
		if(activate) {
			UIFrameBarrelCornSpoil.SetActive(true);
			UIFrameBarrelIndigoSpoil.SetActive(true);
			UIFrameBarrelSugarSpoil.SetActive(true);
			UIFrameBarrelTobaccoSpoil.SetActive(true);
			UIFrameBarrelCoffeeSpoil.SetActive(true);
		} else {
			UIFrameBarrelCornSpoil.SetActive(false);
			UIFrameBarrelIndigoSpoil.SetActive(false);
			UIFrameBarrelSugarSpoil.SetActive(false);
			UIFrameBarrelTobaccoSpoil.SetActive(false);
			UIFrameBarrelCoffeeSpoil.SetActive(false);
		}
	}

	// ======
	// TRADER
	// ======

	public void SelectFirstSlotAvailableTrader(PlayerBoard playerBoard, bool activeOffice) {
		DeselectFramesBarrels();
		// Si tiene Barriles AND (Si tiene la oficina activa OR no hay esa mercancía ya en el mercado)
		if(playerBoard.cornBarrels.Count > 0
			&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.CORN) == null)) {
			UIFrameBarrelCorn.GetComponent<Image>().sprite = UIBarrelFrame;
			selectedBarrel = PlantationType.CORN;
		} else if(playerBoard.indigoBarrels.Count > 0
			&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.INDIGO) == null)) {
			UIFrameBarrelIndigo.GetComponent<Image>().sprite = UIBarrelFrame;
			selectedBarrel = PlantationType.INDIGO;
		} else if(playerBoard.sugarBarrels.Count > 0
			&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.SUGAR) == null)) {
			UIFrameBarrelSugar.GetComponent<Image>().sprite = UIBarrelFrame;
			selectedBarrel = PlantationType.SUGAR;
		} else if(playerBoard.tobaccoBarrels.Count > 0
			&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.TOBACCO) == null)) {
			UIFrameBarrelTobacco.GetComponent<Image>().sprite = UIBarrelFrame;
			selectedBarrel = PlantationType.TOBACCO;
		} else if(playerBoard.coffeeBarrels.Count > 0
			&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.COFFEE) == null)) {
			UIFrameBarrelCoffee.GetComponent<Image>().sprite = UIBarrelFrame;
			selectedBarrel = PlantationType.COFFEE;
		}
	}

	public InputType MoveCursorTrader(InputType inputX, InputType inputY, int playerController, PlayerBoard tablero, bool activeOffice) {
		if(selectedBarrel == PlantationType.CORN) { // CORN BARREL
			if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(tablero.indigoBarrels.Count > 0
					&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.INDIGO) == null)) {
					SelectBarrel(UIFrameBarrelIndigo, PlantationType.INDIGO);
					return InputManager.GetDone(playerController);
				} else if(tablero.sugarBarrels.Count > 0
					&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.SUGAR) == null)) {
					SelectBarrel(UIFrameBarrelSugar, PlantationType.SUGAR);
					return InputManager.GetDone(playerController);
				} else if(tablero.tobaccoBarrels.Count > 0
					&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.TOBACCO) == null)) {
					SelectBarrel(UIFrameBarrelTobacco, PlantationType.TOBACCO);
					return InputManager.GetDone(playerController);
				} else if(tablero.coffeeBarrels.Count > 0
					&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.COFFEE) == null)) {
					SelectBarrel(UIFrameBarrelCoffee, PlantationType.COFFEE);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(tablero.coffeeBarrels.Count > 0
					&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.COFFEE) == null)) {
					SelectBarrel(UIFrameBarrelCoffee, PlantationType.COFFEE);
					return InputManager.GetDone(playerController);
				} else if(tablero.tobaccoBarrels.Count > 0
					&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.TOBACCO) == null)) {
					SelectBarrel(UIFrameBarrelTobacco, PlantationType.TOBACCO);
					return InputManager.GetDone(playerController);
				} else if(tablero.sugarBarrels.Count > 0
					&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.SUGAR) == null)) {
					SelectBarrel(UIFrameBarrelSugar, PlantationType.SUGAR);
					return InputManager.GetDone(playerController);
				} else if(tablero.indigoBarrels.Count > 0
					&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.INDIGO) == null)) {
					SelectBarrel(UIFrameBarrelIndigo, PlantationType.INDIGO);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(selectedBarrel == PlantationType.INDIGO) { // INDIGO BARREL
			if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(tablero.sugarBarrels.Count > 0
					&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.SUGAR) == null)) {
					SelectBarrel(UIFrameBarrelSugar, PlantationType.SUGAR);
					return InputManager.GetDone(playerController);
				} else if(tablero.tobaccoBarrels.Count > 0
					&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.TOBACCO) == null)) {
					SelectBarrel(UIFrameBarrelTobacco, PlantationType.TOBACCO);
					return InputManager.GetDone(playerController);
				} else if(tablero.coffeeBarrels.Count > 0
					&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.COFFEE) == null)) {
					SelectBarrel(UIFrameBarrelCoffee, PlantationType.COFFEE);
					return InputManager.GetDone(playerController);
				} else if(tablero.cornBarrels.Count > 0
					&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.CORN) == null)) {
					SelectBarrel(UIFrameBarrelCorn, PlantationType.CORN);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(tablero.cornBarrels.Count > 0
					&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.CORN) == null)) {
					SelectBarrel(UIFrameBarrelCorn, PlantationType.CORN);
					return InputManager.GetDone(playerController);
				} else if(tablero.coffeeBarrels.Count > 0
					&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.COFFEE) == null)) {
					SelectBarrel(UIFrameBarrelCoffee, PlantationType.COFFEE);
					return InputManager.GetDone(playerController);
				} else if(tablero.tobaccoBarrels.Count > 0
					&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.TOBACCO) == null)) {
					SelectBarrel(UIFrameBarrelTobacco, PlantationType.TOBACCO);
					return InputManager.GetDone(playerController);
				} else if(tablero.sugarBarrels.Count > 0
					&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.SUGAR) == null)) {
					SelectBarrel(UIFrameBarrelSugar, PlantationType.SUGAR);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(selectedBarrel == PlantationType.SUGAR) { // SUGAR BARREL
			if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(tablero.tobaccoBarrels.Count > 0
					&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.TOBACCO) == null)) {
					SelectBarrel(UIFrameBarrelTobacco, PlantationType.TOBACCO);
					return InputManager.GetDone(playerController);
				} else if(tablero.coffeeBarrels.Count > 0
					&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.COFFEE) == null)) {
					SelectBarrel(UIFrameBarrelCoffee, PlantationType.COFFEE);
					return InputManager.GetDone(playerController);
				} else if(tablero.cornBarrels.Count > 0
					&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.CORN) == null)) {
					SelectBarrel(UIFrameBarrelCorn, PlantationType.CORN);
					return InputManager.GetDone(playerController);
				} else if(tablero.indigoBarrels.Count > 0
					&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.INDIGO) == null)) {
					SelectBarrel(UIFrameBarrelIndigo, PlantationType.INDIGO);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(tablero.indigoBarrels.Count > 0
					&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.INDIGO) == null)) {
					SelectBarrel(UIFrameBarrelIndigo, PlantationType.INDIGO);
					return InputManager.GetDone(playerController);
				} else if(tablero.cornBarrels.Count > 0
					&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.CORN) == null)) {
					SelectBarrel(UIFrameBarrelCorn, PlantationType.CORN);
					return InputManager.GetDone(playerController);
				} else if(tablero.coffeeBarrels.Count > 0
					&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.COFFEE) == null)) {
					SelectBarrel(UIFrameBarrelCoffee, PlantationType.COFFEE);
					return InputManager.GetDone(playerController);
				} else if(tablero.tobaccoBarrels.Count > 0
					&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.TOBACCO) == null)) {
					SelectBarrel(UIFrameBarrelTobacco, PlantationType.TOBACCO);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(selectedBarrel == PlantationType.TOBACCO) { // TOBACCO BARREL
			if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(tablero.coffeeBarrels.Count > 0
					&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.COFFEE) == null)) {
					SelectBarrel(UIFrameBarrelCoffee, PlantationType.COFFEE);
					return InputManager.GetDone(playerController);
				} else if(tablero.cornBarrels.Count > 0
					&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.CORN) == null)) {
					SelectBarrel(UIFrameBarrelCorn, PlantationType.CORN);
					return InputManager.GetDone(playerController);
				} else if(tablero.indigoBarrels.Count > 0
					&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.INDIGO) == null)) {
					SelectBarrel(UIFrameBarrelIndigo, PlantationType.INDIGO);
					return InputManager.GetDone(playerController);
				} else if(tablero.sugarBarrels.Count > 0
					&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.SUGAR) == null)) {
					SelectBarrel(UIFrameBarrelSugar, PlantationType.SUGAR);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(tablero.sugarBarrels.Count > 0
					&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.SUGAR) == null)) {
					SelectBarrel(UIFrameBarrelSugar, PlantationType.SUGAR);
					return InputManager.GetDone(playerController);
				} else if(tablero.indigoBarrels.Count > 0
					&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.INDIGO) == null)) {
					SelectBarrel(UIFrameBarrelIndigo, PlantationType.INDIGO);
					return InputManager.GetDone(playerController);
				} else if(tablero.cornBarrels.Count > 0
					&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.CORN) == null)) {
					SelectBarrel(UIFrameBarrelCorn, PlantationType.CORN);
					return InputManager.GetDone(playerController);
				} else if(tablero.coffeeBarrels.Count > 0
					&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.COFFEE) == null)) {
					SelectBarrel(UIFrameBarrelCoffee, PlantationType.COFFEE);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(selectedBarrel == PlantationType.COFFEE) { // COFFEE BARREL
			if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(tablero.cornBarrels.Count > 0
					&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.CORN) == null)) {
					SelectBarrel(UIFrameBarrelCorn, PlantationType.CORN);
					return InputManager.GetDone(playerController);
				} else if(tablero.indigoBarrels.Count > 0
					&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.INDIGO) == null)) {
					SelectBarrel(UIFrameBarrelIndigo, PlantationType.INDIGO);
					return InputManager.GetDone(playerController);
				} else if(tablero.sugarBarrels.Count > 0
					&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.SUGAR) == null)) {
					SelectBarrel(UIFrameBarrelSugar, PlantationType.SUGAR);
					return InputManager.GetDone(playerController);
				} else if(tablero.tobaccoBarrels.Count > 0
					&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.TOBACCO) == null)) {
					SelectBarrel(UIFrameBarrelTobacco, PlantationType.TOBACCO);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(tablero.tobaccoBarrels.Count > 0
					&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.TOBACCO) == null)) {
					SelectBarrel(UIFrameBarrelTobacco, PlantationType.TOBACCO);
					return InputManager.GetDone(playerController);
				} else if(tablero.sugarBarrels.Count > 0
					&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.SUGAR) == null)) {
					SelectBarrel(UIFrameBarrelSugar, PlantationType.SUGAR);
					return InputManager.GetDone(playerController);
				} else if(tablero.indigoBarrels.Count > 0
					&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.INDIGO) == null)) {
					SelectBarrel(UIFrameBarrelIndigo, PlantationType.INDIGO);
					return InputManager.GetDone(playerController);
				} else if(tablero.cornBarrels.Count > 0
					&& (activeOffice || GameData.barrilesVentas.Find(i => i.type == PlantationType.CORN) == null)) {
					SelectBarrel(UIFrameBarrelCorn, PlantationType.CORN);
					return InputManager.GetDone(playerController);
				}
			}
		}
		return InputManager.GetIdle(playerController);
	}
	
	void SelectBarrel(GameObject UIFrame, PlantationType type) {
		DeselectFramesBarrels();

		UIFrame.GetComponent<Image>().sprite = UIBarrelFrame;
		selectedBarrel = type;

		Debug.Log("GameObject seleccionado: " + selectedBarrel);
	}

	// =====
	// MAYOR
	// =====

	public void SelectFirstSlotAvailableMayor() {
		DeselectFramesBuildingsPlantations();
		if(UIBuilding1.activeSelf) {
			UIFrameBuilding1.GetComponent<Image>().sprite = UIBuildingFrame;
			mayorGameObjectSelected = UIBuilding1;
			mayorGameObjectType = GameObjectType.BUILDING;
			mayorGameObjectIndex = 0;
		} else if(UIBuilding2.activeSelf) {
			UIFrameBuilding2.GetComponent<Image>().sprite = UIBuildingFrame;
			mayorGameObjectSelected = UIBuilding2;
			mayorGameObjectType = GameObjectType.BUILDING;
			mayorGameObjectIndex = 1;
		} else if(UIBuilding3.activeSelf) {
			UIFrameBuilding3.GetComponent<Image>().sprite = UIBuildingFrame;
			mayorGameObjectSelected = UIBuilding3;
			mayorGameObjectType = GameObjectType.BUILDING;
			mayorGameObjectIndex = 2;
		} else if(UIBuilding4.activeSelf) {
			UIFrameBuilding4.GetComponent<Image>().sprite = UIBuildingFrame;
			mayorGameObjectSelected = UIBuilding4;
			mayorGameObjectType = GameObjectType.BUILDING;
			mayorGameObjectIndex = 3;
		} else if(UIBuilding5.activeSelf) {
			UIFrameBuilding5.GetComponent<Image>().sprite = UIBuildingFrame;
			mayorGameObjectSelected = UIBuilding5;
			mayorGameObjectType = GameObjectType.BUILDING;
			mayorGameObjectIndex = 4;
		} else if(UIBuilding6.activeSelf) {
			UIFrameBuilding6.GetComponent<Image>().sprite = UIBuildingFrame;
			mayorGameObjectSelected = UIBuilding6;
			mayorGameObjectType = GameObjectType.BUILDING;
			mayorGameObjectIndex = 5;
		} else if(UIBuilding7.activeSelf) {
			UIFrameBuilding7.GetComponent<Image>().sprite = UIBuildingFrame;
			mayorGameObjectSelected = UIBuilding7;
			mayorGameObjectType = GameObjectType.BUILDING;
			mayorGameObjectIndex = 6;
		} else if(UIBuilding8.activeSelf) {
			UIFrameBuilding8.GetComponent<Image>().sprite = UIBuildingFrame;
			mayorGameObjectSelected = UIBuilding8;
			mayorGameObjectType = GameObjectType.BUILDING;
			mayorGameObjectIndex = 7;
		} else if(UIBuilding9.activeSelf) {
			UIFrameBuilding9.GetComponent<Image>().sprite = UIBuildingFrame;
			mayorGameObjectSelected = UIBuilding9;
			mayorGameObjectType = GameObjectType.BUILDING;
			mayorGameObjectIndex = 8;
		} else if(UIBuilding10.activeSelf) {
			UIFrameBuilding10.GetComponent<Image>().sprite = UIBuildingFrame;
			mayorGameObjectSelected = UIBuilding10;
			mayorGameObjectType = GameObjectType.BUILDING;
			mayorGameObjectIndex = 9;
		} else if(UIBuilding11.activeSelf) {
			UIFrameBuilding11.GetComponent<Image>().sprite = UIBuildingFrame;
			mayorGameObjectSelected = UIBuilding11;
			mayorGameObjectType = GameObjectType.BUILDING;
			mayorGameObjectIndex = 10;
		} else if(UIBuilding12.activeSelf) {
			UIFrameBuilding12.GetComponent<Image>().sprite = UIBuildingFrame;
			mayorGameObjectSelected = UIBuilding12;
			mayorGameObjectType = GameObjectType.BUILDING;
			mayorGameObjectIndex = 11;
		} else if(UIPlantation1.activeSelf) {
			UIFramePlantation1.GetComponent<Image>().sprite = UIPlantationFrame;
			mayorGameObjectSelected = UIPlantation1;
			mayorGameObjectType = GameObjectType.PLANTATION;
			mayorGameObjectIndex = 0;
		} else if(UIPlantation2.activeSelf) {
			UIFramePlantation2.GetComponent<Image>().sprite = UIPlantationFrame;
			mayorGameObjectSelected = UIPlantation2;
			mayorGameObjectType = GameObjectType.PLANTATION;
			mayorGameObjectIndex = 1;
		} else if(UIPlantation3.activeSelf) {
			UIFramePlantation3.GetComponent<Image>().sprite = UIPlantationFrame;
			mayorGameObjectSelected = UIPlantation3;
			mayorGameObjectType = GameObjectType.PLANTATION;
			mayorGameObjectIndex = 2;
		} else if(UIPlantation4.activeSelf) {
			UIFramePlantation4.GetComponent<Image>().sprite = UIPlantationFrame;
			mayorGameObjectSelected = UIPlantation4;
			mayorGameObjectType = GameObjectType.PLANTATION;
			mayorGameObjectIndex = 3;
		} else if(UIPlantation5.activeSelf) {
			UIFramePlantation5.GetComponent<Image>().sprite = UIPlantationFrame;
			mayorGameObjectSelected = UIPlantation5;
			mayorGameObjectType = GameObjectType.PLANTATION;
			mayorGameObjectIndex = 4;
		} else if(UIPlantation6.activeSelf) {
			UIFramePlantation6.GetComponent<Image>().sprite = UIPlantationFrame;
			mayorGameObjectSelected = UIPlantation6;
			mayorGameObjectType = GameObjectType.PLANTATION;
			mayorGameObjectIndex = 5;
		} else if(UIPlantation7.activeSelf) {
			UIFramePlantation7.GetComponent<Image>().sprite = UIPlantationFrame;
			mayorGameObjectSelected = UIPlantation7;
			mayorGameObjectType = GameObjectType.PLANTATION;
			mayorGameObjectIndex = 6;
		} else if(UIPlantation8.activeSelf) {
			UIFramePlantation8.GetComponent<Image>().sprite = UIPlantationFrame;
			mayorGameObjectSelected = UIPlantation8;
			mayorGameObjectType = GameObjectType.PLANTATION;
			mayorGameObjectIndex = 7;
		} else if(UIPlantation9.activeSelf) {
			UIFramePlantation9.GetComponent<Image>().sprite = UIPlantationFrame;
			mayorGameObjectSelected = UIPlantation9;
			mayorGameObjectType = GameObjectType.PLANTATION;
			mayorGameObjectIndex = 8;
		} else if(UIPlantation10.activeSelf) {
			UIFramePlantation10.GetComponent<Image>().sprite = UIPlantationFrame;
			mayorGameObjectSelected = UIPlantation10;
			mayorGameObjectType = GameObjectType.PLANTATION;
			mayorGameObjectIndex = 9;
		} else if(UIPlantation11.activeSelf) {
			UIFramePlantation11.GetComponent<Image>().sprite = UIPlantationFrame;
			mayorGameObjectSelected = UIPlantation11;
			mayorGameObjectType = GameObjectType.PLANTATION;
			mayorGameObjectIndex = 10;
		} else if(UIPlantation12.activeSelf) {
			UIFramePlantation12.GetComponent<Image>().sprite = UIPlantationFrame;
			mayorGameObjectSelected = UIPlantation12;
			mayorGameObjectType = GameObjectType.PLANTATION;
			mayorGameObjectIndex = 11;
		}
	}

	public InputType MoveCursorMayor(InputType inputX, InputType inputY, int playerController) {
		// =================
		//  EDIFICIOS FILA 1
		// =================
		if(mayorGameObjectSelected == UIBuilding1) { // BUILDING 1
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(mayorGameObjectSelected == UIBuilding2) { // BUILDING 2
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(mayorGameObjectSelected == UIBuilding3) { // BUILDING 3
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(mayorGameObjectSelected == UIBuilding4) { // BUILDING 4
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				}
			}
		// =================
		//  EDIFICIOS FILA 2
		// =================
		} else if(mayorGameObjectSelected == UIBuilding5) { // BUILDING 5
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(mayorGameObjectSelected == UIBuilding6) { // BUILDING 6
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(mayorGameObjectSelected == UIBuilding7) { // BUILDING 7
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(mayorGameObjectSelected == UIBuilding8) { // BUILDING 8
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				}
			}
		// =================
		//  EDIFICIOS FILA 3
		// =================
		} else if(mayorGameObjectSelected == UIBuilding9) { // BUILDING 9
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(mayorGameObjectSelected == UIBuilding10) { // BUILDING 10
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(mayorGameObjectSelected == UIBuilding11) { // BUILDING 11
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(mayorGameObjectSelected == UIBuilding12) { // BUILDING 12
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				}
			}
		// =======================
		//  PLANTACIONES COLUMNA 1
		// =======================
		} else if(mayorGameObjectSelected == UIPlantation1) { // PLANTACION 1
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(mayorGameObjectSelected == UIPlantation2) { // PLANTACION 2
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(mayorGameObjectSelected == UIPlantation3) { // PLANTACION 3
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				}
			}
		// =======================
		//  PLANTACIONES COLUMNA 2
		// =======================
		} else if(mayorGameObjectSelected == UIPlantation4) { // PLANTACION 4
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(mayorGameObjectSelected == UIPlantation5) { // PLANTACION 5
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(mayorGameObjectSelected == UIPlantation6) { // PLANTACION 6
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				}
			}
		// =======================
		//  PLANTACIONES COLUMNA 3
		// =======================
		} else if(mayorGameObjectSelected == UIPlantation7) { // PLANTACION 7
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(mayorGameObjectSelected == UIPlantation8) { // PLANTACION 8
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(mayorGameObjectSelected == UIPlantation9) { // PLANTACION 9
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				}
			}
		// =======================
		//  PLANTACIONES COLUMNA 4
		// =======================
		} else if(mayorGameObjectSelected == UIPlantation10) { // PLANTACION 10
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(mayorGameObjectSelected == UIPlantation11) { // PLANTACION 11
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UIPlantation12.activeSelf) {
					SelectGameObject(UIPlantation12, GameObjectType.PLANTATION, 12, UIFramePlantation12);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				}
			}
		// =======================
		//  PLANTACIONES COLUMNA 5
		// =======================
		} else if(mayorGameObjectSelected == UIPlantation12) { // PLANTACION 12
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UIPlantation2.activeSelf) {
					SelectGameObject(UIPlantation2, GameObjectType.PLANTATION, 2, UIFramePlantation2);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation1.activeSelf) {
					SelectGameObject(UIPlantation1, GameObjectType.PLANTATION, 1, UIFramePlantation1);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation3.activeSelf) {
					SelectGameObject(UIPlantation3, GameObjectType.PLANTATION, 3, UIFramePlantation3);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation5.activeSelf) {
					SelectGameObject(UIPlantation5, GameObjectType.PLANTATION, 5, UIFramePlantation5);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation6.activeSelf) {
					SelectGameObject(UIPlantation6, GameObjectType.PLANTATION, 6, UIFramePlantation6);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation4.activeSelf) {
					SelectGameObject(UIPlantation4, GameObjectType.PLANTATION, 4, UIFramePlantation4);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation8.activeSelf) {
					SelectGameObject(UIPlantation8, GameObjectType.PLANTATION, 8, UIFramePlantation8);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation7.activeSelf) {
					SelectGameObject(UIPlantation7, GameObjectType.PLANTATION, 7, UIFramePlantation7);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation9.activeSelf) {
					SelectGameObject(UIPlantation9, GameObjectType.PLANTATION, 9, UIFramePlantation9);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation10.activeSelf) {
					SelectGameObject(UIPlantation10, GameObjectType.PLANTATION, 10, UIFramePlantation10);
					return InputManager.GetDone(playerController);
				} else if(UIPlantation11.activeSelf) {
					SelectGameObject(UIPlantation11, GameObjectType.PLANTATION, 11, UIFramePlantation11);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIBuilding12.activeSelf) {
					SelectGameObject(UIBuilding12, GameObjectType.BUILDING, 12, UIFrameBuilding12);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding8.activeSelf) {
					SelectGameObject(UIBuilding8, GameObjectType.BUILDING, 8, UIFrameBuilding8);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding4.activeSelf) {
					SelectGameObject(UIBuilding4, GameObjectType.BUILDING, 4, UIFrameBuilding4);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding11.activeSelf) {
					SelectGameObject(UIBuilding11, GameObjectType.BUILDING, 11, UIFrameBuilding11);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding7.activeSelf) {
					SelectGameObject(UIBuilding7, GameObjectType.BUILDING, 7, UIFrameBuilding7);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding3.activeSelf) {
					SelectGameObject(UIBuilding3, GameObjectType.BUILDING, 3, UIFrameBuilding3);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding10.activeSelf) {
					SelectGameObject(UIBuilding10, GameObjectType.BUILDING, 10, UIFrameBuilding10);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding6.activeSelf) {
					SelectGameObject(UIBuilding6, GameObjectType.BUILDING, 6, UIFrameBuilding6);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding2.activeSelf) {
					SelectGameObject(UIBuilding2, GameObjectType.BUILDING, 2, UIFrameBuilding2);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding9.activeSelf) {
					SelectGameObject(UIBuilding9, GameObjectType.BUILDING, 9, UIFrameBuilding9);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding5.activeSelf) {
					SelectGameObject(UIBuilding5, GameObjectType.BUILDING, 5, UIFrameBuilding5);
					return InputManager.GetDone(playerController);
				} else if(UIBuilding1.activeSelf) {
					SelectGameObject(UIBuilding1, GameObjectType.BUILDING, 1, UIFrameBuilding1);
					return InputManager.GetDone(playerController);
				}
			}
		}
		return InputManager.GetIdle(playerController);
	}

	void SelectGameObject(GameObject gameObject, GameObjectType gameObjectType, int index, GameObject UIFrame) {
		DeselectFramesBuildingsPlantations();
		if(gameObjectType == GameObjectType.BUILDING) {
			UIFrame.GetComponent<Image>().sprite = UIBuildingFrame;
			/*
			// Si es un edificio de los grandes, resalta también la otra casilla
			if(gameObject.GetComponent<UIEdificio>().anotherPart != null) {
				gameObject.GetComponent<UIEdificio>().anotherPart.GetComponentInParent<Image>().sprite = UIBuildingFrame;
			}
			*/
		} else if(gameObjectType == GameObjectType.PLANTATION) {
			UIFrame.GetComponent<Image>().sprite = UIPlantationFrame;
		}
		mayorGameObjectSelected = gameObject;
		mayorGameObjectType = gameObjectType;
		mayorGameObjectIndex = index - 1; // Lo hago así porque se hace menos lioso el código de MoveCursor
		Debug.Log("GameObject seleccionado: " + mayorGameObjectSelected);
	}

	public void DeselectFramesBuildingsPlantations() {
		UIFrameBuilding1.GetComponent<Image>().sprite = UIBuildingFrameTransparent;
		UIFrameBuilding2.GetComponent<Image>().sprite = UIBuildingFrameTransparent;
		UIFrameBuilding3.GetComponent<Image>().sprite = UIBuildingFrameTransparent;
		UIFrameBuilding4.GetComponent<Image>().sprite = UIBuildingFrameTransparent;
		UIFrameBuilding5.GetComponent<Image>().sprite = UIBuildingFrameTransparent;
		UIFrameBuilding6.GetComponent<Image>().sprite = UIBuildingFrameTransparent;
		UIFrameBuilding7.GetComponent<Image>().sprite = UIBuildingFrameTransparent;
		UIFrameBuilding8.GetComponent<Image>().sprite = UIBuildingFrameTransparent;
		UIFrameBuilding9.GetComponent<Image>().sprite = UIBuildingFrameTransparent;
		UIFrameBuilding10.GetComponent<Image>().sprite = UIBuildingFrameTransparent;
		UIFrameBuilding11.GetComponent<Image>().sprite = UIBuildingFrameTransparent;
		UIFrameBuilding12.GetComponent<Image>().sprite = UIBuildingFrameTransparent;

		UIFramePlantation1.GetComponent<Image>().sprite = UIPlantationFrameTransparent;
		UIFramePlantation2.GetComponent<Image>().sprite = UIPlantationFrameTransparent;
		UIFramePlantation3.GetComponent<Image>().sprite = UIPlantationFrameTransparent;
		UIFramePlantation4.GetComponent<Image>().sprite = UIPlantationFrameTransparent;
		UIFramePlantation5.GetComponent<Image>().sprite = UIPlantationFrameTransparent;
		UIFramePlantation6.GetComponent<Image>().sprite = UIPlantationFrameTransparent;
		UIFramePlantation7.GetComponent<Image>().sprite = UIPlantationFrameTransparent;
		UIFramePlantation8.GetComponent<Image>().sprite = UIPlantationFrameTransparent;
		UIFramePlantation9.GetComponent<Image>().sprite = UIPlantationFrameTransparent;
		UIFramePlantation10.GetComponent<Image>().sprite = UIPlantationFrameTransparent;
		UIFramePlantation11.GetComponent<Image>().sprite = UIPlantationFrameTransparent;
		UIFramePlantation12.GetComponent<Image>().sprite = UIPlantationFrameTransparent;
	}

	public void DeselectFramesBarrels() {
		UIFrameBarrelCorn.GetComponent<Image>().sprite = UIBarrelFrameTransparent;
		UIFrameBarrelIndigo.GetComponent<Image>().sprite = UIBarrelFrameTransparent;
		UIFrameBarrelSugar.GetComponent<Image>().sprite = UIBarrelFrameTransparent;
		UIFrameBarrelTobacco.GetComponent<Image>().sprite = UIBarrelFrameTransparent;
		UIFrameBarrelCoffee.GetComponent<Image>().sprite = UIBarrelFrameTransparent;
	}

	public void DeselectFramesBarrelsSpoil() {
		UIFrameBarrelCornSpoil.GetComponent<Image>().sprite = UIBarrelFrameTransparent;
		UIFrameBarrelIndigoSpoil.GetComponent<Image>().sprite = UIBarrelFrameTransparent;
		UIFrameBarrelSugarSpoil.GetComponent<Image>().sprite = UIBarrelFrameTransparent;
		UIFrameBarrelTobaccoSpoil.GetComponent<Image>().sprite = UIBarrelFrameTransparent;
		UIFrameBarrelCoffeeSpoil.GetComponent<Image>().sprite = UIBarrelFrameTransparent;
	}

}