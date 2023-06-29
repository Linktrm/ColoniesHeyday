using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIColonistShip : MonoBehaviour {

	public Text UIColonist1;
	public Text UIColonist2;
	public Text UIColonistReservation;
	public Text UIColonistReservationCalculated;

	public Color colorRed = new Color(190, 0, 0, 255);
	public Color colorBlack = new Color(0, 0, 0, 255);

	public int colonistReservationCalculated { get; set; }

	public virtual void RefreshShipLabels(int totalColonists, int colonistLess) {}

	public void RefreshShipLabels(int totalColonists) {
		RefreshShipLabels(totalColonists, 0);
	}

	public void SubstractFromShip(int totalColonists) {
		RefreshShipLabels(totalColonists, 1);
	}

	public int CalculateColonistReservationCalculated(int colonists) {
		// Control de mínimo el número de jugadores
		if((GameData.colonistReserve - colonists) < GameData.totalPlayers) {
			colonists = GameData.colonistReserve - GameData.totalPlayers;
		}
		// Si los colonos calculados son negativos, es que no quedan más para rellenar
		if(colonists < 0) {
			UIColonistReservationCalculated.color = colorRed; // Texto rojo
		} else {
			UIColonistReservationCalculated.color = colorBlack; // Texto negro
		}
		colonistReservationCalculated = colonists;
		UIColonistReservationCalculated.text = colonists.ToString();
		return colonists;
	}
}