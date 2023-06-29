using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIShip7Barrels : UIParentShip {

	public GameObject UIBarrel1;
	public GameObject UIBarrel2;
	public GameObject UIBarrel3;
	public GameObject UIBarrel4;
	public GameObject UIBarrel5;
	public GameObject UIBarrel6;
	public GameObject UIBarrel7;

	public Sprite UIBarrelCorn;
	public Sprite UIBarrelIndigo;
	public Sprite UIBarrelSugar;
	public Sprite UIBarrelTobacco;
	public Sprite UIBarrelCoffee;

	void Start () {
		ClearShip();
	}

	public override void Refresh(int barrels, PlantationType type) {
		ClearShip();
		GameObject UIBarrel;
		for(int acc = 1; acc <= barrels; acc++) {
			UIBarrel = GetUIBarrelByPosition(acc);
			UIBarrel.GetComponent<Image>().sprite = GetSpriteByBarrelType(type);
			UIBarrel.SetActive(true);
		}
	}

	GameObject GetUIBarrelByPosition(int position) {
		switch(position) {
			case 1:
				return UIBarrel1;
			case 2:
				return UIBarrel2;
			case 3:
				return UIBarrel3;
			case 4:
				return UIBarrel4;
			case 5:
				return UIBarrel5;
			case 6:
				return UIBarrel6;
			case 7:
				return UIBarrel7;
		}
		return null;
	}
	
	Sprite GetSpriteByBarrelType(PlantationType type) {
		switch(type) {
			case PlantationType.CORN:
				return UIBarrelCorn;
			case PlantationType.INDIGO:
				return UIBarrelIndigo;
			case PlantationType.SUGAR:
				return UIBarrelSugar;
			case PlantationType.TOBACCO:
				return UIBarrelTobacco;
			case PlantationType.COFFEE:
				return UIBarrelCoffee;
		}
		return null;
	}

	public override void ClearShip() {
		UIBarrel1.SetActive(false);
		UIBarrel2.SetActive(false);
		UIBarrel3.SetActive(false);
		UIBarrel4.SetActive(false);
		UIBarrel5.SetActive(false);
		UIBarrel6.SetActive(false);
		UIBarrel7.SetActive(false);
	}

}