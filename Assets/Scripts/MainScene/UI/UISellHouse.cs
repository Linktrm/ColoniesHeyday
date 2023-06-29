using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISellHouse : MonoBehaviour {

	public GameObject UIBarrel1;
	public GameObject UIBarrel2;
	public GameObject UIBarrel3;
	public GameObject UIBarrel4;

	public Text UITextCorn;
	public Text UITextIndigo;
	public Text UITextSugar;
	public Text UITextTobacco;
	public Text UITextCoffee;

	public Sprite UIBarrelCorn;
	public Sprite UIBarrelIndigo;
	public Sprite UIBarrelSugar;
	public Sprite UIBarrelTobacco;
	public Sprite UIBarrelCoffee;

	public Color colorRed = new Color(190, 0, 0, 255);
	public Color colorGreen = new Color(0, 150, 0, 255);
	public Color colorBlack = new Color(0, 0, 0, 255);

	// Use this for initialization
	void Start () {
		UIBarrel1.GetComponent<Image>().sprite = null;
		UIBarrel1.SetActive(false);
		UIBarrel2.GetComponent<Image>().sprite = null;
		UIBarrel2.SetActive(false);
		UIBarrel3.GetComponent<Image>().sprite = null;
		UIBarrel3.SetActive(false);
		UIBarrel4.GetComponent<Image>().sprite = null;
		UIBarrel4.SetActive(false);

		ResetPrices();
	}

	public void ResetPrices() {
		UITextCorn.text = "0";
		UITextCorn.color = colorBlack;
		UITextIndigo.text = "1";
		UITextIndigo.color = colorBlack;
		UITextSugar.text = "2";
		UITextSugar.color = colorBlack;
		UITextTobacco.text = "3";
		UITextTobacco.color = colorBlack;
		UITextCoffee.text = "4";
		UITextCoffee.color = colorBlack;
	}

	public void UIAssignBarrel(PlantationType barrelType) {
		if(!UIBarrel1.activeSelf) {
			ActivateBarrel(UIBarrel1, barrelType);
		} else if(!UIBarrel2.activeSelf) {
			ActivateBarrel(UIBarrel2, barrelType);
		} else if(!UIBarrel3.activeSelf) {
			ActivateBarrel(UIBarrel3, barrelType);
		} else if(!UIBarrel4.activeSelf) {
			ActivateBarrel(UIBarrel4, barrelType);
		}
	}

	void ActivateBarrel(GameObject UIBarrel, PlantationType barrelType) {
		UIBarrel.SetActive(true);
		switch(barrelType) {
			case PlantationType.CORN:
				UIBarrel1.SetActive(true);
				UIBarrel.GetComponent<Image>().sprite = UIBarrelCorn;
				break;
			case PlantationType.INDIGO:
				UIBarrel1.SetActive(true);
				UIBarrel.GetComponent<Image>().sprite = UIBarrelIndigo;
				break;
			case PlantationType.SUGAR:
				UIBarrel1.SetActive(true);
				UIBarrel.GetComponent<Image>().sprite = UIBarrelSugar;
				break;
			case PlantationType.TOBACCO:
				UIBarrel1.SetActive(true);
				UIBarrel.GetComponent<Image>().sprite = UIBarrelTobacco;
				break;
			case PlantationType.COFFEE:
				UIBarrel1.SetActive(true);
				UIBarrel.GetComponent<Image>().sprite = UIBarrelCoffee;
				break;
		}
	}
}