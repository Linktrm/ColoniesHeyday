using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPlantationBoard : MonoBehaviour {

	public GameObject UIPlantation1;
	public GameObject UIPlantation2;
	public GameObject UIPlantation3;

	public Text UIQuarry;

	public GameObject UIFramePlantation1;
	public GameObject UIFramePlantation2;
	public GameObject UIFramePlantation3;
	public GameObject UIFramePlantationReservation;
	public GameObject UIFramePlantationQuarry;

	public Sprite UIPlantationCorn;
	public Sprite UIPlantationIndigo;
	public Sprite UIPlantationSugar;
	public Sprite UIPlantationTobacco;
	public Sprite UIPlantationCoffee;
	public Sprite UIPlantationHidden;

	public Sprite UIPlantationFrame;
	public Sprite UIPlantationFrameTransparent;
	public Sprite UIQuarryPanelFrame;
	public Sprite UIQuarryPanelFrameTransparent;

	public bool quarrySelectable { get; set; }

	public List<Plantation> listPlantations { get; set; }
	public int gameObjectIndexSelected { get; set; }
	public GameObject gameObjectSelected { get; set; }
	public SettlerObjectType objectTypeSelected { get; set; }

	public virtual void RefreshPlantations() {}

	protected Sprite UIGetPlantationSpriteByType(PlantationType type) {
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
		}
		return UIPlantationHidden;
	}
	
	public virtual void SelectFirstSlotAvailable() {}
	
	public virtual InputType MoveCursor(InputType inputX, InputType inputY, int playerController) {
		return InputManager.GetIdle(playerController);
	}

	protected void SelectPlantation(GameObject UIPlantation, SettlerObjectType objectType, int index, GameObject UIFrame) {
		DeselectFrames();
		if(objectTypeSelected == SettlerObjectType.QUARRY) {
			UIFrame.GetComponent<Image>().sprite = UIQuarryPanelFrame;
		} else {
			UIFrame.GetComponent<Image>().sprite = UIPlantationFrame;
		}
		gameObjectSelected = UIPlantation;
		objectTypeSelected = objectType;
		gameObjectIndexSelected = index - 1; // Lo hago así porque se hace menos lioso el código de MoveCursor
		Debug.Log("GameObject seleccionado: " + gameObjectSelected);
	}

	public void SelectPlantationReservation() {
		UIFramePlantationReservation.GetComponent<Image>().sprite = UIPlantationFrame;
	}
	
	public virtual void DeselectFrames() {}
}