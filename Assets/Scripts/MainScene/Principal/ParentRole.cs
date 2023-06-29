using UnityEngine;
using UnityEngine.UI;

public class ParentRole {
	public void AddStackedCoins(Player rolePlayer, GameObject UIPanelCoinsRole, Text UIRoleCoinsText) {
		if(GameData.actualRole.stackedCoins > 0) {
			Debug.Log("Sumamos monedas acumuladas del Role");
			Debug.Log("Jugador monedas " + rolePlayer.playerBoard.coins + " -> " + (rolePlayer.playerBoard.coins + GameData.actualRole.stackedCoins));
			rolePlayer.playerBoard.coins += GameData.actualRole.stackedCoins;
			GameData.actualRole.stackedCoins = 0;
			// UI
			rolePlayer.UIPlayerBoard.GetComponent<UIPlayerBoard>().UICoins.text = rolePlayer.playerBoard.coins.ToString();
			UIRoleCoinsText.text = "0";
			UIPanelCoinsRole.SetActive(false);
		}
	}
}
