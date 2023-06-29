using System;

public class Building {

	public BuildingType type { get; set; }
	public BuildingCategory category { get; set; }
	public int price { get; set; }
	public int discount { get; set; }
	public int vp { get; set; }
	public int size { get; set; }
	public String name { get; set; }
	public String description { get; set; }
	public int maximumColonists { get; set; }
	public int colonists { get; set; }
	
	public Building(BuildingType type) {
		this.type = type;
		switch(type) {
			case BuildingType.SMALL_INDIGO_PLANT:
				this.category = BuildingCategory.SMALL_FACTORY;
				this.colonists = 0;
				this.maximumColonists = 1;
				this.price = 1;
				this.discount = 1;
				this.vp = 1;
				this.size = 1;
				this.name = "Añilería pequeña";
				this.description = "";
				break;
			case BuildingType.SMALL_SUGAR_MILL:
				this.category = BuildingCategory.SMALL_FACTORY;
				this.colonists = 0;
				this.maximumColonists = 1;
				this.price = 2;
				this.discount = 1;
				this.vp = 1;
				this.size = 1;
				this.name = "Azucarera pequeña";
				this.description = "";
				break;
			case BuildingType.SMALL_MARKET:
				this.category = BuildingCategory.PURPLE;
				this.colonists = 0;
				this.maximumColonists = 1;
				this.price = 1;
				this.discount = 1;
				this.vp = 1;
				this.size = 1;
				this.name = "Mercado pequeño";
				this.description = "";
				break;
			case BuildingType.HACIENDA:
				this.category = BuildingCategory.PURPLE;
				this.colonists = 0;
				this.maximumColonists = 1;
				this.price = 2;
				this.discount = 1;
				this.vp = 1;
				this.size = 1;
				this.name = "Hacienda";
				this.description = "";
				break;
			case BuildingType.CONSTRUCTION_HUT:
				this.category = BuildingCategory.PURPLE;
				this.colonists = 0;
				this.maximumColonists = 1;
				this.price = 2;
				this.discount = 1;
				this.vp = 1;
				this.size = 1;
				this.name = "Caseta de obra";
				this.description = "";
				break;
			case BuildingType.SMALL_WAREHOUSE:
				this.category = BuildingCategory.PURPLE;
				this.colonists = 0;
				this.maximumColonists = 1;
				this.price = 3;
				this.discount = 1;
				this.vp = 1;
				this.size = 1;
				this.name = "Almacén pequeño";
				this.description = "";
				break;
			case BuildingType.INDIGO_PLANT:
				this.category = BuildingCategory.LARGE_FACTORY;
				this.colonists = 0;
				this.maximumColonists = 3;
				this.price = 3;
				this.discount = 2;
				this.vp = 2;
				this.size = 1;
				this.name = "Añilería";
				this.description = "";
				break;
			case BuildingType.SUGAR_MILL:
				this.category = BuildingCategory.LARGE_FACTORY;
				this.colonists = 0;
				this.maximumColonists = 3;
				this.price = 4;
				this.discount = 2;
				this.vp = 2;
				this.size = 1;
				this.name = "Azucarera";
				this.description = "";
				break;
			case BuildingType.HOSPICE:
				this.category = BuildingCategory.PURPLE;
				this.colonists = 0;
				this.maximumColonists = 1;
				this.price = 4;
				this.discount = 2;
				this.vp = 2;
				this.size = 1;
				this.name = "Hospicio";
				this.description = "";
				break;
			case BuildingType.OFFICE:
				this.category = BuildingCategory.PURPLE;
				this.colonists = 0;
				this.maximumColonists = 1;
				this.price = 5;
				this.discount = 2;
				this.vp = 2;
				this.size = 1;
				this.name = "Oficina";
				this.description = "";
				break;
			case BuildingType.LARGE_MARKET:
				this.category = BuildingCategory.PURPLE;
				this.colonists = 0;
				this.maximumColonists = 1;
				this.price = 5;
				this.discount = 2;
				this.vp = 2;
				this.size = 1;
				this.name = "Mercado grande";
				this.description = "";
				break;
			case BuildingType.LARGE_WAREHOUSE:
				this.category = BuildingCategory.PURPLE;
				this.colonists = 0;
				this.maximumColonists = 1;
				this.price = 6;
				this.discount = 2;
				this.vp = 2;
				this.size = 1;
				this.name = "Almacén grande";
				this.description = "";
				break;
			case BuildingType.TOBACCO_STORAGE:
				this.category = BuildingCategory.LARGE_FACTORY;
				this.colonists = 0;
				this.maximumColonists = 3;
				this.price = 5;
				this.discount = 3;
				this.vp = 3;
				this.size = 1;
				this.name = "Secadero de tabaco";
				this.description = "";
				break;
			case BuildingType.COFFEE_TOASTER:
				this.category = BuildingCategory.LARGE_FACTORY;
				this.colonists = 0;
				this.maximumColonists = 2;
				this.price = 6;
				this.discount = 3;
				this.vp = 3;
				this.size = 1;
				this.name = "Tostadero de café";
				this.description = "";
				break;
			case BuildingType.FACTORY:
				this.category = BuildingCategory.PURPLE;
				this.colonists = 0;
				this.maximumColonists = 1;
				this.price = 7;
				this.discount = 3;
				this.vp = 3;
				this.size = 1;
				this.name = "Fábrica";
				this.description = "";
				break;
			case BuildingType.UNIVERSITY:
				this.category = BuildingCategory.PURPLE;
				this.colonists = 0;
				this.maximumColonists = 1;
				this.price = 8;
				this.discount = 3;
				this.vp = 3;
				this.size = 1;
				this.name = "Universidad";
				this.description = "";
				break;
			case BuildingType.HARBOR:
				this.category = BuildingCategory.PURPLE;
				this.colonists = 0;
				this.maximumColonists = 1;
				this.price = 8;
				this.discount = 3;
				this.vp = 3;
				this.size = 1;
				this.name = "Puerto";
				this.description = "";
				break;
			case BuildingType.WHARF:
				this.category = BuildingCategory.PURPLE;
				this.colonists = 0;
				this.maximumColonists = 1;
				this.price = 9;
				this.discount = 3;
				this.vp = 3;
				this.size = 1;
				this.name = "Muelle";
				this.description = "";
				break;
			case BuildingType.GUILD_HALL:
				this.category = BuildingCategory.PURPLE;
				this.colonists = 0;
				this.maximumColonists = 1;
				this.price = 10;
				this.discount = 4;
				this.vp = 4;
				this.size = 2;
				this.name = "Cofradía";
				this.description = "2 PV por cada edificio de producción grande (ocupado o no)\n\n1 PV por cada edificio de producción pequeño (ocupado o no)";
				break;
			case BuildingType.RESIDENCE:
				this.category = BuildingCategory.PURPLE;
				this.colonists = 0;
				this.maximumColonists = 1;
				this.price = 10;
				this.discount = 4;
				this.vp = 4;
				this.size = 2;
				this.name = "Residencia";
				this.description = "PV por casillas llenas en la isla\n4 PV por 9 ó menos\n5 PV por 10\n6 PV por 11\n7 PV por 12";
				break;
			case BuildingType.FORTRESS:
				this.category = BuildingCategory.PURPLE;
				this.colonists = 0;
				this.maximumColonists = 1;
				this.price = 10;
				this.discount = 4;
				this.vp = 4;
				this.size = 2;
				this.name = "Fortaleza";
				this.description = "1 PV por cada tres colonos";
				break;
			case BuildingType.CUSTOMS_HOUSE:
				this.category = BuildingCategory.PURPLE;
				this.colonists = 0;
				this.maximumColonists = 1;
				this.price = 10;
				this.discount = 4;
				this.vp = 4;
				this.size = 2;
				this.name = "Aduana";
				this.description = "1 PV por cada 4 PV conseguidos durante la partida";
				break;
			case BuildingType.CITY_HALL:
				this.category = BuildingCategory.PURPLE;
				this.colonists = 0;
				this.maximumColonists = 1;
				this.price = 10;
				this.discount = 4;
				this.vp = 4;
				this.size = 2;
				this.name = "Ayuntamiento";
				this.description = "1 PV por cada edificio violeta";
				break;
			default:
				break;
		}
	}
}