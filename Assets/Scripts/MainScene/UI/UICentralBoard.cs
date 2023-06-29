using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICentralBoard : MonoBehaviour {

	public Text UICoins;

	public GameObject UISmallIndigoPlant;
	public GameObject UISmallSugarMill;
	public GameObject UISmallMarket;
	public GameObject UIHacienda;
	public GameObject UIConstructionHut;
	public GameObject UISmallWarehouse;
	public GameObject UIIndigoPlant;
	public GameObject UISugarMill;
	public GameObject UIHospice;
	public GameObject UIOffice;
	public GameObject UILargeMarket;
	public GameObject UILargeWarehouse;
	public GameObject UITobaccoStorage;
	public GameObject UICoffeeToaster;
	public GameObject UIFactory;
	public GameObject UIUniversity;
	public GameObject UIHarbor;
	public GameObject UIWharf;
	public GameObject UIGuildHall;
	public GameObject UIResidence;
	public GameObject UIFortress;
	public GameObject UICustomsHouse;
	public GameObject UICityHall;

	public GameObject UIFrameSmallIndigoPlant;
	public GameObject UIFrameSmallSugarMill;
	public GameObject UIFrameSmallMarket;
	public GameObject UIFrameHacienda;
	public GameObject UIFrameConstructionHut;
	public GameObject UIFrameSmallWarehouse;
	public GameObject UIFrameIndigoPlant;
	public GameObject UIFrameSugarMill;
	public GameObject UIFrameHospice;
	public GameObject UIFrameOffice;
	public GameObject UIFrameLargeMarket;
	public GameObject UIFrameLargeWarehouse;
	public GameObject UIFrameTobaccoStorage;
	public GameObject UIFrameCoffeeToaster;
	public GameObject UIFrameFactory;
	public GameObject UIFrameUniversity;
	public GameObject UIFrameHarbor;
	public GameObject UIFrameWharf;
	public GameObject UIFrameGuildHall;
	public GameObject UIFrameResidence;
	public GameObject UIFrameFortress;
	public GameObject UIFrameCustomsHouse;
	public GameObject UIFrameCityHall;

	public Sprite UIBuildingFrame;
	public Sprite UIBuildingFrameTransparent;
	public Sprite UILargeBuildingFrame;
	public Sprite UILargeBuildingFrameTransparent;

	public BuildingType buildingSelected { get; set; }

	// Use this for initialization
	void Start () {
		UICoins.text = "66";
		DeselectFrameBuildings();
	}

	public void SelectFirstBuildingAvailable() {
		DeselectFrameBuildings();
		if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
			UIFrameSmallIndigoPlant.GetComponent<Image>().sprite = UIBuildingFrame;
			buildingSelected = BuildingType.SMALL_INDIGO_PLANT;
		} else if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
			UIFrameSmallSugarMill.GetComponent<Image>().sprite = UIBuildingFrame;
			buildingSelected = BuildingType.SMALL_SUGAR_MILL;
		} else if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
			UIFrameSmallMarket.GetComponent<Image>().sprite = UIBuildingFrame;
			buildingSelected = BuildingType.SMALL_MARKET;
		} else if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
			UIFrameHacienda.GetComponent<Image>().sprite = UIBuildingFrame;
			buildingSelected = BuildingType.HACIENDA;
		} else if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
			UIFrameConstructionHut.GetComponent<Image>().sprite = UIBuildingFrame;
			buildingSelected = BuildingType.CONSTRUCTION_HUT;
		} else if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
			UIFrameSmallWarehouse.GetComponent<Image>().sprite = UIBuildingFrame;
			buildingSelected = BuildingType.SMALL_WAREHOUSE;
		} else if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
			UIFrameIndigoPlant.GetComponent<Image>().sprite = UIBuildingFrame;
			buildingSelected = BuildingType.INDIGO_PLANT;
		} else if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
			UIFrameSugarMill.GetComponent<Image>().sprite = UIBuildingFrame;
			buildingSelected = BuildingType.SUGAR_MILL;
		} else if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
			UIFrameHospice.GetComponent<Image>().sprite = UIBuildingFrame;
			buildingSelected = BuildingType.HOSPICE;
		} else if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
			UIFrameOffice.GetComponent<Image>().sprite = UIBuildingFrame;
			buildingSelected = BuildingType.OFFICE;
		} else if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
			UIFrameLargeMarket.GetComponent<Image>().sprite = UIBuildingFrame;
			buildingSelected = BuildingType.LARGE_MARKET;
		} else if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
			UIFrameLargeWarehouse.GetComponent<Image>().sprite = UIBuildingFrame;
			buildingSelected = BuildingType.LARGE_WAREHOUSE;
		} else if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
			UIFrameTobaccoStorage.GetComponent<Image>().sprite = UIBuildingFrame;
			buildingSelected = BuildingType.TOBACCO_STORAGE;
		} else if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
			UIFrameCoffeeToaster.GetComponent<Image>().sprite = UIBuildingFrame;
			buildingSelected = BuildingType.COFFEE_TOASTER;
		} else if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
			UIFrameFactory.GetComponent<Image>().sprite = UIBuildingFrame;
			buildingSelected = BuildingType.FACTORY;
		} else if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
			UIFrameUniversity.GetComponent<Image>().sprite = UIBuildingFrame;
			buildingSelected = BuildingType.UNIVERSITY;
		} else if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
			UIFrameHarbor.GetComponent<Image>().sprite = UIBuildingFrame;
			buildingSelected = BuildingType.HARBOR;
		} else if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
			UIFrameWharf.GetComponent<Image>().sprite = UIBuildingFrame;
			buildingSelected = BuildingType.WHARF;
		} else if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
			UIFrameGuildHall.GetComponent<Image>().sprite = UIBuildingFrame;
			buildingSelected = BuildingType.GUILD_HALL;
		} else if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
			UIFrameResidence.GetComponent<Image>().sprite = UIBuildingFrame;
			buildingSelected = BuildingType.RESIDENCE;
		} else if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
			UIFrameFortress.GetComponent<Image>().sprite = UIBuildingFrame;
			buildingSelected = BuildingType.FORTRESS;
		} else if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
			UIFrameCustomsHouse.GetComponent<Image>().sprite = UIBuildingFrame;
			buildingSelected = BuildingType.CUSTOMS_HOUSE;
		} else if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
			UIFrameCityHall.GetComponent<Image>().sprite = UIBuildingFrame;
			buildingSelected = BuildingType.CITY_HALL;
		}
	}
	
	public InputType MoveCursor(InputType inputX, InputType inputY, int playerController) {
		// =========
		// COLUMNA 1
		// =========
		if(buildingSelected == BuildingType.SMALL_INDIGO_PLANT) { // SMALL_INDIGO_PLANT
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				} else if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				} else if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				} else if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				} else if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				} else if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				} else if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				} else if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				} else if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				} else if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				} else if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				} else if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				} else if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				} else if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				} else if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				} else if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				} else if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				} else if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				} else if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				} else if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				} else if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				} else if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				} else if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				} else if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				} else if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				} else if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				} else if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				} else if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				} else if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				} else if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				} else if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				} else if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				} else if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				} else if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(buildingSelected == BuildingType.SMALL_SUGAR_MILL) { // SMALL_SUGAR_MILL
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				} else if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				} else if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				} else if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				} else if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				} else if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				} else if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				} else if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				} else if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				} else if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				} else if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				} else if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				} else if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				} else if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				} else if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				} else if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				} else if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				} else if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				} else if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				} else if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				} else if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				} else if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				} else if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				} else if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				} else if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				} else if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				} else if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				} else if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				} else if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				} else if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				} else if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				} else if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				} else if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(buildingSelected == BuildingType.SMALL_MARKET) { // SMALL_MARKET
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				} else if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				} else if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				} else if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				} else if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				} else if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				} else if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				} else if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				} else if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				} else if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				} else if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				} else if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				} else if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				} else if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				} else if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				} else if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				} else if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				} else if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				} else if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				} else if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				} else if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				} else if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				} else if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				} else if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				} else if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				} else if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				} else if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				} else if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				} else if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				} else if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				} else if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(buildingSelected == BuildingType.HACIENDA) { // HACIENDA
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				} else if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				} else if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				} else if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				} else if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				} else if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				} else if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				} else if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				} else if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				} else if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				} else if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				} else if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				} else if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				} else if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				} else if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				} else if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				} else if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				} else if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				} else if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				} else if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				} else if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				} else if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				} else if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				} else if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				} else if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				} else if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				} else if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				} else if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				} else if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				} else if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(buildingSelected == BuildingType.CONSTRUCTION_HUT) { // CONSTRUCTION_HUT
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				} else if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				} else if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				} else if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				} else if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				} else if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				} else if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				} else if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				} else if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				} else if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				} else if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				} else if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				} else if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				} else if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				} else if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				} else if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				} else if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				} else if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				} else if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				} else if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				} else if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				} else if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				} else if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				} else if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				} else if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				} else if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				} else if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				} else if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				} else if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				} else if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				} else if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(buildingSelected == BuildingType.SMALL_WAREHOUSE) { // SMALL_WAREHOUSE
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				} else if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				} else if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				} else if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				} else if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				} else if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				} else if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				} else if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				} else if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				} else if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				} else if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				} else if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				} else if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				} else if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				} else if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				} else if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				} else if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				} else if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				} else if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				} else if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				} else if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				} else if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				} else if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				} else if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				} else if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				} else if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				} else if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				} else if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				} else if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				} else if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				} else if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				} else if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				} else if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				}
			}
		// =========
		// COLUMNA 2
		// =========
		} else if(buildingSelected == BuildingType.INDIGO_PLANT) { // INDIGO_PLANT
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				} else if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				} else if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				} else if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				} else if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				} else if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				} else if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				} else if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				} else if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				} else if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				} else if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				} else if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				} else if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				} else if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				} else if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				} else if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				} else if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				} else if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				} else if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				} else if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				} else if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				} else if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				} else if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				} else if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				} else if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				} else if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				} else if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				} else if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				} else if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				} else if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				} else if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				} else if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				} else if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				} else if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(buildingSelected == BuildingType.SUGAR_MILL) { // SUGAR_MILL
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				} else if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				} else if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				} else if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				} else if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				} else if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				} else if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				} else if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				} else if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				} else if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				} else if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				} else if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				} else if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				} else if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				} else if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				} else if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				} else if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				} else if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				} else if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				} else if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				} else if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				} else if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				} else if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				} else if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				} else if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				} else if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				} else if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				} else if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				} else if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				} else if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				} else if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				} else if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				} else if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(buildingSelected == BuildingType.HOSPICE) { // HOSPICE
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				} else if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				} else if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				} else if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				} else if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				} else if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				} else if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				} else if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				} else if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				} else if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				} else if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				} else if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				} else if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				} else if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				} else if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				} else if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				} else if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				} else if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				} else if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				} else if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				} else if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				} else if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				} else if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				} else if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				} else if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				} else if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				} else if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				} else if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				} else if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				} else if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				} else if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(buildingSelected == BuildingType.OFFICE) { // OFFICE
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				} else if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				} else if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				} else if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				} else if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				} else if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				} else if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				} else if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				} else if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				} else if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				} else if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				} else if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				} else if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				} else if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				} else if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				} else if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				} else if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				} else if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				} else if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				} else if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				} else if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				} else if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				} else if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				} else if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				} else if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				} else if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				} else if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				} else if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				} else if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				} else if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(buildingSelected == BuildingType.LARGE_MARKET) { // LARGE_MARKET
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				} else if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				} else if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				} else if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				} else if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				} else if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				} else if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				} else if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				} else if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				} else if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				} else if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				} else if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				} else if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				} else if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				} else if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				} else if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				} else if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				} else if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				} else if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				} else if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				} else if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				} else if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				} else if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				} else if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				} else if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				} else if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				} else if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				} else if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				} else if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				} else if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				} else if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(buildingSelected == BuildingType.LARGE_WAREHOUSE) { // LARGE_WAREHOUSE
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				} else if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				} else if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				} else if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				} else if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				} else if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				} else if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				} else if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				} else if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				} else if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				} else if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				} else if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				} else if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				} else if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				} else if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				} else if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				} else if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				} else if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				} else if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				} else if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				} else if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				} else if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				} else if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				} else if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				} else if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				} else if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				} else if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				} else if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				} else if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				} else if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				} else if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				} else if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				} else if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				}
			}
		// =========
		// COLUMNA 3
		// =========
		} else if(buildingSelected == BuildingType.TOBACCO_STORAGE) { // TOBACCO_STORAGE
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				} else if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				} else if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				} else if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				} else if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				} else if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				} else if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				} else if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				} else if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				} else if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				} else if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				} else if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				} else if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				} else if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				} else if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				} else if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				} else if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				} else if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				} else if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				} else if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				} else if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				} else if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				} else if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				} else if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				} else if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				} else if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				} else if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				} else if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				} else if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				} else if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(buildingSelected == BuildingType.COFFEE_TOASTER) { // COFFEE_TOASTER
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				} else if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				} else if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				} else if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				} else if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				} else if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				} else if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				} else if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				} else if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				} else if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				} else if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				} else if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				} else if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				} else if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				} else if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				} else if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				} else if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				} else if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				} else if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				} else if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				} else if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				} else if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				} else if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				} else if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				} else if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				} else if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				} else if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				} else if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				} else if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				} else if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(buildingSelected == BuildingType.FACTORY) { // FACTORY
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				} else if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				} else if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				} else if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				} else if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				} else if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				} else if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				} else if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				} else if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				} else if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				} else if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				} else if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				} else if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				} else if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				} else if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				} else if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				} else if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				} else if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				} else if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				} else if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				} else if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				} else if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				} else if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				} else if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				} else if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				} else if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				} else if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				} else if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				} else if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				} else if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(buildingSelected == BuildingType.UNIVERSITY) { // UNIVERSITY
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				} else if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				} else if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				} else if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				} else if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				} else if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				} else if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				} else if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				} else if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				} else if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				} else if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				} else if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				} else if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				} else if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				} else if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				} else if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				} else if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				} else if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				} else if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				} else if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				} else if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				} else if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				} else if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				} else if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				} else if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				} else if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				} else if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				} else if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				} else if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				} else if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(buildingSelected == BuildingType.HARBOR) { // HARBOR
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				} else if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				} else if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				} else if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				} else if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				} else if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				} else if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				} else if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				} else if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				} else if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				} else if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				} else if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				} else if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				} else if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				} else if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				} else if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				} else if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				} else if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				} else if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				} else if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				} else if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				} else if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				} else if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				} else if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				} else if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				} else if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				} else if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				} else if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				} else if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				} else if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(buildingSelected == BuildingType.WHARF) { // WHARF
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				} else if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				} else if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				} else if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				} else if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				} else if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				} else if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				} else if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				} else if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				} else if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				} else if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				} else if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				} else if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				} else if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				} else if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				} else if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				} else if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				} else if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				} else if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				} else if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				} else if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				} else if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				} else if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				} else if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				} else if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				} else if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				} else if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				} else if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				} else if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				} else if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				}
			}
		// =========
		// COLUMNA 4
		// =========
		} else if(buildingSelected == BuildingType.GUILD_HALL) { // GUILD_HALL
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				} else if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				} else if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				} else if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				} else if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				} else if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				} else if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				} else if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				} else if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				} else if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				} else if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				} else if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				} else if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				} else if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				} else if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				} else if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				} else if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				} else if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				} else if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				} else if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				} else if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				} else if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				} else if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				} else if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				} else if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				} else if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				} else if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				} else if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				} else if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				} else if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(buildingSelected == BuildingType.RESIDENCE) { // RESIDENCE
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				} else if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				} else if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				} else if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				} else if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				} else if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				} else if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				} else if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				} else if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				} else if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				} else if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				} else if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				} else if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				} else if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				} else if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				} else if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				} else if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				} else if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				} else if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				} else if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				} else if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				} else if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				} else if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				} else if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				} else if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				} else if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				} else if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				} else if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				} else if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				} else if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(buildingSelected == BuildingType.FORTRESS) { // FORTRESS
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				} else if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				} else if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				} else if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				} else if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				} else if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				} else if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				} else if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				} else if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				} else if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				} else if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				} else if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				} else if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				} else if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				} else if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				} else if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				} else if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				} else if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				} else if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				} else if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				} else if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				} else if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				} else if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				} else if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				} else if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				} else if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				} else if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				} else if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				} else if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				} else if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(buildingSelected == BuildingType.CUSTOMS_HOUSE) { // CUSTOMS_HOUSE
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				} else if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				} else if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				} else if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				} else if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				} else if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				} else if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				} else if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				} else if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				} else if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				} else if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				} else if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				} else if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				} else if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				} else if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				} else if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				} else if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				} else if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				} else if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				} else if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				} else if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				} else if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				} else if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				} else if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				} else if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				} else if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				} else if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				} else if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				} else if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				} else if(UICityHall.activeSelf && UICityHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CITY_HALL, UIFrameCityHall);
					return InputManager.GetDone(playerController);
				}
			}
		} else if(buildingSelected == BuildingType.CITY_HALL) { // CITY_HALL
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				} else if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				} else if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				} else if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				} else if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				} else if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				} else if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				} else if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				} else if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				} else if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				} else if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				} else if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				} else if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(UISmallWarehouse.activeSelf && UISmallWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_WAREHOUSE, UIFrameSmallWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UILargeWarehouse.activeSelf && UILargeWarehouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_WAREHOUSE, UIFrameLargeWarehouse);
					return InputManager.GetDone(playerController);
				} else if(UIWharf.activeSelf && UIWharf.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.WHARF, UIFrameWharf);
					return InputManager.GetDone(playerController);
				} else if(UIConstructionHut.activeSelf && UIConstructionHut.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CONSTRUCTION_HUT, UIFrameConstructionHut);
					return InputManager.GetDone(playerController);
				} else if(UILargeMarket.activeSelf && UILargeMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.LARGE_MARKET, UIFrameLargeMarket);
					return InputManager.GetDone(playerController);
				} else if(UIHarbor.activeSelf && UIHarbor.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HARBOR, UIFrameHarbor);
					return InputManager.GetDone(playerController);
				} else if(UIHacienda.activeSelf && UIHacienda.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HACIENDA, UIFrameHacienda);
					return InputManager.GetDone(playerController);
				} else if(UIOffice.activeSelf && UIOffice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.OFFICE, UIFrameOffice);
					return InputManager.GetDone(playerController);
				} else if(UIUniversity.activeSelf && UIUniversity.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.UNIVERSITY, UIFrameUniversity);
					return InputManager.GetDone(playerController);
				} else if(UISmallMarket.activeSelf && UISmallMarket.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_MARKET, UIFrameSmallMarket);
					return InputManager.GetDone(playerController);
				} else if(UIHospice.activeSelf && UIHospice.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.HOSPICE, UIFrameHospice);
					return InputManager.GetDone(playerController);
				} else if(UIFactory.activeSelf && UIFactory.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FACTORY, UIFrameFactory);
					return InputManager.GetDone(playerController);
				} else if(UISmallSugarMill.activeSelf && UISmallSugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_SUGAR_MILL, UIFrameSmallSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UISugarMill.activeSelf && UISugarMill.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SUGAR_MILL, UIFrameSugarMill);
					return InputManager.GetDone(playerController);
				} else if(UICoffeeToaster.activeSelf && UICoffeeToaster.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.COFFEE_TOASTER, UIFrameCoffeeToaster);
					return InputManager.GetDone(playerController);
				} else if(UISmallIndigoPlant.activeSelf && UISmallIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.SMALL_INDIGO_PLANT, UIFrameSmallIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UIIndigoPlant.activeSelf && UIIndigoPlant.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.INDIGO_PLANT, UIFrameIndigoPlant);
					return InputManager.GetDone(playerController);
				} else if(UITobaccoStorage.activeSelf && UITobaccoStorage.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.TOBACCO_STORAGE, UIFrameTobaccoStorage);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				} else if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				} else if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				} else if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(UICustomsHouse.activeSelf && UICustomsHouse.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.CUSTOMS_HOUSE, UIFrameCustomsHouse);
					return InputManager.GetDone(playerController);
				} else if(UIFortress.activeSelf && UIFortress.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.FORTRESS, UIFrameFortress);
					return InputManager.GetDone(playerController);
				} else if(UIResidence.activeSelf && UIResidence.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.RESIDENCE, UIFrameResidence);
					return InputManager.GetDone(playerController);
				} else if(UIGuildHall.activeSelf && UIGuildHall.GetComponent<UIBuilding>().buyable) {
					SelectBuilding(BuildingType.GUILD_HALL, UIFrameGuildHall);
					return InputManager.GetDone(playerController);
				}
			}
		}
		return InputManager.GetIdle(playerController);
	}

	void SelectBuilding(BuildingType buildingType, GameObject UIFrame) {
		DeselectFrameBuildings();
		if(buildingType == BuildingType.GUILD_HALL || buildingType == BuildingType.RESIDENCE || 
			buildingType == BuildingType.FORTRESS || buildingType == BuildingType.CUSTOMS_HOUSE || 
			buildingType == BuildingType.CITY_HALL) {
			UIFrame.GetComponent<Image>().sprite = UILargeBuildingFrame;
		} else {
			UIFrame.GetComponent<Image>().sprite = UIBuildingFrame;
		}
		buildingSelected = buildingType;
		Debug.Log("Edificio seleccionado: " + buildingSelected);
	}


	public void ResetBuildingPrices() {
		if(UISmallIndigoPlant.activeSelf) {
			UISmallIndigoPlant.GetComponent<UIBuilding>().UIPrice.text = GameData.listSmallIndigoPlant[0].price.ToString();
			UISmallIndigoPlant.GetComponent<UIBuilding>().UIPrice.color = UISmallIndigoPlant.GetComponent<UIBuilding>().colorBlack;
		}
		if(UISmallSugarMill.activeSelf) {
			UISmallSugarMill.GetComponent<UIBuilding>().UIPrice.text = GameData.listSmallSugarMill[0].price.ToString();
			UISmallSugarMill.GetComponent<UIBuilding>().UIPrice.color = UISmallSugarMill.GetComponent<UIBuilding>().colorBlack;
		}
		if(UISmallMarket.activeSelf) {
			UISmallMarket.GetComponent<UIBuilding>().UIPrice.text = GameData.listSmallMarket[0].price.ToString();
			UISmallMarket.GetComponent<UIBuilding>().UIPrice.color = UISmallMarket.GetComponent<UIBuilding>().colorBlack;
		}
		if(UIHacienda.activeSelf) {
			UIHacienda.GetComponent<UIBuilding>().UIPrice.text = GameData.listHacienda[0].price.ToString();
			UIHacienda.GetComponent<UIBuilding>().UIPrice.color = UIHacienda.GetComponent<UIBuilding>().colorBlack;
		}
		if(UIConstructionHut.activeSelf) {
			UIConstructionHut.GetComponent<UIBuilding>().UIPrice.text = GameData.listConstructionHut[0].price.ToString();
			UIConstructionHut.GetComponent<UIBuilding>().UIPrice.color = UIConstructionHut.GetComponent<UIBuilding>().colorBlack;
		}
		if(UISmallWarehouse.activeSelf) {
			UISmallWarehouse.GetComponent<UIBuilding>().UIPrice.text = GameData.listSmallWarehouse[0].price.ToString();
			UISmallWarehouse.GetComponent<UIBuilding>().UIPrice.color = UISmallWarehouse.GetComponent<UIBuilding>().colorBlack;
		}

		if(UIIndigoPlant.activeSelf) {
			UIIndigoPlant.GetComponent<UIBuilding>().UIPrice.text = GameData.listIndigoPlant[0].price.ToString();
			UIIndigoPlant.GetComponent<UIBuilding>().UIPrice.color = UIIndigoPlant.GetComponent<UIBuilding>().colorBlack;
		}
		if(UISugarMill.activeSelf) {
			UISugarMill.GetComponent<UIBuilding>().UIPrice.text = GameData.listSugarMill[0].price.ToString();
			UISugarMill.GetComponent<UIBuilding>().UIPrice.color = UISugarMill.GetComponent<UIBuilding>().colorBlack;
		}
		if(UIHospice.activeSelf) {
			UIHospice.GetComponent<UIBuilding>().UIPrice.text = GameData.listHospice[0].price.ToString();
			UIHospice.GetComponent<UIBuilding>().UIPrice.color = UIHospice.GetComponent<UIBuilding>().colorBlack;
		}
		if(UIOffice.activeSelf) {
			UIOffice.GetComponent<UIBuilding>().UIPrice.text = GameData.listOffice[0].price.ToString();
			UIOffice.GetComponent<UIBuilding>().UIPrice.color = UIOffice.GetComponent<UIBuilding>().colorBlack;
		}
		if(UILargeMarket.activeSelf) {
			UILargeMarket.GetComponent<UIBuilding>().UIPrice.text = GameData.listLargeMarket[0].price.ToString();
			UILargeMarket.GetComponent<UIBuilding>().UIPrice.color = UILargeMarket.GetComponent<UIBuilding>().colorBlack;
		}
		if(UILargeWarehouse.activeSelf) {
			UILargeWarehouse.GetComponent<UIBuilding>().UIPrice.text = GameData.listLargeWarehouse[0].price.ToString();
			UILargeWarehouse.GetComponent<UIBuilding>().UIPrice.color = UILargeWarehouse.GetComponent<UIBuilding>().colorBlack;
		}

		if(UITobaccoStorage.activeSelf) {
			UITobaccoStorage.GetComponent<UIBuilding>().UIPrice.text = GameData.listTobaccoStorage[0].price.ToString();
			UITobaccoStorage.GetComponent<UIBuilding>().UIPrice.color = UITobaccoStorage.GetComponent<UIBuilding>().colorBlack;
		}
		if(UICoffeeToaster.activeSelf) {
			UICoffeeToaster.GetComponent<UIBuilding>().UIPrice.text = GameData.listCoffeeToaster[0].price.ToString();
			UICoffeeToaster.GetComponent<UIBuilding>().UIPrice.color = UICoffeeToaster.GetComponent<UIBuilding>().colorBlack;
		}
		if(UIFactory.activeSelf) {
			UIFactory.GetComponent<UIBuilding>().UIPrice.text = GameData.listFactory[0].price.ToString();
			UIFactory.GetComponent<UIBuilding>().UIPrice.color = UIFactory.GetComponent<UIBuilding>().colorBlack;
		}
		if(UIUniversity.activeSelf) {
			UIUniversity.GetComponent<UIBuilding>().UIPrice.text = GameData.listUniversity[0].price.ToString();
			UIUniversity.GetComponent<UIBuilding>().UIPrice.color = UIUniversity.GetComponent<UIBuilding>().colorBlack;
		}
		if(UIHarbor.activeSelf) {
			UIHarbor.GetComponent<UIBuilding>().UIPrice.text = GameData.listHarbor[0].price.ToString();
			UIHarbor.GetComponent<UIBuilding>().UIPrice.color = UIHarbor.GetComponent<UIBuilding>().colorBlack;
		}
		if(UIWharf.activeSelf) {
			UIWharf.GetComponent<UIBuilding>().UIPrice.text = GameData.listWharf[0].price.ToString();
			UIWharf.GetComponent<UIBuilding>().UIPrice.color = UIWharf.GetComponent<UIBuilding>().colorBlack;
		}

		if(UIGuildHall.activeSelf) {
			UIGuildHall.GetComponent<UIBuilding>().UIPrice.text = GameData.guildHall.price.ToString();
			UIGuildHall.GetComponent<UIBuilding>().UIPrice.color = UIGuildHall.GetComponent<UIBuilding>().colorBlack;
		}
		if(UIResidence.activeSelf) {
			UIResidence.GetComponent<UIBuilding>().UIPrice.text = GameData.residence.price.ToString();
			UIResidence.GetComponent<UIBuilding>().UIPrice.color = UIResidence.GetComponent<UIBuilding>().colorBlack;
		}
		if(UIFortress.activeSelf) {
			UIFortress.GetComponent<UIBuilding>().UIPrice.text = GameData.fortress.price.ToString();
			UIFortress.GetComponent<UIBuilding>().UIPrice.color = UIFortress.GetComponent<UIBuilding>().colorBlack;
		}
		if(UICustomsHouse.activeSelf) {
			UICustomsHouse.GetComponent<UIBuilding>().UIPrice.text = GameData.customsHouse.price.ToString();
			UICustomsHouse.GetComponent<UIBuilding>().UIPrice.color = UICustomsHouse.GetComponent<UIBuilding>().colorBlack;
		}
		if(UICityHall.activeSelf) {
			UICityHall.GetComponent<UIBuilding>().UIPrice.text = GameData.cityHall.price.ToString();
			UICityHall.GetComponent<UIBuilding>().UIPrice.color = UICityHall.GetComponent<UIBuilding>().colorBlack;
		}
	}

	void DeselectFrameBuildings() {
		UIFrameSmallIndigoPlant.GetComponent<Image>().sprite = UIBuildingFrameTransparent;
		UIFrameSmallSugarMill.GetComponent<Image>().sprite = UIBuildingFrameTransparent;
		UIFrameSmallMarket.GetComponent<Image>().sprite = UIBuildingFrameTransparent;
		UIFrameHacienda.GetComponent<Image>().sprite = UIBuildingFrameTransparent;
		UIFrameConstructionHut.GetComponent<Image>().sprite = UIBuildingFrameTransparent;
		UIFrameSmallWarehouse.GetComponent<Image>().sprite = UIBuildingFrameTransparent;
		UIFrameIndigoPlant.GetComponent<Image>().sprite = UIBuildingFrameTransparent;
		UIFrameSugarMill.GetComponent<Image>().sprite = UIBuildingFrameTransparent;
		UIFrameHospice.GetComponent<Image>().sprite = UIBuildingFrameTransparent;
		UIFrameOffice.GetComponent<Image>().sprite = UIBuildingFrameTransparent;
		UIFrameLargeMarket.GetComponent<Image>().sprite = UIBuildingFrameTransparent;
		UIFrameLargeWarehouse.GetComponent<Image>().sprite = UIBuildingFrameTransparent;
		UIFrameTobaccoStorage.GetComponent<Image>().sprite = UIBuildingFrameTransparent;
		UIFrameCoffeeToaster.GetComponent<Image>().sprite = UIBuildingFrameTransparent;
		UIFrameFactory.GetComponent<Image>().sprite = UIBuildingFrameTransparent;
		UIFrameUniversity.GetComponent<Image>().sprite = UIBuildingFrameTransparent;
		UIFrameHarbor.GetComponent<Image>().sprite = UIBuildingFrameTransparent;
		UIFrameWharf.GetComponent<Image>().sprite = UIBuildingFrameTransparent;
		UIFrameGuildHall.GetComponent<Image>().sprite = UILargeBuildingFrameTransparent;
		UIFrameResidence.GetComponent<Image>().sprite = UILargeBuildingFrameTransparent;
		UIFrameFortress.GetComponent<Image>().sprite = UILargeBuildingFrameTransparent;
		UIFrameCustomsHouse.GetComponent<Image>().sprite = UILargeBuildingFrameTransparent;
		UIFrameCityHall.GetComponent<Image>().sprite = UILargeBuildingFrameTransparent;
	}

	public void SetBuildingsNotBuyable() {
		DeselectFrameBuildings();
		UISmallIndigoPlant.GetComponent<UIBuilding>().buyable = false;
		UISmallSugarMill.GetComponent<UIBuilding>().buyable = false;
		UISmallMarket.GetComponent<UIBuilding>().buyable = false;
		UIHacienda.GetComponent<UIBuilding>().buyable = false;
		UIConstructionHut.GetComponent<UIBuilding>().buyable = false;
		UISmallWarehouse.GetComponent<UIBuilding>().buyable = false;
		UIIndigoPlant.GetComponent<UIBuilding>().buyable = false;
		UISugarMill.GetComponent<UIBuilding>().buyable = false;
		UIHospice.GetComponent<UIBuilding>().buyable = false;
		UIOffice.GetComponent<UIBuilding>().buyable = false;
		UILargeMarket.GetComponent<UIBuilding>().buyable = false;
		UILargeWarehouse.GetComponent<UIBuilding>().buyable = false;
		UITobaccoStorage.GetComponent<UIBuilding>().buyable = false;
		UICoffeeToaster.GetComponent<UIBuilding>().buyable = false;
		UIFactory.GetComponent<UIBuilding>().buyable = false;
		UIUniversity.GetComponent<UIBuilding>().buyable = false;
		UIHarbor.GetComponent<UIBuilding>().buyable = false;
		UIWharf.GetComponent<UIBuilding>().buyable = false;
		UIGuildHall.GetComponent<UIBuilding>().buyable = false;
		UIResidence.GetComponent<UIBuilding>().buyable = false;
		UIFortress.GetComponent<UIBuilding>().buyable = false;
		UICustomsHouse.GetComponent<UIBuilding>().buyable = false;
		UICityHall.GetComponent<UIBuilding>().buyable = false;
	}

	public void SubstractBuilding(GameObject building, int quantityLeft) {
		building.GetComponent<UIBuilding>().UIQuantity.text = quantityLeft.ToString();
		if(quantityLeft == 0) {
			Debug.Log("No quedan más edificios de este tipo en el panel central, desactivo");
			building.SetActive(false);
		}
	}
	
}