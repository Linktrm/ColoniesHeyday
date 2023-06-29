using System;

public class Barrel {

	public PlantationType type { get; set; }
	public int marketValue { get; set; }
	
	public Barrel(PlantationType type) {
		this.type = type;
		
		switch(type) {
		case PlantationType.CORN:
			this.marketValue = 0;
			break;
		case PlantationType.INDIGO:
			this.marketValue = 1;
			break;
		case PlantationType.SUGAR:
			this.marketValue = 2;
			break;
		case PlantationType.TOBACCO:
			this.marketValue = 3;
			break;
		case PlantationType.COFFEE:
			this.marketValue = 4;
			break;
		}
	}

}