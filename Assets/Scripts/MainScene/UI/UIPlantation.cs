using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPlantation : MonoBehaviour {

	public GameObject UIColonist;

	public Sprite UIPlantationCorn;
	public Sprite UIPlantationIndigo;
	public Sprite UIPlantationSugar;
	public Sprite UIPlantationTobacco;
	public Sprite UIPlantationCoffee;
	public Sprite UIPlantationQuarry;
	public Sprite UIPlantationHidden;

	// Use this for initialization
	void Start () {
		gameObject.SetActive(false);
		GetComponent<Image>().sprite = null;
		UIColonist.SetActive(false);
	}
	
	public Sprite GetSpriteByPlantationType(PlantationType type) {
		switch(type) {
			case PlantationType.CORN:
				return UIPlantationCorn;
			case PlantationType.INDIGO:
				return UIPlantationIndigo;
			case PlantationType.SUGAR:
				return UIPlantationSugar;
			case PlantationType.TOBACCO:
				return UIPlantationTobacco;
			case PlantationType.COFFEE:
				return UIPlantationCoffee;
			case PlantationType.QUARRY:
				return UIPlantationQuarry;
		}
		return null;
	}
}