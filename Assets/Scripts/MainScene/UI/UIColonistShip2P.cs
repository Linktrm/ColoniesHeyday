using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIColonistShip2P : UIColonistShip {

	// Use this for initialization
	void Start () {
		UIColonist1.text = "1";
		UIColonist2.text = "1";
		UIColonistReservation.text = "95";

		UIColonistReservationCalculated.text = "0";
		UIColonistReservationCalculated.gameObject.SetActive(false);
	}

	public override void RefreshShipLabels(int totalColonists, int colonistLess) {
		int[] listColonist = new int[] { 0, 0 };

		int acc = 0;
		while(totalColonists > colonistLess) {
			
			listColonist[acc]++;

			// Siguiente posición
			acc++;
			if(acc == GameData.totalPlayers) {
				acc = 0;
			}
			
			totalColonists--;
		}
		
		UIColonist1.text = listColonist[0].ToString();
		UIColonist2.text = listColonist[1].ToString();
	}
}