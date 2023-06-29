using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Builder : ParentRole {
	
	public bool activeUniversity { get; set; }
	public int activeQuarries { get; set; }

	public int smallIndigoPlantPrice { get; set; }
	public int smallSugarMillPrice { get; set; }
	public int smallMarketPrice { get; set; }
	public int haciendaPrice { get; set; }
	public int constructionHutPrice { get; set; }
	public int smallWarehousePrice { get; set; }
	public int indigoPlantPrice { get; set; }
	public int sugarMillPrice { get; set; }
	public int hospicePrice { get; set; }
	public int officePrice { get; set; }
	public int largeMarketPrice { get; set; }
	public int largeWarehousePrice { get; set; }
	public int tobaccoStoragePrice { get; set; }
	public int coffeeToasterPrice { get; set; }
	public int factoryPrice { get; set; }
	public int universityPrice { get; set; }
	public int harborPrice { get; set; }
	public int wharfPrice { get; set; }
	public int guildHallPrice { get; set; }
	public int residencePrice { get; set; }
	public int fortressPrice { get; set; }
	public int customsHousePrice { get; set; }
	public int cityHallPrice { get; set; }
	
	void inicializarPrecios() {
		activeUniversity = false;
		activeQuarries = 0;
		// Por defecto, edificios desactivados
		smallIndigoPlantPrice = -1;
		smallSugarMillPrice = -1;
		smallMarketPrice = -1;
		haciendaPrice = -1;
		constructionHutPrice = -1;
		smallWarehousePrice = -1;
		indigoPlantPrice = -1;
		sugarMillPrice = -1;
		hospicePrice = -1;
		officePrice = -1;
		largeMarketPrice = -1;
		largeWarehousePrice = -1;
		tobaccoStoragePrice = -1;
		coffeeToasterPrice = -1;
		factoryPrice = -1;
		universityPrice = -1;
		harborPrice = -1;
		wharfPrice = -1;
		guildHallPrice = -1;
		residencePrice = -1;
		fortressPrice = -1;
		customsHousePrice = -1;
		cityHallPrice = -1;
	}
	
	public ActionResult CheckMarketplace(Player player, UICentralBoard UICentralBoard) {
		Debug.Log("Constructor comprobarMercado()");
		inicializarPrecios();
		
		// Calculo las canteras activas
		activeQuarries = player.playerBoard.plantations.FindAll(i => i.type == PlantationType.QUARRY && i.colonist > 0).Count;
		Debug.Log("Canteras activas: " + activeQuarries);
		
		// Control Universidad activa
		if(player.playerBoard.buildings.Find(i => i.type == BuildingType.UNIVERSITY && i.colonists > 0) != null) {
			Debug.Log("Aviso previo, tiene Universidad activa (seguro que es el Edu)");
			activeUniversity = true;
		}
		
		// Calculo la rebaja por BONUS ROLE
		int roleDiscount = 0;
		if(player.playerBoard.roleBonus) {
			Debug.Log("Aviso previo, se rebaja todo 1 moneda por BONUS ROLE");
			roleDiscount++;
		}
		
		// Calculo el precio personal por cada edificio:
		// 0-? es el precio calculado,
		// si es -1 es que NO HAY,
		// si es -2 es que hay pero no se puede comprar porque NO TIENE DINERO,
		// si es -3 es que hay pero no se puede comprar porque YA LO TIENE.
		// si es -4 es que hay pero no se puede comprar porque NO TIENE ESPACIO.
		if(GameData.listSmallIndigoPlant.Count > 0) {
			if(player.playerBoard.buildings.Find(i => i.type == BuildingType.SMALL_INDIGO_PLANT) != null) {
				smallIndigoPlantPrice = -3; // ERROR - Ya lo tiene
				UICentralBoard.UISmallIndigoPlant.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UISmallIndigoPlant.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
				Debug.Log("No puede comprar " + BuildingType.SMALL_INDIGO_PLANT + " porque ya lo tiene");
			} else {
				if(player.playerBoard.activeBuildingSlots + GameData.listSmallIndigoPlant[0].size > player.playerBoard.maximumBuildingSlots) {
					smallIndigoPlantPrice = -4; // ERROR - El edificio no cabe
					UICentralBoard.UISmallIndigoPlant.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UISmallIndigoPlant.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
					Debug.Log("No puede comprar " + BuildingType.SMALL_INDIGO_PLANT + " porque no cabe");
				} else {
					smallIndigoPlantPrice = priceControl(GameData.listSmallIndigoPlant[0], roleDiscount, player.playerBoard.coins, UICentralBoard.UISmallIndigoPlant.GetComponent<UIBuilding>());
				}
			}
		}
		if(GameData.listSmallMarket.Count > 0) {
			if(player.playerBoard.buildings.Find(i => i.type == BuildingType.SMALL_MARKET) != null) {
				smallMarketPrice = -3; // ERROR - Ya lo tiene
				UICentralBoard.UISmallMarket.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UISmallMarket.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
				Debug.Log("No puede comprar " + BuildingType.SMALL_MARKET + " porque ya lo tiene");
			} else {
				if(player.playerBoard.activeBuildingSlots + GameData.listSmallMarket[0].size > player.playerBoard.maximumBuildingSlots) {
					smallMarketPrice = -4; // ERROR - El edificio no cabe
					UICentralBoard.UISmallMarket.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UISmallMarket.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
					Debug.Log("No puede comprar " + BuildingType.SMALL_MARKET + " porque no cabe");
				} else {
					smallMarketPrice = priceControl(GameData.listSmallMarket[0], roleDiscount, player.playerBoard.coins, UICentralBoard.UISmallMarket.GetComponent<UIBuilding>());
				}
			}
		}
		// OPTIMIZACIÓN - Si no tiene dinero y no puede comprar las posibles gratis, se salta las demás comprobaciones
		if(player.playerBoard.coins == 0 && smallIndigoPlantPrice < 0 && smallMarketPrice < 0) {
			Debug.Log("El jugador no puede comprar nada, no tiene dinero para nada");
			Debug.Log("Constructor FIN comprobarMercado()");
			return ActionResult.BUILDER_PLAYER_WITHOUT_MONEY;
		}
		if(GameData.listSmallSugarMill.Count > 0) {
			if(player.playerBoard.buildings.Find(i => i.type == BuildingType.SMALL_SUGAR_MILL) != null) {
				smallSugarMillPrice = -3; // ERROR - Ya lo tiene
				UICentralBoard.UISmallSugarMill.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UISmallSugarMill.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
				Debug.Log("No puede comprar " + BuildingType.SMALL_SUGAR_MILL + " porque ya lo tiene");
			} else {
				if(player.playerBoard.activeBuildingSlots + GameData.listSmallSugarMill[0].size > player.playerBoard.maximumBuildingSlots) {
					smallSugarMillPrice = -4; // ERROR - El edificio no cabe
					UICentralBoard.UISmallSugarMill.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UISmallSugarMill.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
					Debug.Log("No puede comprar " + BuildingType.SMALL_SUGAR_MILL + " porque no cabe");
				} else {
					smallSugarMillPrice = priceControl(GameData.listSmallSugarMill[0], roleDiscount, player.playerBoard.coins, UICentralBoard.UISmallSugarMill.GetComponent<UIBuilding>());
				}
			}
		}
		if(GameData.listHacienda.Count > 0) {
			if(player.playerBoard.buildings.Find(i => i.type == BuildingType.HACIENDA) != null) {
				haciendaPrice = -3; // ERROR - Ya lo tiene
				UICentralBoard.UIHacienda.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UIHacienda.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
				Debug.Log("No puede comprar " + BuildingType.HACIENDA + " porque ya lo tiene");
			} else {
				if(player.playerBoard.activeBuildingSlots + GameData.listHacienda[0].size > player.playerBoard.maximumBuildingSlots) {
					haciendaPrice = -4; // ERROR - El edificio no cabe
					UICentralBoard.UIHacienda.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UIHacienda.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
					Debug.Log("No puede comprar " + BuildingType.HACIENDA + " porque no cabe");
				} else {
					haciendaPrice = priceControl(GameData.listHacienda[0], roleDiscount, player.playerBoard.coins, UICentralBoard.UIHacienda.GetComponent<UIBuilding>());
				}
			}
		}
		if(GameData.listConstructionHut.Count > 0) {
			if(player.playerBoard.buildings.Find(i => i.type == BuildingType.CONSTRUCTION_HUT) != null) {
				constructionHutPrice = -3; // ERROR - Ya lo tiene
				UICentralBoard.UIConstructionHut.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UIConstructionHut.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
				Debug.Log("No puede comprar " + BuildingType.CONSTRUCTION_HUT + " porque ya lo tiene");
			} else {
				if(player.playerBoard.activeBuildingSlots + GameData.listConstructionHut[0].size > player.playerBoard.maximumBuildingSlots) {
					constructionHutPrice = -4; // ERROR - El edificio no cabe
					UICentralBoard.UIConstructionHut.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UIConstructionHut.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
					Debug.Log("No puede comprar " + BuildingType.CONSTRUCTION_HUT + " porque no cabe");
				} else {
					constructionHutPrice = priceControl(GameData.listConstructionHut[0], roleDiscount, player.playerBoard.coins, UICentralBoard.UIConstructionHut.GetComponent<UIBuilding>());
				}
			}
		}
		if(GameData.listSmallWarehouse.Count > 0) {
			if(player.playerBoard.buildings.Find(i => i.type == BuildingType.SMALL_WAREHOUSE) != null) {
				smallWarehousePrice = -3; // ERROR - Ya lo tiene
				UICentralBoard.UISmallWarehouse.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UISmallWarehouse.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
				Debug.Log("No puede comprar " + BuildingType.SMALL_WAREHOUSE + " porque ya lo tiene");
			} else {
				if(player.playerBoard.activeBuildingSlots + GameData.listSmallWarehouse[0].size > player.playerBoard.maximumBuildingSlots) {
					smallWarehousePrice = -4; // ERROR - El edificio no cabe
					UICentralBoard.UISmallWarehouse.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UISmallWarehouse.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
					Debug.Log("No puede comprar " + BuildingType.SMALL_WAREHOUSE + " porque no cabe");
				} else {
					smallWarehousePrice = priceControl(GameData.listSmallWarehouse[0], roleDiscount, player.playerBoard.coins, UICentralBoard.UISmallWarehouse.GetComponent<UIBuilding>());
				}
			}
		}
		if(GameData.listIndigoPlant.Count > 0) {
			if(player.playerBoard.buildings.Find(i => i.type == BuildingType.INDIGO_PLANT) != null) {
				indigoPlantPrice = -3; // ERROR - Ya lo tiene
				UICentralBoard.UIIndigoPlant.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UIIndigoPlant.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
				Debug.Log("No puede comprar " + BuildingType.INDIGO_PLANT + " porque ya lo tiene");
			} else {
				if(player.playerBoard.activeBuildingSlots + GameData.listIndigoPlant[0].size > player.playerBoard.maximumBuildingSlots) {
					indigoPlantPrice = -4; // ERROR - El edificio no cabe
					UICentralBoard.UIIndigoPlant.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UIIndigoPlant.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
					Debug.Log("No puede comprar " + BuildingType.INDIGO_PLANT + " porque no cabe");
				} else {
					indigoPlantPrice = priceControl(GameData.listIndigoPlant[0], roleDiscount, player.playerBoard.coins, UICentralBoard.UIIndigoPlant.GetComponent<UIBuilding>());
				}
			}
		}
		if(GameData.listSugarMill.Count > 0) {
			if(player.playerBoard.buildings.Find(i => i.type == BuildingType.SUGAR_MILL) != null) {
				sugarMillPrice = -3; // ERROR - Ya lo tiene
				UICentralBoard.UISugarMill.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UISugarMill.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
				Debug.Log("No puede comprar " + BuildingType.SUGAR_MILL + " porque ya lo tiene");
			} else {
				if(player.playerBoard.activeBuildingSlots + GameData.listSugarMill[0].size > player.playerBoard.maximumBuildingSlots) {
					sugarMillPrice = -4; // ERROR - El edificio no cabe
					UICentralBoard.UISugarMill.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UISugarMill.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
					Debug.Log("No puede comprar " + BuildingType.SUGAR_MILL + " porque no cabe");
				} else {
					sugarMillPrice = priceControl(GameData.listSugarMill[0], roleDiscount, player.playerBoard.coins, UICentralBoard.UISugarMill.GetComponent<UIBuilding>());
				}
			}
		}
		if(GameData.listHospice.Count > 0) {
			if(player.playerBoard.buildings.Find(i => i.type == BuildingType.HOSPICE) != null) {
				hospicePrice = -3; // ERROR - Ya lo tiene
				UICentralBoard.UIHospice.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UIHospice.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
				Debug.Log("No puede comprar " + BuildingType.HOSPICE + " porque ya lo tiene");
			} else {
				if(player.playerBoard.activeBuildingSlots + GameData.listHospice[0].size > player.playerBoard.maximumBuildingSlots) {
					hospicePrice = -4; // ERROR - El edificio no cabe
					UICentralBoard.UIHospice.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UIHospice.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
					Debug.Log("No puede comprar " + BuildingType.HOSPICE + " porque no cabe");
				} else {
					hospicePrice = priceControl(GameData.listHospice[0], roleDiscount, player.playerBoard.coins, UICentralBoard.UIHospice.GetComponent<UIBuilding>());
				}
			}
		}
		if(GameData.listOffice.Count > 0) {
			if(player.playerBoard.buildings.Find(i => i.type == BuildingType.OFFICE) != null) {
				officePrice = -3; // ERROR - Ya lo tiene
				UICentralBoard.UIOffice.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UIOffice.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
				Debug.Log("No puede comprar " + BuildingType.OFFICE + " porque ya lo tiene");
			} else {
				if(player.playerBoard.activeBuildingSlots + GameData.listOffice[0].size > player.playerBoard.maximumBuildingSlots) {
					officePrice = -4; // ERROR - El edificio no cabe
					UICentralBoard.UIOffice.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UIOffice.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
					Debug.Log("No puede comprar " + BuildingType.OFFICE + " porque no cabe");
				} else {
					officePrice = priceControl(GameData.listOffice[0], roleDiscount, player.playerBoard.coins, UICentralBoard.UIOffice.GetComponent<UIBuilding>());
				}
			}
		}
		if(GameData.listLargeMarket.Count > 0) {
			if(player.playerBoard.buildings.Find(i => i.type == BuildingType.LARGE_MARKET) != null) {
				largeMarketPrice = -3; // ERROR - Ya lo tiene
				UICentralBoard.UILargeMarket.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UILargeMarket.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
				Debug.Log("No puede comprar " + BuildingType.LARGE_MARKET + " porque ya lo tiene");
			} else {
				if(player.playerBoard.activeBuildingSlots + GameData.listLargeMarket[0].size > player.playerBoard.maximumBuildingSlots) {
					largeMarketPrice = -4; // ERROR - El edificio no cabe
					UICentralBoard.UILargeMarket.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UILargeMarket.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
					Debug.Log("No puede comprar " + BuildingType.LARGE_MARKET + " porque no cabe");
				} else {
					largeMarketPrice = priceControl(GameData.listLargeMarket[0], roleDiscount, player.playerBoard.coins, UICentralBoard.UILargeMarket.GetComponent<UIBuilding>());
				}
			}
		}
		if(GameData.listLargeWarehouse.Count > 0) {
			if(player.playerBoard.buildings.Find(i => i.type == BuildingType.LARGE_WAREHOUSE) != null) {
				largeWarehousePrice = -3; // ERROR - Ya lo tiene
				UICentralBoard.UILargeWarehouse.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UILargeWarehouse.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
				Debug.Log("No puede comprar " + BuildingType.LARGE_WAREHOUSE + " porque ya lo tiene");
			} else {
				if(player.playerBoard.activeBuildingSlots + GameData.listLargeWarehouse[0].size > player.playerBoard.maximumBuildingSlots) {
					largeWarehousePrice = -4; // ERROR - El edificio no cabe
					UICentralBoard.UILargeWarehouse.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UILargeWarehouse.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
					Debug.Log("No puede comprar " + BuildingType.LARGE_WAREHOUSE + " porque no cabe");
				} else {
					largeWarehousePrice = priceControl(GameData.listLargeWarehouse[0], roleDiscount, player.playerBoard.coins, UICentralBoard.UILargeWarehouse.GetComponent<UIBuilding>());
				}
			}
		}
		if(GameData.listTobaccoStorage.Count > 0) {
			if(player.playerBoard.buildings.Find(i => i.type == BuildingType.TOBACCO_STORAGE) != null) {
				tobaccoStoragePrice = -3; // ERROR - Ya lo tiene
				UICentralBoard.UITobaccoStorage.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UITobaccoStorage.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
				Debug.Log("No puede comprar " + BuildingType.TOBACCO_STORAGE + " porque ya lo tiene");
			} else {
				if(player.playerBoard.activeBuildingSlots + GameData.listTobaccoStorage[0].size > player.playerBoard.maximumBuildingSlots) {
					tobaccoStoragePrice = -4; // ERROR - El edificio no cabe
					UICentralBoard.UITobaccoStorage.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UITobaccoStorage.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
					Debug.Log("No puede comprar " + BuildingType.TOBACCO_STORAGE + " porque no cabe");
				} else {
					tobaccoStoragePrice = priceControl(GameData.listTobaccoStorage[0], roleDiscount, player.playerBoard.coins, UICentralBoard.UITobaccoStorage.GetComponent<UIBuilding>());
				}
			}
		}
		if(GameData.listCoffeeToaster.Count > 0) {
			if(player.playerBoard.buildings.Find(i => i.type == BuildingType.COFFEE_TOASTER) != null) {
				coffeeToasterPrice = -3; // ERROR - Ya lo tiene
				UICentralBoard.UICoffeeToaster.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UICoffeeToaster.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
				Debug.Log("No puede comprar " + BuildingType.COFFEE_TOASTER + " porque ya lo tiene");
			} else {
				if(player.playerBoard.activeBuildingSlots + GameData.listCoffeeToaster[0].size > player.playerBoard.maximumBuildingSlots) {
					coffeeToasterPrice = -4; // ERROR - El edificio no cabe
					UICentralBoard.UICoffeeToaster.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UICoffeeToaster.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
					Debug.Log("No puede comprar " + BuildingType.COFFEE_TOASTER + " porque no cabe");
				} else {
					coffeeToasterPrice = priceControl(GameData.listCoffeeToaster[0], roleDiscount, player.playerBoard.coins, UICentralBoard.UICoffeeToaster.GetComponent<UIBuilding>());
				}
			}
		}
		if(GameData.listFactory.Count > 0) {
			if(player.playerBoard.buildings.Find(i => i.type == BuildingType.FACTORY) != null) {
				factoryPrice = -3; // ERROR - Ya lo tiene
				UICentralBoard.UIFactory.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UIFactory.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
				Debug.Log("No puede comprar " + BuildingType.FACTORY + " porque ya lo tiene");
			} else {
				if(player.playerBoard.activeBuildingSlots + GameData.listFactory[0].size > player.playerBoard.maximumBuildingSlots) {
					factoryPrice = -4; // ERROR - El edificio no cabe
					UICentralBoard.UIFactory.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UIFactory.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
					Debug.Log("No puede comprar " + BuildingType.FACTORY + " porque no cabe");
				} else {
					factoryPrice = priceControl(GameData.listFactory[0], roleDiscount, player.playerBoard.coins, UICentralBoard.UIFactory.GetComponent<UIBuilding>());
				}
			}
		}
		if(GameData.listUniversity.Count > 0) {
			if(player.playerBoard.buildings.Find(i => i.type == BuildingType.UNIVERSITY) != null) {
				universityPrice = -3; // ERROR - Ya lo tiene
				UICentralBoard.UIUniversity.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UIUniversity.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
				Debug.Log("No puede comprar " + BuildingType.UNIVERSITY + " porque ya lo tiene");
			} else {
				if(player.playerBoard.activeBuildingSlots + GameData.listUniversity[0].size > player.playerBoard.maximumBuildingSlots) {
					universityPrice = -4; // ERROR - El edificio no cabe
					UICentralBoard.UIUniversity.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UIUniversity.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
					Debug.Log("No puede comprar " + BuildingType.UNIVERSITY + " porque no cabe");
				} else {
					universityPrice = priceControl(GameData.listUniversity[0], roleDiscount, player.playerBoard.coins, UICentralBoard.UIUniversity.GetComponent<UIBuilding>());
				}
			}
		}
		if(GameData.listHarbor.Count > 0) {
			if(player.playerBoard.buildings.Find(i => i.type == BuildingType.HARBOR) != null) {
				harborPrice = -3; // ERROR - Ya lo tiene
				UICentralBoard.UIHarbor.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UIHarbor.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
				Debug.Log("No puede comprar " + BuildingType.HARBOR + " porque ya lo tiene");
			} else {
				if(player.playerBoard.activeBuildingSlots + GameData.listHarbor[0].size > player.playerBoard.maximumBuildingSlots) {
					harborPrice = -4; // ERROR - El edificio no cabe
					UICentralBoard.UIHarbor.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UIHarbor.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
					Debug.Log("No puede comprar " + BuildingType.HARBOR + " porque no cabe");
				} else {
					harborPrice = priceControl(GameData.listHarbor[0], roleDiscount, player.playerBoard.coins, UICentralBoard.UIHarbor.GetComponent<UIBuilding>());
				}
			}
		}
		if(GameData.listWharf.Count > 0) {
			if(player.playerBoard.buildings.Find(i => i.type == BuildingType.WHARF) != null) {
				wharfPrice = -3; // ERROR - Ya lo tiene
				Debug.Log("No puede comprar " + BuildingType.WHARF + " porque ya lo tiene");
				UICentralBoard.UIWharf.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UIWharf.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
			} else {
				if(player.playerBoard.activeBuildingSlots + GameData.listWharf[0].size > player.playerBoard.maximumBuildingSlots) {
					wharfPrice = -4; // ERROR - El edificio no cabe
					Debug.Log("No puede comprar " + BuildingType.WHARF + " porque no cabe");
					UICentralBoard.UIWharf.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UIWharf.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
				} else {
					wharfPrice = priceControl(GameData.listWharf[0], roleDiscount, player.playerBoard.coins, UICentralBoard.UIWharf.GetComponent<UIBuilding>());
				}
			}
		}
		if(GameData.guildHall != null) {
			if(player.playerBoard.buildings.Find(i => i.type == BuildingType.GUILD_HALL) != null) {
				guildHallPrice = -3; // ERROR - Ya lo tiene
				UICentralBoard.UIGuildHall.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UIGuildHall.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
				Debug.Log("No puede comprar " + BuildingType.GUILD_HALL + " porque ya lo tiene");
			} else {
				if(player.playerBoard.activeBuildingSlots + GameData.guildHall.size > player.playerBoard.maximumBuildingSlots
					// Condición especial, no puede comprar más de 4 edificios grandes porque no caben
					&& player.playerBoard.buildings.FindAll(i => i.size > 1).Count < 5) {
					guildHallPrice = -4; // ERROR - El edificio no cabe
					UICentralBoard.UIGuildHall.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UIGuildHall.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
					Debug.Log("No puede comprar " + BuildingType.GUILD_HALL + " porque no cabe");
				} else {
					guildHallPrice = priceControl(GameData.guildHall, roleDiscount, player.playerBoard.coins, UICentralBoard.UIGuildHall.GetComponent<UIBuilding>());
				}
			}
		}
		if(GameData.residence != null) {
			if(player.playerBoard.buildings.Find(i => i.type == BuildingType.RESIDENCE) != null) {
				residencePrice = -3; // ERROR - Ya lo tiene
				UICentralBoard.UIResidence.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UIResidence.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
				Debug.Log("No puede comprar " + BuildingType.RESIDENCE + " porque ya lo tiene");
			} else {
				if(player.playerBoard.activeBuildingSlots + GameData.residence.size > player.playerBoard.maximumBuildingSlots
					// Condición especial, no puede comprar más de 4 edificios grandes porque no caben
					|| player.playerBoard.buildings.FindAll(i => i.size > 1).Count == 4) {
					residencePrice = -4; // ERROR - El edificio no cabe
					UICentralBoard.UIResidence.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UIResidence.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
					Debug.Log("No puede comprar " + BuildingType.RESIDENCE + " porque no cabe");
				} else {
					residencePrice = priceControl(GameData.residence, roleDiscount, player.playerBoard.coins, UICentralBoard.UIResidence.GetComponent<UIBuilding>());
				}
			}
		}
		if(GameData.fortress != null) {
			if(player.playerBoard.buildings.Find(i => i.type == BuildingType.FORTRESS) != null) {
				fortressPrice = -3; // ERROR - Ya lo tiene
				UICentralBoard.UIFortress.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UIFortress.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
				Debug.Log("No puede comprar " + BuildingType.FORTRESS + " porque ya lo tiene");
			} else {
				if(player.playerBoard.activeBuildingSlots + GameData.fortress.size > player.playerBoard.maximumBuildingSlots
					// Condición especial, no puede comprar más de 4 edificios grandes porque no caben
					|| player.playerBoard.buildings.FindAll(i => i.size > 1).Count == 4) {
					fortressPrice = -4; // ERROR - El edificio no cabe
					UICentralBoard.UIFortress.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UIFortress.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
					Debug.Log("No puede comprar " + BuildingType.FORTRESS + " porque no cabe");
				} else {
					fortressPrice = priceControl(GameData.fortress, roleDiscount, player.playerBoard.coins, UICentralBoard.UIFortress.GetComponent<UIBuilding>());
				}
			}
		}
		if(GameData.customsHouse != null) {
			if(player.playerBoard.buildings.Find(i => i.type == BuildingType.CUSTOMS_HOUSE) != null) {
				customsHousePrice = -3; // ERROR - Ya lo tiene
				UICentralBoard.UICustomsHouse.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UICustomsHouse.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
				Debug.Log("No puede comprar " + BuildingType.CUSTOMS_HOUSE + " porque ya lo tiene");
			} else {
				if(player.playerBoard.activeBuildingSlots + GameData.customsHouse.size > player.playerBoard.maximumBuildingSlots
					// Condición especial, no puede comprar más de 4 edificios grandes porque no caben
					|| player.playerBoard.buildings.FindAll(i => i.size > 1).Count == 4) {
					customsHousePrice = -4; // ERROR - El edificio no cabe
					UICentralBoard.UICustomsHouse.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UICustomsHouse.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
					Debug.Log("No puede comprar " + BuildingType.CUSTOMS_HOUSE + " porque no cabe");
				} else {
					customsHousePrice = priceControl(GameData.customsHouse, roleDiscount, player.playerBoard.coins, UICentralBoard.UICustomsHouse.GetComponent<UIBuilding>());
				}
			}
		}
		if(GameData.cityHall != null) {
			if(player.playerBoard.buildings.Find(i => i.type == BuildingType.CITY_HALL) != null) {
				cityHallPrice = -3; // ERROR - Ya lo tiene
				UICentralBoard.UICityHall.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UICityHall.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
				Debug.Log("No puede comprar " + BuildingType.CITY_HALL + " porque ya lo tiene");
			} else {
				if(player.playerBoard.activeBuildingSlots + GameData.cityHall.size > player.playerBoard.maximumBuildingSlots
					// Condición especial, no puede comprar más de 4 edificios grandes porque no caben
					|| player.playerBoard.buildings.FindAll(i => i.size > 1).Count == 4) {
					cityHallPrice = -4; // ERROR - El edificio no cabe
					UICentralBoard.UICityHall.GetComponent<UIBuilding>().UIPrice.color = UICentralBoard.UICityHall.GetComponent<UIBuilding>().colorRed; // UI Color Price RED
					Debug.Log("No puede comprar " + BuildingType.CITY_HALL + " porque no cabe");
				} else {
					cityHallPrice = priceControl(GameData.cityHall, roleDiscount, player.playerBoard.coins, UICentralBoard.UICityHall.GetComponent<UIBuilding>());
				}
			}
		}
		if(smallIndigoPlantPrice < 0 && smallSugarMillPrice < 0 && smallMarketPrice < 0 && haciendaPrice < 0 && constructionHutPrice < 0 && smallWarehousePrice < 0 &&
			indigoPlantPrice < 0 && sugarMillPrice < 0 && hospicePrice < 0 && officePrice < 0 && largeMarketPrice < 0 && largeWarehousePrice < 0 &&
			tobaccoStoragePrice < 0 && coffeeToasterPrice < 0 && factoryPrice < 0 && universityPrice < 0 && harborPrice < 0 && wharfPrice < 0 &&
			guildHallPrice < 0 && residencePrice < 0 && fortressPrice < 0 && customsHousePrice < 0 && cityHallPrice < 0) {
			Debug.Log("El jugador no puede comprar nada, no tiene dinero para nada");

			// TODO MENSAJE NO PUEDES COMPRAR NADA OK/CANCEL

			Debug.Log("Constructor FIN comprobarMercado()");
			return ActionResult.BUILDER_PLAYER_WITHOUT_MONEY;
		}
		Debug.Log("Constructor FIN comprobarMercado()");
		return ActionResult.OK;
	}
	
	private int priceControl(Building building, int roleDiscount, int coins, UIBuilding UIEdificio) {
		// Calculamos las rebajas por role y canteras
		int totalDiscount = roleDiscount + (building.discount - GameData.NegativeControl(building.discount - activeQuarries));
		// Calculamos el precio final
		int price = GameData.NegativeControl(building.price - totalDiscount);
		UIEdificio.UIPrice.text = price.ToString(); // UI Text Price
		if(price > coins) {
			Debug.Log("No puede comprar " + building.type + " porque no tiene dinero suficiente.");
			UIEdificio.UIPrice.color = UIEdificio.colorRed; // UI Color Price RED
			return -2; // ERROR - No tiene dinero suficiente
		}
		Debug.Log("Precio de " + building.type + " = " + price + " (Rebajas: " + totalDiscount + ")");
		UIEdificio.UIPrice.color = UIEdificio.colorGreen; // UI Color Price GREEN
		UIEdificio.buyable = true;
		return price; // OK - Precio TOTAL del Edificio
	}
	
	// TODO Cambiar el parámetro UIColonistShip5P por el padre
	public ActionResult BuyBuilding(Player player, Building building, UICentralBoard UICentralBoard, UIColonistShip UIColonistsBoard) {
		Debug.Log("Constructor comprarEdificios()");
		int finalPrice = 0;
		
		// Comprueba si el edificio ha de tener colono por tener la Universidad activada
		if(activeUniversity && (GameData.colonistReserve > 0 || GameData.colonistShip > 0)) {
			Debug.Log("El jugador tiene Universidad y puede coger colono");
			building.colonists++;
			player.playerBoard.totalColonists++;

			if(GameData.colonistReserve > 0) {
				Debug.Log("Cojo colono de la reserva (" + GameData.colonistReserve + "->" + (GameData.colonistReserve-1) + ")");
				GameData.colonistReserve--;
				// UI
				UIColonistsBoard.UIColonistReservation.text = GameData.colonistReserve.ToString();
			} else if(GameData.colonistShip > 0) {
				Debug.Log("Cojo colono del barco de colonos (" + GameData.colonistShip + "->" + (GameData.colonistShip-1) + ")");
				GameData.colonistShip--;
				// UI
				UIColonistsBoard.SubstractFromShip(GameData.colonistShip);
			}
		}
		
		// Añade el edificio al tablero del jugador
		Debug.Log("Ahora el tablero del jugador pasa a tener " + player.playerBoard.activeBuildingSlots + "->" + (player.playerBoard.activeBuildingSlots+building.size + " huecos para edificios"));
		player.playerBoard.buildings.Add(building);
		player.playerBoard.activeBuildingSlots += building.size;
		// UI
		player.UIPlayerBoard.GetComponent<UIPlayerBoard>().UIAssignBuilding(building);
		
		// Elimina el edificio del mercado
		switch(building.type) {
			case BuildingType.SMALL_INDIGO_PLANT:
				finalPrice = smallIndigoPlantPrice;
				GameData.listSmallIndigoPlant.Remove(building);
				// UI
				UICentralBoard.SubstractBuilding(UICentralBoard.UISmallIndigoPlant, GameData.listSmallIndigoPlant.Count);
				break;
			case BuildingType.SMALL_SUGAR_MILL:
				finalPrice = smallSugarMillPrice;
				GameData.listSmallSugarMill.Remove(building);
				// UI
				UICentralBoard.SubstractBuilding(UICentralBoard.UISmallSugarMill, GameData.listSmallSugarMill.Count);
				break;
			case BuildingType.SMALL_MARKET:
				finalPrice = smallMarketPrice;
				GameData.listSmallMarket.Remove(building);
				// UI
				UICentralBoard.SubstractBuilding(UICentralBoard.UISmallMarket, GameData.listSmallMarket.Count);
				break;
			case BuildingType.HACIENDA:
				finalPrice = haciendaPrice;
				GameData.listHacienda.Remove(building);
				// UI
				UICentralBoard.SubstractBuilding(UICentralBoard.UIHacienda, GameData.listHacienda.Count);
				break;
			case BuildingType.CONSTRUCTION_HUT:
				finalPrice = constructionHutPrice;
				GameData.listConstructionHut.Remove(building);
				// UI
				UICentralBoard.SubstractBuilding(UICentralBoard.UIConstructionHut, GameData.listConstructionHut.Count);
				break;
			case BuildingType.SMALL_WAREHOUSE:
				finalPrice = smallWarehousePrice;
				GameData.listSmallWarehouse.Remove(building);
				// UI
				UICentralBoard.SubstractBuilding(UICentralBoard.UISmallWarehouse, GameData.listSmallWarehouse.Count);
				break;
			case BuildingType.INDIGO_PLANT:
				finalPrice = indigoPlantPrice;
				GameData.listIndigoPlant.Remove(building);
				// UI
				UICentralBoard.SubstractBuilding(UICentralBoard.UIIndigoPlant, GameData.listIndigoPlant.Count);
				break;
			case BuildingType.SUGAR_MILL:
				finalPrice = sugarMillPrice;
				GameData.listSugarMill.Remove(building);
				// UI
				UICentralBoard.SubstractBuilding(UICentralBoard.UISugarMill, GameData.listSugarMill.Count);
				break;
			case BuildingType.HOSPICE:
				finalPrice = hospicePrice;
				GameData.listHospice.Remove(building);
				// UI
				UICentralBoard.SubstractBuilding(UICentralBoard.UIHospice, GameData.listHospice.Count);
				break;
			case BuildingType.OFFICE:
				finalPrice = officePrice;
				GameData.listOffice.Remove(building);
				// UI
				UICentralBoard.SubstractBuilding(UICentralBoard.UIOffice, GameData.listOffice.Count);
				break;
			case BuildingType.LARGE_MARKET:
				finalPrice = largeMarketPrice;
				GameData.listLargeMarket.Remove(building);
				// UI
				UICentralBoard.SubstractBuilding(UICentralBoard.UILargeMarket, GameData.listLargeMarket.Count);
				break;
			case BuildingType.LARGE_WAREHOUSE:
				finalPrice = largeWarehousePrice;
				GameData.listLargeWarehouse.Remove(building);
				// UI
				UICentralBoard.SubstractBuilding(UICentralBoard.UILargeWarehouse, GameData.listLargeWarehouse.Count);
				break;
			case BuildingType.TOBACCO_STORAGE:
				finalPrice = tobaccoStoragePrice;
				GameData.listTobaccoStorage.Remove(building);
				// UI
				UICentralBoard.SubstractBuilding(UICentralBoard.UITobaccoStorage, GameData.listTobaccoStorage.Count);
				break;
			case BuildingType.COFFEE_TOASTER:
				finalPrice = coffeeToasterPrice;
				GameData.listCoffeeToaster.Remove(building);
				// UI
				UICentralBoard.SubstractBuilding(UICentralBoard.UICoffeeToaster, GameData.listCoffeeToaster.Count);
				break;
			case BuildingType.FACTORY:
				finalPrice = factoryPrice;
				GameData.listFactory.Remove(building);
				// UI
				UICentralBoard.SubstractBuilding(UICentralBoard.UIFactory, GameData.listFactory.Count);
				break;
			case BuildingType.UNIVERSITY:
				finalPrice = universityPrice;
				GameData.listUniversity.Remove(building);
				// UI
				UICentralBoard.SubstractBuilding(UICentralBoard.UIUniversity, GameData.listUniversity.Count);
				break;
			case BuildingType.HARBOR:
				finalPrice = harborPrice;
				GameData.listHarbor.Remove(building);
				// UI
				UICentralBoard.SubstractBuilding(UICentralBoard.UIHarbor, GameData.listHarbor.Count);
				break;
			case BuildingType.WHARF:
				finalPrice = wharfPrice;
				GameData.listWharf.Remove(building);
				// UI
				UICentralBoard.SubstractBuilding(UICentralBoard.UIWharf, GameData.listWharf.Count);
				break;
			case BuildingType.GUILD_HALL:
				finalPrice = guildHallPrice;
				GameData.guildHall = null;
				// UI
				UICentralBoard.SubstractBuilding(UICentralBoard.UIGuildHall, 0);
				break;
			case BuildingType.RESIDENCE:
				finalPrice = residencePrice;
				GameData.residence = null;
				// UI
				UICentralBoard.SubstractBuilding(UICentralBoard.UIResidence, 0);
				break;
			case BuildingType.FORTRESS:
				finalPrice = fortressPrice;
				GameData.fortress = null;
				// UI
				UICentralBoard.SubstractBuilding(UICentralBoard.UIFortress, 0);
				break;
			case BuildingType.CUSTOMS_HOUSE:
				finalPrice = customsHousePrice;
				GameData.customsHouse = null;
				// UI
				UICentralBoard.SubstractBuilding(UICentralBoard.UICustomsHouse, 0);
				break;
			case BuildingType.CITY_HALL:
				finalPrice = cityHallPrice;
				GameData.cityHall = null;
				// UI
				UICentralBoard.SubstractBuilding(UICentralBoard.UICityHall, 0);
				break;
		}
		
		// Resta las monedas que ha de gastar
		Debug.Log("El jugador paga las monedas y pasa de " + player.playerBoard.coins + "->" + (player.playerBoard.coins-finalPrice));
		player.playerBoard.coins -= finalPrice;
		GameData.bankCoins += finalPrice;
		// UI
		player.UIPlayerBoard.GetComponent<UIPlayerBoard>().UICoins.text = player.playerBoard.coins.ToString();
		UICentralBoard.UICoins.text = GameData.bankCoins.ToString();
		
		if(player.playerBoard.activeBuildingSlots == player.playerBoard.maximumBuildingSlots) {
			Debug.Log("No quedan huecos libres - RONDA FINAL");
			Debug.Log("Constructor FIN comprarEdificios()");
			return ActionResult.BUILDING_SLOTS_FULL; // RONDA FINAL
		}
		Debug.Log("Constructor FIN comprarEdificios()");
		return ActionResult.OK;
	}
}