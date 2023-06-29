using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIShipBoard : MonoBehaviour {

	public GameObject UIShip1;
	public GameObject UIShip2;
	public GameObject UIShip3;
	public GameObject UIPrivateShip;

	public GameObject UIFrameShip1;
	public GameObject UIFrameShip2;
	public GameObject UIFrameShip3;
	public GameObject UIFramePrivateShip;
	
	public Sprite UISpriteFrameShip;
	public Sprite UISpriteFrameShipTransparent;
	public Sprite UISpritePrivateShip;
	public Sprite UISpritePrivateShipDisabled;

	public CaptainObjectType selectedShipType { get; set; }

	void Start () {
		DeselectFrames();
		EnablePrivateShip(false);
	}
	
	public void SelectFirstShipAvailable(Player player, Captain captain) {
		switch(player.UIPlayerBoard.GetComponent<UIPlayerBoard>().selectedBarrel) {
			case PlantationType.CORN:
				if(captain.ship1CornShipments > 0) {
					SelectShip(UIFrameShip1, CaptainObjectType.SHIP_1);
				} else if(captain.ship2CornShipments > 0) {
					SelectShip(UIFrameShip2, CaptainObjectType.SHIP_2);
				} else if(captain.ship3CornShipments > 0) {
					SelectShip(UIFrameShip3, CaptainObjectType.SHIP_3);
				} else if(captain.activeWharf && !player.playerBoard.wharfUsed) {
					SelectShip(UIFramePrivateShip, CaptainObjectType.PRIVATE_SHIP);
				}
				break;
			case PlantationType.INDIGO:
				if(captain.ship1IndigoShipments > 0) {
					SelectShip(UIFrameShip1, CaptainObjectType.SHIP_1);
				} else if(captain.ship2IndigoShipments > 0) {
					SelectShip(UIFrameShip2, CaptainObjectType.SHIP_2);
				} else if(captain.ship3IndigoShipments > 0) {
					SelectShip(UIFrameShip3, CaptainObjectType.SHIP_3);
				} else if(captain.activeWharf && !player.playerBoard.wharfUsed) {
					SelectShip(UIFramePrivateShip, CaptainObjectType.PRIVATE_SHIP);
				}
				break;
			case PlantationType.SUGAR:
				if(captain.ship1SugarShipments > 0) {
					SelectShip(UIFrameShip1, CaptainObjectType.SHIP_1);
				} else if(captain.ship2SugarShipments > 0) {
					SelectShip(UIFrameShip2, CaptainObjectType.SHIP_2);
				} else if(captain.ship3SugarShipments > 0) {
					SelectShip(UIFrameShip3, CaptainObjectType.SHIP_3);
				} else if(captain.activeWharf && !player.playerBoard.wharfUsed) {
					SelectShip(UIFramePrivateShip, CaptainObjectType.PRIVATE_SHIP);
				}
				break;
			case PlantationType.TOBACCO:
				if(captain.ship1TobaccoShipments > 0) {
					SelectShip(UIFrameShip1, CaptainObjectType.SHIP_1);
				} else if(captain.ship2TobaccoShipments > 0) {
					SelectShip(UIFrameShip2, CaptainObjectType.SHIP_2);
				} else if(captain.ship3TobaccoShipments > 0) {
					SelectShip(UIFrameShip3, CaptainObjectType.SHIP_3);
				} else if(captain.activeWharf && !player.playerBoard.wharfUsed) {
					SelectShip(UIFramePrivateShip, CaptainObjectType.PRIVATE_SHIP);
				}
				break;
			case PlantationType.COFFEE:
				if(captain.ship1CoffeeShipments > 0) {
					SelectShip(UIFrameShip1, CaptainObjectType.SHIP_1);
				} else if(captain.ship2CoffeeShipments > 0) {
					SelectShip(UIFrameShip2, CaptainObjectType.SHIP_2);
				} else if(captain.ship3CoffeeShipments > 0) {
					SelectShip(UIFrameShip3, CaptainObjectType.SHIP_3);
				} else if(captain.activeWharf && !player.playerBoard.wharfUsed) {
					SelectShip(UIFramePrivateShip, CaptainObjectType.PRIVATE_SHIP);
				}
				break;
		}
	}
	
	public InputType MoveCursor(InputType inputX, InputType inputY, int playerController, Player player, Captain captain) {
		if(selectedShipType == CaptainObjectType.SHIP_1) { // SHIP 1
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				switch(player.UIPlayerBoard.GetComponent<UIPlayerBoard>().selectedBarrel) {
					case PlantationType.CORN:
						if(captain.activeWharf && !player.playerBoard.wharfUsed) {
							SelectShip(UIFramePrivateShip, CaptainObjectType.PRIVATE_SHIP);
							return InputManager.GetDone(playerController);
						} else if(captain.ship3CornShipments > 0) {
							SelectShip(UIFrameShip3, CaptainObjectType.SHIP_3);
							return InputManager.GetDone(playerController);
						} else if(captain.ship2CornShipments > 0) {
							SelectShip(UIFrameShip2, CaptainObjectType.SHIP_2);
							return InputManager.GetDone(playerController);
						}
						break;
					case PlantationType.INDIGO:
						if(captain.activeWharf && !player.playerBoard.wharfUsed) {
							SelectShip(UIFramePrivateShip, CaptainObjectType.PRIVATE_SHIP);
							return InputManager.GetDone(playerController);
						} else if(captain.ship3IndigoShipments > 0) {
							SelectShip(UIFrameShip3, CaptainObjectType.SHIP_3);
							return InputManager.GetDone(playerController);
						} else if(captain.ship2IndigoShipments > 0) {
							SelectShip(UIFrameShip2, CaptainObjectType.SHIP_2);
							return InputManager.GetDone(playerController);
						}
						break;
					case PlantationType.SUGAR:
						if(captain.activeWharf && !player.playerBoard.wharfUsed) {
							SelectShip(UIFramePrivateShip, CaptainObjectType.PRIVATE_SHIP);
							return InputManager.GetDone(playerController);
						} else if(captain.ship3SugarShipments > 0) {
							SelectShip(UIFrameShip3, CaptainObjectType.SHIP_3);
							return InputManager.GetDone(playerController);
						} else if(captain.ship2SugarShipments > 0) {
							SelectShip(UIFrameShip2, CaptainObjectType.SHIP_2);
							return InputManager.GetDone(playerController);
						}
						break;
					case PlantationType.TOBACCO:
						if(captain.activeWharf && !player.playerBoard.wharfUsed) {
							SelectShip(UIFramePrivateShip, CaptainObjectType.PRIVATE_SHIP);
							return InputManager.GetDone(playerController);
						} else if(captain.ship3TobaccoShipments > 0) {
							SelectShip(UIFrameShip3, CaptainObjectType.SHIP_3);
							return InputManager.GetDone(playerController);
						} else if(captain.ship2TobaccoShipments > 0) {
							SelectShip(UIFrameShip2, CaptainObjectType.SHIP_2);
							return InputManager.GetDone(playerController);
						}
						break;
					case PlantationType.COFFEE:
						if(captain.activeWharf && !player.playerBoard.wharfUsed) {
							SelectShip(UIFramePrivateShip, CaptainObjectType.PRIVATE_SHIP);
							return InputManager.GetDone(playerController);
						} else if(captain.ship3CoffeeShipments > 0) {
							SelectShip(UIFrameShip3, CaptainObjectType.SHIP_3);
							return InputManager.GetDone(playerController);
						} else if(captain.ship2CoffeeShipments > 0) {
							SelectShip(UIFrameShip2, CaptainObjectType.SHIP_2);
							return InputManager.GetDone(playerController);
						}
						break;
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				switch(player.UIPlayerBoard.GetComponent<UIPlayerBoard>().selectedBarrel) {
					case PlantationType.CORN:
						if(captain.ship2CornShipments > 0) {
							SelectShip(UIFrameShip2, CaptainObjectType.SHIP_2);
							return InputManager.GetDone(playerController);
						} else if(captain.ship3CornShipments > 0) {
							SelectShip(UIFrameShip3, CaptainObjectType.SHIP_3);
							return InputManager.GetDone(playerController);
						} else if(captain.activeWharf && !player.playerBoard.wharfUsed) {
							SelectShip(UIFramePrivateShip, CaptainObjectType.PRIVATE_SHIP);
							return InputManager.GetDone(playerController);
						}
						break;
					case PlantationType.INDIGO:
						if(captain.ship2IndigoShipments > 0) {
							SelectShip(UIFrameShip2, CaptainObjectType.SHIP_2);
							return InputManager.GetDone(playerController);
						} else if(captain.ship3IndigoShipments > 0) {
							SelectShip(UIFrameShip3, CaptainObjectType.SHIP_3);
							return InputManager.GetDone(playerController);
						} else if(captain.activeWharf && !player.playerBoard.wharfUsed) {
							SelectShip(UIFramePrivateShip, CaptainObjectType.PRIVATE_SHIP);
							return InputManager.GetDone(playerController);
						}
						break;
					case PlantationType.SUGAR:
						if(captain.ship2SugarShipments > 0) {
							SelectShip(UIFrameShip2, CaptainObjectType.SHIP_2);
							return InputManager.GetDone(playerController);
						} else if(captain.ship3SugarShipments > 0) {
							SelectShip(UIFrameShip3, CaptainObjectType.SHIP_3);
							return InputManager.GetDone(playerController);
						} else if(captain.activeWharf && !player.playerBoard.wharfUsed) {
							SelectShip(UIFramePrivateShip, CaptainObjectType.PRIVATE_SHIP);
							return InputManager.GetDone(playerController);
						}
						break;
					case PlantationType.TOBACCO:
						if(captain.ship2TobaccoShipments > 0) {
							SelectShip(UIFrameShip2, CaptainObjectType.SHIP_2);
							return InputManager.GetDone(playerController);
						} else if(captain.ship3TobaccoShipments > 0) {
							SelectShip(UIFrameShip3, CaptainObjectType.SHIP_3);
							return InputManager.GetDone(playerController);
						} else if(captain.activeWharf && !player.playerBoard.wharfUsed) {
							SelectShip(UIFramePrivateShip, CaptainObjectType.PRIVATE_SHIP);
							return InputManager.GetDone(playerController);
						}
						break;
					case PlantationType.COFFEE:
						if(captain.ship2CoffeeShipments > 0) {
							SelectShip(UIFrameShip2, CaptainObjectType.SHIP_2);
							return InputManager.GetDone(playerController);
						} else if(captain.ship3CoffeeShipments > 0) {
							SelectShip(UIFrameShip3, CaptainObjectType.SHIP_3);
							return InputManager.GetDone(playerController);
						} else if(captain.activeWharf && !player.playerBoard.wharfUsed) {
							SelectShip(UIFramePrivateShip, CaptainObjectType.PRIVATE_SHIP);
							return InputManager.GetDone(playerController);
						}
						break;
				}
			}
		} else if(selectedShipType == CaptainObjectType.SHIP_2) { // SHIP 2
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				switch(player.UIPlayerBoard.GetComponent<UIPlayerBoard>().selectedBarrel) {
					case PlantationType.CORN:
						if(captain.ship1CornShipments > 0) {
							SelectShip(UIFrameShip1, CaptainObjectType.SHIP_1);
							return InputManager.GetDone(playerController);
						} else if(captain.activeWharf && !player.playerBoard.wharfUsed) {
							SelectShip(UIFramePrivateShip, CaptainObjectType.PRIVATE_SHIP);
							return InputManager.GetDone(playerController);
						} else if(captain.ship3CornShipments > 0) {
							SelectShip(UIFrameShip3, CaptainObjectType.SHIP_3);
							return InputManager.GetDone(playerController);
						}
						break;
					case PlantationType.INDIGO:
						if(captain.ship1IndigoShipments > 0) {
							SelectShip(UIFrameShip1, CaptainObjectType.SHIP_1);
							return InputManager.GetDone(playerController);
						} else if(captain.activeWharf && !player.playerBoard.wharfUsed) {
							SelectShip(UIFramePrivateShip, CaptainObjectType.PRIVATE_SHIP);
							return InputManager.GetDone(playerController);
						} else if(captain.ship3IndigoShipments > 0) {
							SelectShip(UIFrameShip3, CaptainObjectType.SHIP_3);
							return InputManager.GetDone(playerController);
						}
						break;
					case PlantationType.SUGAR:
						if(captain.ship1SugarShipments > 0) {
							SelectShip(UIFrameShip1, CaptainObjectType.SHIP_1);
							return InputManager.GetDone(playerController);
						} else if(captain.activeWharf && !player.playerBoard.wharfUsed) {
							SelectShip(UIFramePrivateShip, CaptainObjectType.PRIVATE_SHIP);
							return InputManager.GetDone(playerController);
						} else if(captain.ship3SugarShipments > 0) {
							SelectShip(UIFrameShip3, CaptainObjectType.SHIP_3);
							return InputManager.GetDone(playerController);
						}
						break;
					case PlantationType.TOBACCO:
						if(captain.ship1TobaccoShipments > 0) {
							SelectShip(UIFrameShip1, CaptainObjectType.SHIP_1);
							return InputManager.GetDone(playerController);
						} else if(captain.activeWharf && !player.playerBoard.wharfUsed) {
							SelectShip(UIFramePrivateShip, CaptainObjectType.PRIVATE_SHIP);
							return InputManager.GetDone(playerController);
						} else if(captain.ship3TobaccoShipments > 0) {
							SelectShip(UIFrameShip3, CaptainObjectType.SHIP_3);
							return InputManager.GetDone(playerController);
						}
						break;
					case PlantationType.COFFEE:
						if(captain.ship1CoffeeShipments > 0) {
							SelectShip(UIFrameShip1, CaptainObjectType.SHIP_1);
							return InputManager.GetDone(playerController);
						} else if(captain.activeWharf && !player.playerBoard.wharfUsed) {
							SelectShip(UIFramePrivateShip, CaptainObjectType.PRIVATE_SHIP);
							return InputManager.GetDone(playerController);
						} else if(captain.ship3CoffeeShipments > 0) {
							SelectShip(UIFrameShip3, CaptainObjectType.SHIP_3);
							return InputManager.GetDone(playerController);
						}
						break;
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				switch(player.UIPlayerBoard.GetComponent<UIPlayerBoard>().selectedBarrel) {
					case PlantationType.CORN:
						if(captain.ship3CornShipments > 0) {
							SelectShip(UIFrameShip3, CaptainObjectType.SHIP_3);
							return InputManager.GetDone(playerController);
						} else if(captain.activeWharf && !player.playerBoard.wharfUsed) {
							SelectShip(UIFramePrivateShip, CaptainObjectType.PRIVATE_SHIP);
							return InputManager.GetDone(playerController);
						} else if(captain.ship1CornShipments > 0) {
							SelectShip(UIFrameShip1, CaptainObjectType.SHIP_1);
							return InputManager.GetDone(playerController);
						}
						break;
					case PlantationType.INDIGO:
						if(captain.ship3IndigoShipments > 0) {
							SelectShip(UIFrameShip3, CaptainObjectType.SHIP_3);
							return InputManager.GetDone(playerController);
						} else if(captain.activeWharf && !player.playerBoard.wharfUsed) {
							SelectShip(UIFramePrivateShip, CaptainObjectType.PRIVATE_SHIP);
							return InputManager.GetDone(playerController);
						} else if(captain.ship1IndigoShipments > 0) {
							SelectShip(UIFrameShip1, CaptainObjectType.SHIP_1);
							return InputManager.GetDone(playerController);
						}
						break;
					case PlantationType.SUGAR:
						if(captain.ship3SugarShipments > 0) {
							SelectShip(UIFrameShip3, CaptainObjectType.SHIP_3);
							return InputManager.GetDone(playerController);
						} else if(captain.activeWharf && !player.playerBoard.wharfUsed) {
							SelectShip(UIFramePrivateShip, CaptainObjectType.PRIVATE_SHIP);
							return InputManager.GetDone(playerController);
						} else if(captain.ship1SugarShipments > 0) {
							SelectShip(UIFrameShip1, CaptainObjectType.SHIP_1);
							return InputManager.GetDone(playerController);
						}
						break;
					case PlantationType.TOBACCO:
						if(captain.ship3TobaccoShipments > 0) {
							SelectShip(UIFrameShip3, CaptainObjectType.SHIP_3);
							return InputManager.GetDone(playerController);
						} else if(captain.activeWharf && !player.playerBoard.wharfUsed) {
							SelectShip(UIFramePrivateShip, CaptainObjectType.PRIVATE_SHIP);
							return InputManager.GetDone(playerController);
						} else if(captain.ship1TobaccoShipments > 0) {
							SelectShip(UIFrameShip1, CaptainObjectType.SHIP_1);
							return InputManager.GetDone(playerController);
						}
						break;
					case PlantationType.COFFEE:
						if(captain.ship3CoffeeShipments > 0) {
							SelectShip(UIFrameShip3, CaptainObjectType.SHIP_3);
							return InputManager.GetDone(playerController);
						} else if(captain.activeWharf && !player.playerBoard.wharfUsed) {
							SelectShip(UIFramePrivateShip, CaptainObjectType.PRIVATE_SHIP);
							return InputManager.GetDone(playerController);
						} else if(captain.ship1CoffeeShipments > 0) {
							SelectShip(UIFrameShip1, CaptainObjectType.SHIP_1);
							return InputManager.GetDone(playerController);
						}
						break;
				}
			}
		} else if(selectedShipType == CaptainObjectType.SHIP_3) { // SHIP 3
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				switch(player.UIPlayerBoard.GetComponent<UIPlayerBoard>().selectedBarrel) {
					case PlantationType.CORN:
						if(captain.ship2CornShipments > 0) {
							SelectShip(UIFrameShip2, CaptainObjectType.SHIP_2);
							return InputManager.GetDone(playerController);
						} else if(captain.ship1CornShipments > 0) {
							SelectShip(UIFrameShip1, CaptainObjectType.SHIP_1);
							return InputManager.GetDone(playerController);
						} else if(captain.activeWharf && !player.playerBoard.wharfUsed) {
							SelectShip(UIFramePrivateShip, CaptainObjectType.PRIVATE_SHIP);
							return InputManager.GetDone(playerController);
						}
						break;
					case PlantationType.INDIGO:
						if(captain.ship2IndigoShipments > 0) {
							SelectShip(UIFrameShip2, CaptainObjectType.SHIP_2);
							return InputManager.GetDone(playerController);
						} else if(captain.ship1IndigoShipments > 0) {
							SelectShip(UIFrameShip1, CaptainObjectType.SHIP_1);
							return InputManager.GetDone(playerController);
						} else if(captain.activeWharf && !player.playerBoard.wharfUsed) {
							SelectShip(UIFramePrivateShip, CaptainObjectType.PRIVATE_SHIP);
							return InputManager.GetDone(playerController);
						}
						break;
					case PlantationType.SUGAR:
						if(captain.ship2SugarShipments > 0) {
							SelectShip(UIFrameShip2, CaptainObjectType.SHIP_2);
							return InputManager.GetDone(playerController);
						} else if(captain.ship1SugarShipments > 0) {
							SelectShip(UIFrameShip1, CaptainObjectType.SHIP_1);
							return InputManager.GetDone(playerController);
						} else if(captain.activeWharf && !player.playerBoard.wharfUsed) {
							SelectShip(UIFramePrivateShip, CaptainObjectType.PRIVATE_SHIP);
							return InputManager.GetDone(playerController);
						}
						break;
					case PlantationType.TOBACCO:
						if(captain.ship2TobaccoShipments > 0) {
							SelectShip(UIFrameShip2, CaptainObjectType.SHIP_2);
							return InputManager.GetDone(playerController);
						} else if(captain.ship1TobaccoShipments > 0) {
							SelectShip(UIFrameShip1, CaptainObjectType.SHIP_1);
							return InputManager.GetDone(playerController);
						} else if(captain.activeWharf && !player.playerBoard.wharfUsed) {
							SelectShip(UIFramePrivateShip, CaptainObjectType.PRIVATE_SHIP);
							return InputManager.GetDone(playerController);
						}
						break;
					case PlantationType.COFFEE:
						if(captain.ship2CoffeeShipments > 0) {
							SelectShip(UIFrameShip2, CaptainObjectType.SHIP_2);
							return InputManager.GetDone(playerController);
						} else if(captain.ship1CoffeeShipments > 0) {
							SelectShip(UIFrameShip1, CaptainObjectType.SHIP_1);
							return InputManager.GetDone(playerController);
						} else if(captain.activeWharf && !player.playerBoard.wharfUsed) {
							SelectShip(UIFramePrivateShip, CaptainObjectType.PRIVATE_SHIP);
							return InputManager.GetDone(playerController);
						}
						break;
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				switch(player.UIPlayerBoard.GetComponent<UIPlayerBoard>().selectedBarrel) {
					case PlantationType.CORN:
						if(captain.activeWharf && !player.playerBoard.wharfUsed) {
							SelectShip(UIFramePrivateShip, CaptainObjectType.PRIVATE_SHIP);
							return InputManager.GetDone(playerController);
						} else if(captain.ship1CornShipments > 0) {
							SelectShip(UIFrameShip1, CaptainObjectType.SHIP_1);
							return InputManager.GetDone(playerController);
						} else if(captain.ship2CornShipments > 0) {
							SelectShip(UIFrameShip2, CaptainObjectType.SHIP_2);
							return InputManager.GetDone(playerController);
						}
						break;
					case PlantationType.INDIGO:
						if(captain.activeWharf && !player.playerBoard.wharfUsed) {
							SelectShip(UIFramePrivateShip, CaptainObjectType.PRIVATE_SHIP);
							return InputManager.GetDone(playerController);
						} else if(captain.ship1IndigoShipments > 0) {
							SelectShip(UIFrameShip1, CaptainObjectType.SHIP_1);
							return InputManager.GetDone(playerController);
						} else if(captain.ship2IndigoShipments > 0) {
							SelectShip(UIFrameShip2, CaptainObjectType.SHIP_2);
							return InputManager.GetDone(playerController);
						}
						break;
					case PlantationType.SUGAR:
						if(captain.activeWharf && !player.playerBoard.wharfUsed) {
							SelectShip(UIFramePrivateShip, CaptainObjectType.PRIVATE_SHIP);
							return InputManager.GetDone(playerController);
						} else if(captain.ship1SugarShipments > 0) {
							SelectShip(UIFrameShip1, CaptainObjectType.SHIP_1);
							return InputManager.GetDone(playerController);
						} else if(captain.ship2SugarShipments > 0) {
							SelectShip(UIFrameShip2, CaptainObjectType.SHIP_2);
							return InputManager.GetDone(playerController);
						}
						break;
					case PlantationType.TOBACCO:
						if(captain.activeWharf && !player.playerBoard.wharfUsed) {
							SelectShip(UIFramePrivateShip, CaptainObjectType.PRIVATE_SHIP);
							return InputManager.GetDone(playerController);
						} else if(captain.ship1TobaccoShipments > 0) {
							SelectShip(UIFrameShip1, CaptainObjectType.SHIP_1);
							return InputManager.GetDone(playerController);
						} else if(captain.ship2TobaccoShipments > 0) {
							SelectShip(UIFrameShip2, CaptainObjectType.SHIP_2);
							return InputManager.GetDone(playerController);
						}
						break;
					case PlantationType.COFFEE:
						if(captain.activeWharf && !player.playerBoard.wharfUsed) {
							SelectShip(UIFramePrivateShip, CaptainObjectType.PRIVATE_SHIP);
							return InputManager.GetDone(playerController);
						} else if(captain.ship1CoffeeShipments > 0) {
							SelectShip(UIFrameShip1, CaptainObjectType.SHIP_1);
							return InputManager.GetDone(playerController);
						} else if(captain.ship2CoffeeShipments > 0) {
							SelectShip(UIFrameShip2, CaptainObjectType.SHIP_2);
							return InputManager.GetDone(playerController);
						}
						break;
				}
			}
		} else if(selectedShipType == CaptainObjectType.PRIVATE_SHIP) { // PRIVATE SHIP
			if(inputX == InputManager.GetLeft(playerController)) { // Izquierda
				switch(player.UIPlayerBoard.GetComponent<UIPlayerBoard>().selectedBarrel) {
					case PlantationType.CORN:
						if(captain.ship3CornShipments > 0) {
							SelectShip(UIFrameShip3, CaptainObjectType.SHIP_3);
							return InputManager.GetDone(playerController);
						} else if(captain.ship2CornShipments > 0) {
							SelectShip(UIFrameShip2, CaptainObjectType.SHIP_2);
							return InputManager.GetDone(playerController);
						} else if(captain.ship1CornShipments > 0) {
							SelectShip(UIFrameShip1, CaptainObjectType.SHIP_1);
							return InputManager.GetDone(playerController);
						}
						break;
					case PlantationType.INDIGO:
						if(captain.ship3IndigoShipments > 0) {
							SelectShip(UIFrameShip3, CaptainObjectType.SHIP_3);
							return InputManager.GetDone(playerController);
						} else if(captain.ship2IndigoShipments > 0) {
							SelectShip(UIFrameShip2, CaptainObjectType.SHIP_2);
							return InputManager.GetDone(playerController);
						} else if(captain.ship1IndigoShipments > 0) {
							SelectShip(UIFrameShip1, CaptainObjectType.SHIP_1);
							return InputManager.GetDone(playerController);
						}
						break;
					case PlantationType.SUGAR:
						if(captain.ship3SugarShipments > 0) {
							SelectShip(UIFrameShip3, CaptainObjectType.SHIP_3);
							return InputManager.GetDone(playerController);
						} else if(captain.ship2SugarShipments > 0) {
							SelectShip(UIFrameShip2, CaptainObjectType.SHIP_2);
							return InputManager.GetDone(playerController);
						} else if(captain.ship1SugarShipments > 0) {
							SelectShip(UIFrameShip1, CaptainObjectType.SHIP_1);
							return InputManager.GetDone(playerController);
						}
						break;
					case PlantationType.TOBACCO:
						if(captain.ship3TobaccoShipments > 0) {
							SelectShip(UIFrameShip3, CaptainObjectType.SHIP_3);
							return InputManager.GetDone(playerController);
						} else if(captain.ship2TobaccoShipments > 0) {
							SelectShip(UIFrameShip2, CaptainObjectType.SHIP_2);
							return InputManager.GetDone(playerController);
						} else if(captain.ship1TobaccoShipments > 0) {
							SelectShip(UIFrameShip1, CaptainObjectType.SHIP_1);
							return InputManager.GetDone(playerController);
						}
						break;
					case PlantationType.COFFEE:
						if(captain.ship3CoffeeShipments > 0) {
							SelectShip(UIFrameShip3, CaptainObjectType.SHIP_3);
							return InputManager.GetDone(playerController);
						} else if(captain.ship2CoffeeShipments > 0) {
							SelectShip(UIFrameShip2, CaptainObjectType.SHIP_2);
							return InputManager.GetDone(playerController);
						} else if(captain.ship1CoffeeShipments > 0) {
							SelectShip(UIFrameShip1, CaptainObjectType.SHIP_1);
							return InputManager.GetDone(playerController);
						}
						break;
				}
			} else if(inputX == InputManager.GetRight(playerController)) { // Derecha
				switch(player.UIPlayerBoard.GetComponent<UIPlayerBoard>().selectedBarrel) {
					case PlantationType.CORN:
						if(captain.ship1CornShipments > 0) {
							SelectShip(UIFrameShip1, CaptainObjectType.SHIP_1);
							return InputManager.GetDone(playerController);
						} else if(captain.ship2CornShipments > 0) {
							SelectShip(UIFrameShip2, CaptainObjectType.SHIP_2);
							return InputManager.GetDone(playerController);
						} else if(captain.ship3CornShipments > 0) {
							SelectShip(UIFrameShip3, CaptainObjectType.SHIP_3);
							return InputManager.GetDone(playerController);
						}
						break;
					case PlantationType.INDIGO:
						if(captain.ship1IndigoShipments > 0) {
							SelectShip(UIFrameShip1, CaptainObjectType.SHIP_1);
							return InputManager.GetDone(playerController);
						} else if(captain.ship2IndigoShipments > 0) {
							SelectShip(UIFrameShip2, CaptainObjectType.SHIP_2);
							return InputManager.GetDone(playerController);
						} else if(captain.ship3IndigoShipments > 0) {
							SelectShip(UIFrameShip3, CaptainObjectType.SHIP_3);
							return InputManager.GetDone(playerController);
						}
						break;
					case PlantationType.SUGAR:
						if(captain.ship1SugarShipments > 0) {
							SelectShip(UIFrameShip1, CaptainObjectType.SHIP_1);
							return InputManager.GetDone(playerController);
						} else if(captain.ship2SugarShipments > 0) {
							SelectShip(UIFrameShip2, CaptainObjectType.SHIP_2);
							return InputManager.GetDone(playerController);
						} else if(captain.ship3SugarShipments > 0) {
							SelectShip(UIFrameShip3, CaptainObjectType.SHIP_3);
							return InputManager.GetDone(playerController);
						}
						break;
					case PlantationType.TOBACCO:
						if(captain.ship1TobaccoShipments > 0) {
							SelectShip(UIFrameShip1, CaptainObjectType.SHIP_1);
							return InputManager.GetDone(playerController);
						} else if(captain.ship2TobaccoShipments > 0) {
							SelectShip(UIFrameShip2, CaptainObjectType.SHIP_2);
							return InputManager.GetDone(playerController);
						} else if(captain.ship3TobaccoShipments > 0) {
							SelectShip(UIFrameShip3, CaptainObjectType.SHIP_3);
							return InputManager.GetDone(playerController);
						}
						break;
					case PlantationType.COFFEE:
						if(captain.ship1CoffeeShipments > 0) {
							SelectShip(UIFrameShip1, CaptainObjectType.SHIP_1);
							return InputManager.GetDone(playerController);
						} else if(captain.ship2CoffeeShipments > 0) {
							SelectShip(UIFrameShip2, CaptainObjectType.SHIP_2);
							return InputManager.GetDone(playerController);
						} else if(captain.ship3CoffeeShipments > 0) {
							SelectShip(UIFrameShip3, CaptainObjectType.SHIP_3);
							return InputManager.GetDone(playerController);
						}
						break;
				}
			}
		}
		return InputManager.GetIdle(playerController);
	}

	void SelectShip(GameObject UIFrame, CaptainObjectType type) {
		DeselectFrames();

		UIFrame.GetComponent<Image>().sprite = UISpriteFrameShip;
		selectedShipType = type;

		Debug.Log("GameObject seleccionado: " + selectedShipType);
	}


	public void DeselectFrames() {
		UIFrameShip1.GetComponent<Image>().sprite = UISpriteFrameShipTransparent;
		UIFrameShip2.GetComponent<Image>().sprite = UISpriteFrameShipTransparent;
		UIFrameShip3.GetComponent<Image>().sprite = UISpriteFrameShipTransparent;
		UIFramePrivateShip.GetComponent<Image>().sprite = UISpriteFrameShipTransparent;
	}

	public void EnablePrivateShip(bool enable) {
		if(enable) {
			UIPrivateShip.GetComponent<Image>().sprite = UISpritePrivateShip;
		} else {
			UIPrivateShip.GetComponent<Image>().sprite = UISpritePrivateShipDisabled;
		}
	}

	public void RefreshShip(Ship ship) {
		switch(selectedShipType) {
			case CaptainObjectType.SHIP_1:
				UIShip1.GetComponent<UIParentShip>().Refresh(ship.barrels.Count, ship.type); break;
			case CaptainObjectType.SHIP_2:
				UIShip2.GetComponent<UIParentShip>().Refresh(ship.barrels.Count, ship.type); break;
			case CaptainObjectType.SHIP_3:
				UIShip3.GetComponent<UIParentShip>().Refresh(ship.barrels.Count, ship.type); break;
		}
	}

	public void ClearEmptyShips() {
		if(GameData.ship1.barrels.Count == 0) {
			UIShip1.GetComponent<UIParentShip>().ClearShip();
		}
		if(GameData.ship2.barrels.Count == 0) {
			UIShip2.GetComponent<UIParentShip>().ClearShip();
		}
		if(GameData.ship3.barrels.Count == 0) {
			UIShip3.GetComponent<UIParentShip>().ClearShip();
		}
	}
	
}