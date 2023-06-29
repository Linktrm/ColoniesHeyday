using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIRoleBoard : MonoBehaviour {

	public GameObject UIRoleBuilder;
	public GameObject UIRoleCaptain;
	public GameObject UIRoleCraftsman;
	public GameObject UIRoleMayor;
	public GameObject UIRoleSettler;
	public GameObject UIRoleTrader;
	public GameObject UIRoleProspector1;
	public GameObject UIRoleProspector2;

	public GameObject UIFrameBuilder;
	public GameObject UIFrameCaptain;
	public GameObject UIFrameCraftsman;
	public GameObject UIFrameMayor;
	public GameObject UIFrameSettler;
	public GameObject UIFrameTrader;
	public GameObject UIFrameProspector1;
	public GameObject UIFrameProspector2;

	public GameObject UIPanelCoinsBuilder;
	public GameObject UIPanelCoinsCaptain;
	public GameObject UIPanelCoinsCraftsman;
	public GameObject UIPanelCoinsMayor;
	public GameObject UIPanelCoinsSettler;
	public GameObject UIPanelCoinsTrader;
	public GameObject UIPanelCoinsProspector1;
	public GameObject UIPanelCoinsProspector2;

	public Text UICoinsBuilder;
	public Text UICoinsCaptain;
	public Text UICoinsCraftsman;
	public Text UICoinsMayor;
	public Text UICoinsSettler;
	public Text UICoinsTrader;
	public Text UICoinsProspector1;
	public Text UICoinsProspector2;

	public Sprite UIRoleFrame;
	public Sprite UIRoleFrameTransparent;

	public RoleTypes roleSelected { get; set; }

	public virtual void SelectFirstRoleAvailable() {}

	public virtual InputType MoveCursor(InputType inputX, InputType inputY, int playerController) {
		return InputManager.GetIdle(playerController);
	}

	protected void SelectRole(RoleTypes roleType, GameObject UIFrame) {
		DeselectFrameRoles();
		UIFrame.GetComponent<Image>().sprite = UIRoleFrame;
		roleSelected = roleType;
		Debug.Log("Role seleccionado: " + roleSelected);
	}

	protected virtual void DeselectFrameRoles() {}

	public virtual void ActivateRole(Role role) {}

	public virtual void RefreshCoins(Role role) {}
}