using System;
using UnityEngine;

public class Prospector : ParentRole {

	public void Prospect(Player player, UICentralBoard UICentralBoard) {
		Debug.Log("BuscadorDeOro accion()");
		// Si hay monedas en el banco
		if(GameData.bankCoins > 0) {
			Debug.Log("monedasBanco " + GameData.bankCoins + " -> " + (GameData.bankCoins-1));
			Debug.Log("jugador monedas " + player.playerBoard.coins + " -> " + (player.playerBoard.coins+1));
			GameData.bankCoins--;
			player.playerBoard.coins++;

			// UI
			UICentralBoard.UICoins.text = GameData.bankCoins.ToString();
			player.UIPlayerBoard.GetComponent<UIPlayerBoard>().UICoins.text = player.playerBoard.coins.ToString();
		} else {
			Debug.Log("NO hay monedas en el banco, se queda sin");
		}
		Debug.Log("BuscadorDeOro FIN accion()");
	}

}