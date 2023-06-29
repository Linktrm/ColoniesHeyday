using System;
using System.Collections.Generic;
using UnityEngine;

public class Role {

	public RoleTypes type { get; set; }
	public String name { get; set; }
	public String description { get; set; }
	public String extraEffect { get; set; }
	public int stackedCoins { get; set; }
	public bool usedRole { get; set; }

	public Role(RoleTypes type) {
		this.type = type;
		this.stackedCoins = 0;
		switch(type) {
			case RoleTypes.BUILDER:
				this.name = "Constructor";
				this.description = "Comprar";
				this.extraEffect = "+1 descuento"; // TODO CONSULTAR DATOS TODO
				break;
			case RoleTypes.SETTLER:
				this.name = "Colonizador";
				this.description = "Plantas";
				this.extraEffect = "Puedes elegir cantera";
				break;
			case RoleTypes.MAYOR:
				this.name = "Alcalde";
				this.description = "Colonos";
				this.extraEffect = "+1 colono";
				break;
			case RoleTypes.CRAFTSMAN:
				this.name = "Capataz";
				this.description = "Producir";
				this.extraEffect = "+1 barril extra";
				break;
			case RoleTypes.CAPTAIN:
				this.name = "Capitán";
				this.description = "Enviar";
				this.extraEffect = "+1 PV";
				break;
			case RoleTypes.TRADER:
				this.name = "Mercader";
				this.description = "Vender";
				this.extraEffect = "+1 moneda extra";
				break;
			case RoleTypes.PROSPECTOR_1:
			case RoleTypes.PROSPECTOR_2:
				this.name = "Buscador de oro";
				this.description = "Pensar paluego";
				this.extraEffect = "+1 moneda";
				break;
		}
	}
}