using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIVPReservation : MonoBehaviour {

	public Text UIVP;

	public Color colorRed = new Color(190, 0, 0, 255);
	public Color colorBlack = new Color(0, 0, 0, 255);

	// Use this for initialization
	void Start () {
		UIVP.text = "122";
	}

	public void SetVP(int vp) {
		if(vp <= 0) {
			UIVP.text = "0";
			UIVP.color = colorRed;
		} else {
			UIVP.text = vp.ToString();
			UIVP.color = colorBlack;
		}
	}
	
}