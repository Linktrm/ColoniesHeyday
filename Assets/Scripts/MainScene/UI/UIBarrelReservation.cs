using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBarrelReservation : MonoBehaviour {

	public GameObject UIFrameBarrelCorn;
	public GameObject UIFrameBarrelIndigo;
	public GameObject UIFrameBarrelSugar;
	public GameObject UIFrameBarrelTobacco;
	public GameObject UIFrameBarrelCoffee;

	public Sprite UIBarrelFrame;
	public Sprite UIBarrelFrameTransparent;

	public Text UICornBarrels;
	public Text UIIndigoBarrels;
	public Text UISugarBarrels;
	public Text UITobaccoBarrels;
	public Text UICoffeeBarrels;

	public PlantationType barrelSelected { get; set; }

	// Use this for initialization
	void Start () {
		DeselectFrames();
		UICornBarrels.text = "10";
		UIIndigoBarrels.text = "11";
		UISugarBarrels.text = "11";
		UITobaccoBarrels.text = "9";
		UICoffeeBarrels.text = "9";
	}
	
	public void SelectFirstBarrelAvailable(Craftsman capataz) {
		DeselectFrames();
		if(GameData.cornBarrels.Count > 0 && capataz.craftingCorn > 0) {
			UIFrameBarrelCorn.GetComponent<Image>().sprite = UIBarrelFrame;
			barrelSelected = PlantationType.CORN;
		} else if(GameData.indigoBarrels.Count > 0 && capataz.craftingIndigo > 0) {
			UIFrameBarrelIndigo.GetComponent<Image>().sprite = UIBarrelFrame;
			barrelSelected = PlantationType.INDIGO;
		} else if(GameData.sugarBarrels.Count > 0 && capataz.craftingSugar > 0) {
			UIFrameBarrelSugar.GetComponent<Image>().sprite = UIBarrelFrame;
			barrelSelected = PlantationType.SUGAR;
		} else if(GameData.tobaccoBarrels.Count > 0 && capataz.craftingTobacco > 0) {
			UIFrameBarrelTobacco.GetComponent<Image>().sprite = UIBarrelFrame;
			barrelSelected = PlantationType.TOBACCO;
		} else if(GameData.coffeeBarrels.Count > 0 && capataz.craftingCoffee > 0) {
			UIFrameBarrelCoffee.GetComponent<Image>().sprite = UIBarrelFrame;
			barrelSelected = PlantationType.COFFEE;
		}
	}

	public InputType MoveCursor(InputType inputX, InputType inputY, int playerController, Craftsman capataz) {
		// CORN
		if(barrelSelected == PlantationType.CORN) {
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(GameData.indigoBarrels.Count > 0 && capataz.craftingIndigo > 0) {
					DeselectFrames();
					UIFrameBarrelIndigo.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.INDIGO;
					return InputManager.GetDone(playerController);
				} else if(GameData.coffeeBarrels.Count > 0 && capataz.craftingCoffee > 0) {
					DeselectFrames();
					UIFrameBarrelCoffee.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.COFFEE;
					return InputManager.GetDone(playerController);
				} else if(GameData.sugarBarrels.Count > 0 && capataz.craftingSugar > 0) {
					DeselectFrames();
					UIFrameBarrelSugar.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.SUGAR;
					return InputManager.GetDone(playerController);
				} else if(GameData.tobaccoBarrels.Count > 0 && capataz.craftingTobacco > 0) {
					DeselectFrames();
					UIFrameBarrelTobacco.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.TOBACCO;
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(GameData.indigoBarrels.Count > 0 && capataz.craftingIndigo > 0) {
					DeselectFrames();
					UIFrameBarrelIndigo.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.INDIGO;
					return InputManager.GetDone(playerController);
				} else if(GameData.sugarBarrels.Count > 0 && capataz.craftingSugar > 0) {
					DeselectFrames();
					UIFrameBarrelSugar.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.SUGAR;
					return InputManager.GetDone(playerController);
				} else if(GameData.coffeeBarrels.Count > 0 && capataz.craftingCoffee > 0) {
					DeselectFrames();
					UIFrameBarrelCoffee.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.COFFEE;
					return InputManager.GetDone(playerController);
				} else if(GameData.tobaccoBarrels.Count > 0 && capataz.craftingTobacco > 0) {
					DeselectFrames();
					UIFrameBarrelTobacco.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.TOBACCO;
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(GameData.sugarBarrels.Count > 0 && capataz.craftingSugar > 0) {
					DeselectFrames();
					UIFrameBarrelSugar.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.SUGAR;
					return InputManager.GetDone(playerController);
				} else if(GameData.tobaccoBarrels.Count > 0 && capataz.craftingTobacco > 0) {
					DeselectFrames();
					UIFrameBarrelTobacco.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.TOBACCO;
					return InputManager.GetDone(playerController);
				} else if(GameData.coffeeBarrels.Count > 0 && capataz.craftingCoffee > 0) {
					DeselectFrames();
					UIFrameBarrelCoffee.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.COFFEE;
					return InputManager.GetDone(playerController);
				} else if(GameData.indigoBarrels.Count > 0 && capataz.craftingIndigo > 0) {
					DeselectFrames();
					UIFrameBarrelIndigo.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.INDIGO;
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(GameData.tobaccoBarrels.Count > 0 && capataz.craftingTobacco > 0) {
					DeselectFrames();
					UIFrameBarrelTobacco.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.TOBACCO;
					return InputManager.GetDone(playerController);
				} else if(GameData.coffeeBarrels.Count > 0 && capataz.craftingCoffee > 0) {
					DeselectFrames();
					UIFrameBarrelCoffee.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.COFFEE;
					return InputManager.GetDone(playerController);
				} else if(GameData.sugarBarrels.Count > 0 && capataz.craftingSugar > 0) {
					DeselectFrames();
					UIFrameBarrelSugar.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.SUGAR;
					return InputManager.GetDone(playerController);
				} else if(GameData.indigoBarrels.Count > 0 && capataz.craftingIndigo > 0) {
					DeselectFrames();
					UIFrameBarrelIndigo.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.INDIGO;
					return InputManager.GetDone(playerController);
				}
			}
		// INDIGO
		} else if(barrelSelected == PlantationType.INDIGO) {
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(GameData.cornBarrels.Count > 0 && capataz.craftingCorn > 0) {
					DeselectFrames();
					UIFrameBarrelCorn.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.CORN;
					return InputManager.GetDone(playerController);
				} else if(GameData.sugarBarrels.Count > 0 && capataz.craftingSugar > 0) {
					DeselectFrames();
					UIFrameBarrelSugar.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.SUGAR;
					return InputManager.GetDone(playerController);
				} else if(GameData.tobaccoBarrels.Count > 0 && capataz.craftingTobacco > 0) {
					DeselectFrames();
					UIFrameBarrelTobacco.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.TOBACCO;
					return InputManager.GetDone(playerController);
				} else if(GameData.coffeeBarrels.Count > 0 && capataz.craftingCoffee > 0) {
					DeselectFrames();
					UIFrameBarrelCoffee.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.COFFEE;
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(GameData.cornBarrels.Count > 0 && capataz.craftingCorn > 0) {
					DeselectFrames();
					UIFrameBarrelCorn.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.CORN;
					return InputManager.GetDone(playerController);
				} else if(GameData.tobaccoBarrels.Count > 0 && capataz.craftingTobacco > 0) {
					DeselectFrames();
					UIFrameBarrelTobacco.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.TOBACCO;
					return InputManager.GetDone(playerController);
				} else if(GameData.sugarBarrels.Count > 0 && capataz.craftingSugar > 0) {
					DeselectFrames();
					UIFrameBarrelSugar.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.SUGAR;
					return InputManager.GetDone(playerController);
				} else if(GameData.coffeeBarrels.Count > 0 && capataz.craftingCoffee > 0) {
					DeselectFrames();
					UIFrameBarrelCoffee.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.COFFEE;
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(GameData.sugarBarrels.Count > 0 && capataz.craftingSugar > 0) {
					DeselectFrames();
					UIFrameBarrelSugar.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.SUGAR;
					return InputManager.GetDone(playerController);
				} else if(GameData.coffeeBarrels.Count > 0 && capataz.craftingCoffee > 0) {
					DeselectFrames();
					UIFrameBarrelCoffee.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.COFFEE;
					return InputManager.GetDone(playerController);
				} else if(GameData.tobaccoBarrels.Count > 0 && capataz.craftingTobacco > 0) {
					DeselectFrames();
					UIFrameBarrelTobacco.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.TOBACCO;
					return InputManager.GetDone(playerController);
				} else if(GameData.cornBarrels.Count > 0 && capataz.craftingCorn > 0) {
					DeselectFrames();
					UIFrameBarrelCorn.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.CORN;
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(GameData.coffeeBarrels.Count > 0 && capataz.craftingCoffee > 0) {
					DeselectFrames();
					UIFrameBarrelCoffee.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.COFFEE;
					return InputManager.GetDone(playerController);
				} else if(GameData.tobaccoBarrels.Count > 0 && capataz.craftingTobacco > 0) {
					DeselectFrames();
					UIFrameBarrelTobacco.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.TOBACCO;
					return InputManager.GetDone(playerController);
				} else if(GameData.sugarBarrels.Count > 0 && capataz.craftingSugar > 0) {
					DeselectFrames();
					UIFrameBarrelSugar.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.SUGAR;
					return InputManager.GetDone(playerController);
				} else if(GameData.cornBarrels.Count > 0 && capataz.craftingCorn > 0) {
					DeselectFrames();
					UIFrameBarrelCorn.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.CORN;
					return InputManager.GetDone(playerController);
				}
			}
		// SUGAR
		} else if(barrelSelected == PlantationType.SUGAR) {
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(GameData.cornBarrels.Count > 0 && capataz.craftingCorn > 0) {
					DeselectFrames();
					UIFrameBarrelCorn.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.CORN;
					return InputManager.GetDone(playerController);
				} else if(GameData.tobaccoBarrels.Count > 0 && capataz.craftingTobacco > 0) {
					DeselectFrames();
					UIFrameBarrelTobacco.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.TOBACCO;
					return InputManager.GetDone(playerController);
				} else if(GameData.indigoBarrels.Count > 0 && capataz.craftingIndigo > 0) {
					DeselectFrames();
					UIFrameBarrelIndigo.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.INDIGO;
					return InputManager.GetDone(playerController);
				} else if(GameData.coffeeBarrels.Count > 0 && capataz.craftingCoffee > 0) {
					DeselectFrames();
					UIFrameBarrelCoffee.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.COFFEE;
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(GameData.indigoBarrels.Count > 0 && capataz.craftingIndigo > 0) {
					DeselectFrames();
					UIFrameBarrelIndigo.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.INDIGO;
					return InputManager.GetDone(playerController);
				} else if(GameData.coffeeBarrels.Count > 0 && capataz.craftingCoffee > 0) {
					DeselectFrames();
					UIFrameBarrelCoffee.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.COFFEE;
					return InputManager.GetDone(playerController);
				} else if(GameData.cornBarrels.Count > 0 && capataz.craftingCorn > 0) {
					DeselectFrames();
					UIFrameBarrelCorn.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.CORN;
					return InputManager.GetDone(playerController);
				} else if(GameData.tobaccoBarrels.Count > 0 && capataz.craftingTobacco > 0) {
					DeselectFrames();
					UIFrameBarrelTobacco.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.TOBACCO;
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(GameData.tobaccoBarrels.Count > 0 && capataz.craftingTobacco > 0) {
					DeselectFrames();
					UIFrameBarrelTobacco.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.TOBACCO;
					return InputManager.GetDone(playerController);
				} else if(GameData.coffeeBarrels.Count > 0 && capataz.craftingCoffee > 0) {
					DeselectFrames();
					UIFrameBarrelCoffee.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.COFFEE;
					return InputManager.GetDone(playerController);
				} else if(GameData.cornBarrels.Count > 0 && capataz.craftingCorn > 0) {
					DeselectFrames();
					UIFrameBarrelCorn.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.CORN;
					return InputManager.GetDone(playerController);
				} else if(GameData.indigoBarrels.Count > 0 && capataz.craftingIndigo > 0) {
					DeselectFrames();
					UIFrameBarrelIndigo.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.INDIGO;
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(GameData.cornBarrels.Count > 0 && capataz.craftingCorn > 0) {
					DeselectFrames();
					UIFrameBarrelCorn.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.CORN;
					return InputManager.GetDone(playerController);
				} else if(GameData.indigoBarrels.Count > 0 && capataz.craftingIndigo > 0) {
					DeselectFrames();
					UIFrameBarrelIndigo.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.INDIGO;
					return InputManager.GetDone(playerController);
				} else if(GameData.tobaccoBarrels.Count > 0 && capataz.craftingTobacco > 0) {
					DeselectFrames();
					UIFrameBarrelTobacco.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.TOBACCO;
					return InputManager.GetDone(playerController);
				} else if(GameData.coffeeBarrels.Count > 0 && capataz.craftingCoffee > 0) {
					DeselectFrames();
					UIFrameBarrelCoffee.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.COFFEE;
					return InputManager.GetDone(playerController);
				}
			}
		// TOBACCO
		} else if(barrelSelected == PlantationType.TOBACCO) {
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(GameData.coffeeBarrels.Count > 0 && capataz.craftingCoffee > 0) {
					DeselectFrames();
					UIFrameBarrelCoffee.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.COFFEE;
					return InputManager.GetDone(playerController);
				} else if(GameData.indigoBarrels.Count > 0 && capataz.craftingIndigo > 0) {
					DeselectFrames();
					UIFrameBarrelIndigo.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.INDIGO;
					return InputManager.GetDone(playerController);
				} else if(GameData.sugarBarrels.Count > 0 && capataz.craftingSugar > 0) {
					DeselectFrames();
					UIFrameBarrelSugar.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.SUGAR;
					return InputManager.GetDone(playerController);
				} else if(GameData.cornBarrels.Count > 0 && capataz.craftingCorn > 0) {
					DeselectFrames();
					UIFrameBarrelCorn.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.CORN;
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(GameData.coffeeBarrels.Count > 0 && capataz.craftingCoffee > 0) {
					DeselectFrames();
					UIFrameBarrelCoffee.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.COFFEE;
					return InputManager.GetDone(playerController);
				} else if(GameData.sugarBarrels.Count > 0 && capataz.craftingSugar > 0) {
					DeselectFrames();
					UIFrameBarrelSugar.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.SUGAR;
					return InputManager.GetDone(playerController);
				} else if(GameData.indigoBarrels.Count > 0 && capataz.craftingIndigo > 0) {
					DeselectFrames();
					UIFrameBarrelIndigo.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.INDIGO;
					return InputManager.GetDone(playerController);
				} else if(GameData.cornBarrels.Count > 0 && capataz.craftingCorn > 0) {
					DeselectFrames();
					UIFrameBarrelCorn.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.CORN;
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(GameData.cornBarrels.Count > 0 && capataz.craftingCorn > 0) {
					DeselectFrames();
					UIFrameBarrelCorn.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.CORN;
					return InputManager.GetDone(playerController);
				} else if(GameData.indigoBarrels.Count > 0 && capataz.craftingIndigo > 0) {
					DeselectFrames();
					UIFrameBarrelIndigo.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.INDIGO;
					return InputManager.GetDone(playerController);
				} else if(GameData.sugarBarrels.Count > 0 && capataz.craftingSugar > 0) {
					DeselectFrames();
					UIFrameBarrelSugar.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.SUGAR;
					return InputManager.GetDone(playerController);
				} else if(GameData.coffeeBarrels.Count > 0 && capataz.craftingCoffee > 0) {
					DeselectFrames();
					UIFrameBarrelCoffee.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.COFFEE;
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(GameData.sugarBarrels.Count > 0 && capataz.craftingSugar > 0) {
					DeselectFrames();
					UIFrameBarrelSugar.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.SUGAR;
					return InputManager.GetDone(playerController);
				} else if(GameData.cornBarrels.Count > 0 && capataz.craftingCorn > 0) {
					DeselectFrames();
					UIFrameBarrelCorn.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.CORN;
					return InputManager.GetDone(playerController);
				} else if(GameData.indigoBarrels.Count > 0 && capataz.craftingIndigo > 0) {
					DeselectFrames();
					UIFrameBarrelIndigo.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.INDIGO;
					return InputManager.GetDone(playerController);
				} else if(GameData.coffeeBarrels.Count > 0 && capataz.craftingCoffee > 0) {
					DeselectFrames();
					UIFrameBarrelCoffee.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.COFFEE;
					return InputManager.GetDone(playerController);
				}
			}
		// COFFEE
		} else if(barrelSelected == PlantationType.COFFEE) {
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				if(GameData.tobaccoBarrels.Count > 0 && capataz.craftingTobacco > 0) {
					DeselectFrames();
					UIFrameBarrelTobacco.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.TOBACCO;
					return InputManager.GetDone(playerController);
				} else if(GameData.sugarBarrels.Count > 0 && capataz.craftingSugar > 0) {
					DeselectFrames();
					UIFrameBarrelSugar.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.SUGAR;
					return InputManager.GetDone(playerController);
				} else if(GameData.cornBarrels.Count > 0 && capataz.craftingCorn > 0) {
					DeselectFrames();
					UIFrameBarrelCorn.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.CORN;
					return InputManager.GetDone(playerController);
				} else if(GameData.indigoBarrels.Count > 0 && capataz.craftingIndigo > 0) {
					DeselectFrames();
					UIFrameBarrelIndigo.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.INDIGO;
					return InputManager.GetDone(playerController);
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				if(GameData.tobaccoBarrels.Count > 0 && capataz.craftingTobacco > 0) {
					DeselectFrames();
					UIFrameBarrelTobacco.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.TOBACCO;
					return InputManager.GetDone(playerController);
				} else if(GameData.cornBarrels.Count > 0 && capataz.craftingCorn > 0) {
					DeselectFrames();
					UIFrameBarrelCorn.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.CORN;
					return InputManager.GetDone(playerController);
				} else if(GameData.sugarBarrels.Count > 0 && capataz.craftingSugar > 0) {
					DeselectFrames();
					UIFrameBarrelSugar.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.SUGAR;
					return InputManager.GetDone(playerController);
				} else if(GameData.indigoBarrels.Count > 0 && capataz.craftingIndigo > 0) {
					DeselectFrames();
					UIFrameBarrelIndigo.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.INDIGO;
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetDown(playerController)) { // Abajo
				if(GameData.indigoBarrels.Count > 0 && capataz.craftingIndigo > 0) {
					DeselectFrames();
					UIFrameBarrelIndigo.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.INDIGO;
					return InputManager.GetDone(playerController);
				} else if(GameData.cornBarrels.Count > 0 && capataz.craftingCorn > 0) {
					DeselectFrames();
					UIFrameBarrelCorn.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.CORN;
					return InputManager.GetDone(playerController);
				} else if(GameData.sugarBarrels.Count > 0 && capataz.craftingSugar > 0) {
					DeselectFrames();
					UIFrameBarrelSugar.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.SUGAR;
					return InputManager.GetDone(playerController);
				} else if(GameData.tobaccoBarrels.Count > 0 && capataz.craftingTobacco > 0) {
					DeselectFrames();
					UIFrameBarrelTobacco.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.TOBACCO;
					return InputManager.GetDone(playerController);
				}
			} else if(inputY == InputManager.GetUp(playerController)) { // Arriba
				if(GameData.sugarBarrels.Count > 0 && capataz.craftingSugar > 0) {
					DeselectFrames();
					UIFrameBarrelSugar.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.SUGAR;
					return InputManager.GetDone(playerController);
				} else if(GameData.indigoBarrels.Count > 0 && capataz.craftingIndigo > 0) {
					DeselectFrames();
					UIFrameBarrelIndigo.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.INDIGO;
					return InputManager.GetDone(playerController);
				} else if(GameData.cornBarrels.Count > 0 && capataz.craftingCorn > 0) {
					DeselectFrames();
					UIFrameBarrelCorn.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.CORN;
					return InputManager.GetDone(playerController);
				} else if(GameData.tobaccoBarrels.Count > 0 && capataz.craftingTobacco > 0) {
					DeselectFrames();
					UIFrameBarrelTobacco.GetComponent<Image>().sprite = UIBarrelFrame;
					barrelSelected = PlantationType.TOBACCO;
					return InputManager.GetDone(playerController);
				}
			}
		}
		return InputManager.GetIdle(playerController);
	}

	public void DeselectFrames() {
		UIFrameBarrelCorn.GetComponent<Image>().sprite = UIBarrelFrameTransparent;
		UIFrameBarrelIndigo.GetComponent<Image>().sprite = UIBarrelFrameTransparent;
		UIFrameBarrelSugar.GetComponent<Image>().sprite = UIBarrelFrameTransparent;
		UIFrameBarrelTobacco.GetComponent<Image>().sprite = UIBarrelFrameTransparent;
		UIFrameBarrelCoffee.GetComponent<Image>().sprite = UIBarrelFrameTransparent;
	}

	public void RefreshBarrels() {
		UICornBarrels.text = GameData.cornBarrels.Count.ToString();
		UIIndigoBarrels.text = GameData.indigoBarrels.Count.ToString();
		UISugarBarrels.text = GameData.sugarBarrels.Count.ToString();
		UITobaccoBarrels.text = GameData.tobaccoBarrels.Count.ToString();
		UICoffeeBarrels.text = GameData.coffeeBarrels.Count.ToString();
	}

}