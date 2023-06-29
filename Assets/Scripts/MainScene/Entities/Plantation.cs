using System;

public class Plantation {

	public PlantationType type { get; set; }
	public String name { get; set; }
	public int colonist { get; set; }
	public bool hidden { get; set; }
	
	public Plantation(PlantationType type) {
		this.type = type;
		this.hidden = true;
		this.colonist = 0;
		switch(type) {
			case PlantationType.CORN:
				this.name = "Maíz";
				break;
			case PlantationType.INDIGO:
				this.name = "Añil";
				break;
			case PlantationType.SUGAR:
				this.name = "Azúcar";
				break;
			case PlantationType.TOBACCO:
				this.name = "Tabaco";
				break;
			case PlantationType.COFFEE:
				this.name = "Café";
				break;
			case PlantationType.QUARRY:
				this.name = "Cantera";
				break;
		}
	}
}