using System;
using UnityEngine;

public class Player {

	public String nickname { get; set; }
	// TODO public File avatar { get; set; }
	public DatosPartidaJugador datosPartidaJugador { get; set; }
	//public EstadisticasGlobales estadisticasGlobales { get; set; }

	// ================
	// PLAYER SELECTION
	// ================
	public bool selected { get; set; }
	public int controller { get; set; }
	public int playerNumber { get; set; }
	// ================
	
	// =========
	// MAIN GAME
	// =========
	public int position { get; set; }
	public int rolePosition { get; set; }
	public int finalPosition { get; set; }
	public Role actualRole { get; set; }
	public PlayerBoard playerBoard { get; set; }
	// =========

	public GameObject UIPlayerBoard { get; set; }
	
	public Player(String nickname, int controller) {
		//estadisticasGlobales = new EstadisticasGlobales(nombre);
		
		//this.nombre = estadisticasGlobales.Apodo;
		this.nickname = nickname;
		this.controller = controller;
		// TODO this.avatar = new Image rutaAvatar, si no hay, imagen por defecto

		selected = false;
		//controller = -1;
		
		datosPartidaJugador = new DatosPartidaJugador();
		playerBoard = new PlayerBoard();
		finalPosition = 0;
	}
	
}