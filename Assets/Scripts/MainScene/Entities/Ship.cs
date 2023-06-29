using System;
using System.Collections.Generic;
using UnityEngine;

public class Ship {

	public List<Barrel> barrels { get; set; }
	public int size { get; set; }
	public PlantationType type { get; set; }

	public GameObject barrel1;
	public GameObject barrel2;
	public GameObject barrel3;
	public GameObject barrel4;
	public GameObject barrel5;
	public GameObject barrel6;
	public GameObject barrel7;
	public GameObject barrel8;
	
	public Ship(int size) {
		this.barrels = new List<Barrel>(size);
		this.size = size;
		this.type = PlantationType.EMPTY_SHIP;
	}
}