using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBoard {

	public bool governor { get; set; }
	public bool roleBonus { get; set; }
	public int maximumBuildingSlots { get; set; }
	public int activeBuildingSlots { get; set; }
	public List<Building> buildings { get; set; }
	public List<Plantation> plantations { get; set; }
	public List<Barrel> cornBarrels { get; set; }
	public List<Barrel> indigoBarrels { get; set; }
	public List<Barrel> sugarBarrels { get; set; }
	public List<Barrel> tobaccoBarrels { get; set; }
	public List<Barrel> coffeeBarrels { get; set; }
	public int extraColonists { get; set; }
	public int totalColonists { get; set; }
	public int emptySlots { get; set; }
	public int coins { get; set; }
	public int vp { get; set; }
	public bool wharfUsed { get; set; }
	public bool continueSendingGoods { get; set; }
	public int coinsPlusBarrels { get; set; }

	public PlayerBoard() {
		this.governor = false;
		this.roleBonus = false;
		this.maximumBuildingSlots = 12;
		this.activeBuildingSlots = 0;
		this.buildings = new List<Building>(maximumBuildingSlots);
		this.plantations = new List<Plantation>(12);
		this.cornBarrels = new List<Barrel>(10);
		this.indigoBarrels = new List<Barrel>(11);
		this.sugarBarrels = new List<Barrel>(11);
		this.tobaccoBarrels = new List<Barrel>(9);
		this.coffeeBarrels = new List<Barrel>(9);
		this.extraColonists = 0;
		this.totalColonists = 0;
		this.emptySlots = 0;
		this.vp = 0;
		this.coins = 0;
		this.wharfUsed = false;
		this.continueSendingGoods = true;
		this.coinsPlusBarrels = 0;
	}
}