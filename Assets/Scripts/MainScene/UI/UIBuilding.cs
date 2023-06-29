using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBuilding : MonoBehaviour {

	public bool isPlayerBuilding;

	public GameObject UIColonist1;
	public GameObject UIColonist2;
	public GameObject UIColonist3;
	public Text UIPrice;
	public Text UIQuantity;

	public Sprite UIBuildingSmallIndigoPlant;
	public Sprite UIBuildingSmallSugarMill;
	public Sprite UIBuildingSmallMarket;
	public Sprite UIBuildingHacienda;
	public Sprite UIBuildingConstructionHut;
	public Sprite UIBuildingSmallWarehouse;
	public Sprite UIBuildingIndigoPlant;
	public Sprite UIBuildingSugarMill;
	public Sprite UIBuildingHospice;
	public Sprite UIBuildingOffice;
	public Sprite UIBuildingLargeMarket;
	public Sprite UIBuildingLargeWarehouse;
	public Sprite UIBuildingTobaccoStorage;
	public Sprite UIBuildingCoffeeToaster;
	public Sprite UIBuildingFactory;
	public Sprite UIBuildingUniversity;
	public Sprite UIBuildingHarbor;
	public Sprite UIBuildingWharf;
	public Sprite UIBuildingGuildHall1;
	public Sprite UIBuildingGuildHall2;
	public Sprite UIBuildingResidence1;
	public Sprite UIBuildingResidence2;
	public Sprite UIBuildingFortress1;
	public Sprite UIBuildingFortress2;
	public Sprite UIBuildingCustomsHouse1;
	public Sprite UIBuildingCustomsHouse2;
	public Sprite UIBuildingCityHall1;
	public Sprite UIBuildingCityHall2;

	public Color colorRed = new Color(190, 0, 0, 255);
	public Color colorGreen = new Color(0, 150, 0, 255);
	public Color colorBlack = new Color(0, 0, 0, 255);
	public Color colorDisable = new Color(120, 120, 120, 255);

	public BuildingType type { get; set; }
	public GameObject anotherPart { get; set; }
	public bool buyable { get; set; }
	public bool lowerPart { get; set; }

	// Use this for initialization
	void Start() {
		if(isPlayerBuilding) {
			gameObject.SetActive(false);
			GetComponent<Image>().sprite = null;
			buyable = false;
		}
	}

	public Sprite GetSpriteByBuildingType(BuildingType type, bool lowerPart) {
		switch(type) {
			case BuildingType.SMALL_INDIGO_PLANT:
				return UIBuildingSmallIndigoPlant;
			case BuildingType.SMALL_SUGAR_MILL:
				return UIBuildingSmallSugarMill;
			case BuildingType.SMALL_MARKET:
				return UIBuildingSmallMarket;
			case BuildingType.HACIENDA:
				return UIBuildingHacienda;
			case BuildingType.CONSTRUCTION_HUT:
				return UIBuildingConstructionHut;
			case BuildingType.SMALL_WAREHOUSE:
				return UIBuildingSmallWarehouse;
			case BuildingType.INDIGO_PLANT:
				return UIBuildingIndigoPlant;
			case BuildingType.SUGAR_MILL:
				return UIBuildingSugarMill;
			case BuildingType.HOSPICE:
				return UIBuildingHospice;
			case BuildingType.OFFICE:
				return UIBuildingOffice;
			case BuildingType.LARGE_MARKET:
				return UIBuildingLargeMarket;
			case BuildingType.LARGE_WAREHOUSE:
				return UIBuildingLargeWarehouse;
			case BuildingType.TOBACCO_STORAGE:
				return UIBuildingTobaccoStorage;
			case BuildingType.COFFEE_TOASTER:
				return UIBuildingCoffeeToaster;
			case BuildingType.FACTORY:
				return UIBuildingFactory;
			case BuildingType.UNIVERSITY:
				return UIBuildingUniversity;
			case BuildingType.HARBOR:
				return UIBuildingHarbor;
			case BuildingType.WHARF:
				return UIBuildingWharf;
			case BuildingType.GUILD_HALL:
				if(lowerPart)
					return UIBuildingGuildHall2;
				return UIBuildingGuildHall1;
			case BuildingType.RESIDENCE:
				if(lowerPart)
					return UIBuildingResidence2;
				return UIBuildingResidence1;
			case BuildingType.FORTRESS:
				if(lowerPart)
					return UIBuildingFortress2;
				return UIBuildingFortress1;
			case BuildingType.CUSTOMS_HOUSE:
				if(lowerPart)
					return UIBuildingCustomsHouse2;
				return UIBuildingCustomsHouse1;
			case BuildingType.CITY_HALL:
				if(lowerPart)
					return UIBuildingCityHall2;
				return UIBuildingCityHall1;
		}
		return null;
	}

	public void CalculateBuildingColonists(int colonists) {
		switch(colonists) {
			case 0:
				UIColonist1.SetActive(false);
				UIColonist2.SetActive(false);
				UIColonist3.SetActive(false);
				break;
			case 1:
				UIColonist1.SetActive(true);
				UIColonist2.SetActive(false);
				UIColonist3.SetActive(false);
				break;
			case 2:
				UIColonist1.SetActive(true);
				UIColonist2.SetActive(true);
				UIColonist3.SetActive(false);
				break;
			case 3:
				UIColonist1.SetActive(true);
				UIColonist2.SetActive(true);
				UIColonist3.SetActive(true);
				break;
		}
	}
	
}