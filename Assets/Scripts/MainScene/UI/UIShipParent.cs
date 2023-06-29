using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class UIParentShip : MonoBehaviour {

	public abstract void Refresh(int barrels, PlantationType type);
	public abstract void ClearShip();

}