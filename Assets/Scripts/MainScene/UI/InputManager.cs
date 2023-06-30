using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputManager {

	// X Axis (Horizontal)

	static InputType Player1Horizontal() {
		float r = 0f;
		r += Input.GetAxis("XAxis_J1");
		r += Input.GetAxis("XAxis2_J1");
		r += Input.GetAxis("Horizontal");
		r = Mathf.Clamp(r, -1f, 1f);
		if(r > 0) {
			return InputType.PLAYER1_RIGHT;
		} else if(r < 0) {
			return InputType.PLAYER1_LEFT;
		}
		return InputType.PLAYER1_IDLE;
	}

	static InputType Player2Horizontal() {
		float r = 0f;
		r += Input.GetAxis("XAxis_J2");
		r += Input.GetAxis("XAxis2_J2");
		r += Input.GetAxis("Horizontal");
		r = Mathf.Clamp(r, -1f, 1f);
		if(r > 0) {
			return InputType.PLAYER2_RIGHT;
		} else if(r < 0) {
			return InputType.PLAYER2_LEFT;
		}
		return InputType.PLAYER2_IDLE;
	}

	static InputType Player3Horizontal() {
		float r = 0f;
		r += Input.GetAxis("XAxis_J3");
		r += Input.GetAxis("XAxis2_J3");
		r += Input.GetAxis("Horizontal");
		r = Mathf.Clamp(r, -1f, 1f);
		if(r > 0) {
			return InputType.PLAYER3_RIGHT;
		} else if(r < 0) {
			return InputType.PLAYER3_LEFT;
		}
		return InputType.PLAYER3_IDLE;
	}

	static InputType Player4Horizontal() {
		float r = 0f;
		r += Input.GetAxis("XAxis_J4");
		r += Input.GetAxis("XAxis2_J4");
		r += Input.GetAxis("Horizontal");
		r = Mathf.Clamp(r, -1f, 1f);
		if(r > 0) {
			return InputType.PLAYER4_RIGHT;
		} else if(r < 0) {
			return InputType.PLAYER4_LEFT;
		}
		return InputType.PLAYER4_IDLE;
	}

	static InputType Player5Horizontal() {
		float r = 0f;
		r += Input.GetAxis("XAxis_J5");
		r += Input.GetAxis("XAxis2_J5");
		r += Input.GetAxis("Horizontal");
		r = Mathf.Clamp(r, -1f, 1f);
		if(r > 0) {
			return InputType.PLAYER5_RIGHT;
		} else if(r < 0) {
			return InputType.PLAYER5_LEFT;
		}
		return InputType.PLAYER5_IDLE;
	}

	public static InputType Horizontal(int controller, InputType input) {
		// Debug.Log("========> CALCULAMOS HORIZONTAL");
		switch(controller) {
			case 1:
				// Si no está en estado DONE (botón mantenido), ejecuta la acción direccional
				if(input != InputType.PLAYER1_DONE) {
					// Debug.Log("El input no es DONE, así que devuelvo el valor horizontal " + Player1Horizontal());
					return Player1Horizontal();
				} else {
					// Debug.Log("El input horizontal es DONE");
					// Si el jugador sigue manteniendo el botón y no es IDLE, seguirá retornando DONE
					if(Player1Horizontal() != InputType.PLAYER1_IDLE) {
						// Debug.Log("El usuario está manteniendo la dirección horizontal " + Player1Horizontal() + " así que sigo devolviendo DONE");
						return InputType.PLAYER1_DONE;
					}
					// Si el jugador ha soltado el botón, devuelve IDLE
					// Debug.Log("El usuario ha soltado el botón horizontal, devuelvo IDLE");
					return InputType.PLAYER1_IDLE;
				}
			case 2:
				// Si no está en estado DONE (botón mantenido), ejecuta la acción direccional
				if(input != InputType.PLAYER2_DONE) {
					//Debug.Log("El input no es DONE, así que devuelvo el valor horizontal " + Player2Horizontal());
					return Player2Horizontal();
				} else {
					//Debug.Log("El input horizontal es DONE");
					// Si el jugador sigue manteniendo el botón y no es IDLE, seguirá retornando DONE
					if(Player2Horizontal() != InputType.PLAYER2_IDLE) {
						//Debug.Log("El usuario está manteniendo la dirección horizontal " + Player2Horizontal() + " así que sigo devolviendo DONE");
						return InputType.PLAYER2_DONE;
					}
					// Si el jugador ha soltado el botón, devuelve IDLE
					//Debug.Log("El usuario ha soltado el botón horizontal, devuelvo IDLE");
					return InputType.PLAYER2_IDLE;
				}
			case 3:
				// Si no está en estado DONE (botón mantenido), ejecuta la acción direccional
				if(input != InputType.PLAYER3_DONE) {
					//Debug.Log("El input no es DONE, así que devuelvo el valor horizontal " + Player3Horizontal());
					return Player3Horizontal();
				} else {
					//Debug.Log("El input horizontal es DONE");
					// Si el jugador sigue manteniendo el botón y no es IDLE, seguirá retornando DONE
					if(Player3Horizontal() != InputType.PLAYER3_IDLE) {
						//Debug.Log("El usuario está manteniendo la dirección horizontal " + Player3Horizontal() + " así que sigo devolviendo DONE");
						return InputType.PLAYER3_DONE;
					}
					// Si el jugador ha soltado el botón, devuelve IDLE
					//Debug.Log("El usuario ha soltado el botón horizontal, devuelvo IDLE");
					return InputType.PLAYER3_IDLE;
				}
			case 4:
				// Si no está en estado DONE (botón mantenido), ejecuta la acción direccional
				if(input != InputType.PLAYER4_DONE) {
					//Debug.Log("El input no es DONE, así que devuelvo el valor horizontal " + Player4Horizontal());
					return Player4Horizontal();
				} else {
					//Debug.Log("El input horizontal es DONE");
					// Si el jugador sigue manteniendo el botón y no es IDLE, seguirá retornando DONE
					if(Player4Horizontal() != InputType.PLAYER4_IDLE) {
						//Debug.Log("El usuario está manteniendo la dirección horizontal " + Player4Horizontal() + " así que sigo devolviendo DONE");
						return InputType.PLAYER4_DONE;
					}
					// Si el jugador ha soltado el botón, devuelve IDLE
					//Debug.Log("El usuario ha soltado el botón horizontal, devuelvo IDLE");
					return InputType.PLAYER4_IDLE;
				}
			case 5:
				// Si no está en estado DONE (botón mantenido), ejecuta la acción direccional
				if(input != InputType.PLAYER5_DONE) {
					//Debug.Log("El input no es DONE, así que devuelvo el valor horizontal " + Player5Horizontal());
					return Player5Horizontal();
				} else {
					//Debug.Log("El input horizontal es DONE");
					// Si el jugador sigue manteniendo el botón y no es IDLE, seguirá retornando DONE
					if(Player5Horizontal() != InputType.PLAYER5_IDLE) {
						//Debug.Log("El usuario está manteniendo la dirección horizontal " + Player5Horizontal() + " así que sigo devolviendo DONE");
						return InputType.PLAYER5_DONE;
					}
					// Si el jugador ha soltado el botón, devuelve IDLE
					//Debug.Log("El usuario ha soltado el botón horizontal, devuelvo IDLE");
					return InputType.PLAYER5_IDLE;
				}
		}
		return GetIdle(controller); // No se va a dar el caso
	}

	// Y Axis (Vertical)

	static InputType Player1Vertical() {
		float r = 0f;
		r += Input.GetAxis("YAxis_J1");
		r += Input.GetAxis("YAxis2_J1");
		r += Input.GetAxis("Vertical");
		r = Mathf.Clamp(r, -1f, 1f);
		if(r > 0) {
			return InputType.PLAYER1_UP;
		} else if(r < 0) {
			return InputType.PLAYER1_DOWN;
		}
		return InputType.PLAYER1_IDLE;
	}

	static InputType Player2Vertical() {
		float r = 0f;
		r += Input.GetAxis("YAxis_J2");
		r += Input.GetAxis("YAxis2_J2");
		r += Input.GetAxis("Vertical");
		r = Mathf.Clamp(r, -1f, 1f);
		if(r > 0) {
			return InputType.PLAYER2_UP;
		} else if(r < 0) {
			return InputType.PLAYER2_DOWN;
		}
		return InputType.PLAYER2_IDLE;
	}

	static InputType Player3Vertical() {
		float r = 0f;
		r += Input.GetAxis("YAxis_J3");
		r += Input.GetAxis("YAxis2_J3");
		r += Input.GetAxis("Vertical");
		r = Mathf.Clamp(r, -1f, 1f);
		if(r > 0) {
			return InputType.PLAYER3_UP;
		} else if(r < 0) {
			return InputType.PLAYER3_DOWN;
		}
		return InputType.PLAYER3_IDLE;
	}

	static InputType Player4Vertical() {
		float r = 0f;
		r += Input.GetAxis("YAxis_J4");
		r += Input.GetAxis("YAxis2_J4");
		r += Input.GetAxis("Vertical");
		r = Mathf.Clamp(r, -1f, 1f);
		if(r > 0) {
			return InputType.PLAYER4_UP;
		} else if(r < 0) {
			return InputType.PLAYER4_DOWN;
		}
		return InputType.PLAYER4_IDLE;
	}

	static InputType Player5Vertical() {
		float r = 0f;
		r += Input.GetAxis("YAxis_J5");
		r += Input.GetAxis("YAxis2_J5");
		r += Input.GetAxis("Vertical");
		r = Mathf.Clamp(r, -1f, 1f);
		if(r > 0) {
			return InputType.PLAYER5_UP;
		} else if(r < 0) {
			return InputType.PLAYER5_DOWN;
		}
		return InputType.PLAYER5_IDLE;
	}

	public static InputType Vertical(int controller, InputType input) {
		// Debug.Log("========> CALCULAMOS VERTICAL");
		switch(controller) {
			case 1:
				// Si no está en estado DONE (botón mantenido), ejecuta la acción direccional
				if(input != InputType.PLAYER1_DONE) {
					InputType horizontalValue = Horizontal(controller, InputType.PLAYER1_IDLE);
					if(horizontalValue != InputType.PLAYER1_IDLE) {
						// Debug.Log("El input es Horizontal, devuelvo lo que era = " + horizontalValue);
						return horizontalValue;
					}
					// Debug.Log("El input no es DONE ni Horizontal, así que devuelvo el valor Vertical " + Player1Vertical());
					return Player1Vertical();
				} else {
					// Debug.Log("El input vertical es DONE");
					// Si el jugador sigue manteniendo el botón y no es IDLE, seguirá retornando DONE
					if(Player1Vertical() != InputType.PLAYER1_IDLE) {
						// Debug.Log("El usuario está manteniendo la dirección vertical " + Player1Vertical() + " así que sigo devolviendo DONE");
						return InputType.PLAYER1_DONE;
					}
					// Si el jugador ha soltado el botón, devuelve IDLE
					// Debug.Log("El usuario ha soltado el botón vertical, devuelvo IDLE");
					return InputType.PLAYER1_IDLE;
				}
			case 2:
				// Si no está en estado DONE (botón mantenido), ejecuta la acción direccional
				if(input != InputType.PLAYER2_DONE) {
					InputType horizontalValue = Horizontal(controller, InputType.PLAYER2_IDLE);
					if(horizontalValue != InputType.PLAYER2_IDLE) {
						//Debug.Log("El input es Horizontal, devuelvo lo que era = " + horizontalValue);
						return horizontalValue;
					}
					//Debug.Log("El input no es DONE ni Horizontal, así que devuelvo el valor Vertical " + Player2Vertical());
					return Player2Vertical();
				} else {
					//Debug.Log("El input vertical es DONE");
					// Si el jugador sigue manteniendo el botón y no es IDLE, seguirá retornando DONE
					if(Player2Vertical() != InputType.PLAYER2_IDLE) {
						//Debug.Log("El usuario está manteniendo la dirección vertical " + Player2Vertical() + " así que sigo devolviendo DONE");
						return InputType.PLAYER2_DONE;
					}
					// Si el jugador ha soltado el botón, devuelve IDLE
					//Debug.Log("El usuario ha soltado el botón vertical, devuelvo IDLE");
					return InputType.PLAYER2_IDLE;
				}
			case 3:
				// Si no está en estado DONE (botón mantenido), ejecuta la acción direccional
				if(input != InputType.PLAYER3_DONE) {
					InputType horizontalValue = Horizontal(controller, InputType.PLAYER3_IDLE);
					if(horizontalValue != InputType.PLAYER3_IDLE) {
						//Debug.Log("El input es Horizontal, devuelvo lo que era = " + horizontalValue);
						return horizontalValue;
					}
					//Debug.Log("El input no es DONE ni Horizontal, así que devuelvo el valor Vertical " + Player3Vertical());
					return Player3Vertical();
				} else {
					//Debug.Log("El input vertical es DONE");
					// Si el jugador sigue manteniendo el botón y no es IDLE, seguirá retornando DONE
					if(Player3Vertical() != InputType.PLAYER3_IDLE) {
						//Debug.Log("El usuario está manteniendo la dirección vertical " + Player3Vertical() + " así que sigo devolviendo DONE");
						return InputType.PLAYER3_DONE;
					}
					// Si el jugador ha soltado el botón, devuelve IDLE
					//Debug.Log("El usuario ha soltado el botón vertical, devuelvo IDLE");
					return InputType.PLAYER3_IDLE;
				}
			case 4:
				// Si no está en estado DONE (botón mantenido), ejecuta la acción direccional
				if(input != InputType.PLAYER4_DONE) {
					InputType horizontalValue = Horizontal(controller, InputType.PLAYER4_IDLE);
					if(horizontalValue != InputType.PLAYER4_IDLE) {
						//Debug.Log("El input es Horizontal, devuelvo lo que era = " + horizontalValue);
						return horizontalValue;
					}
					//Debug.Log("El input no es DONE ni Horizontal, así que devuelvo el valor Vertical " + Player4Vertical());
					return Player4Vertical();
				} else {
					//Debug.Log("El input vertical es DONE");
					// Si el jugador sigue manteniendo el botón y no es IDLE, seguirá retornando DONE
					if(Player4Vertical() != InputType.PLAYER4_IDLE) {
						//Debug.Log("El usuario está manteniendo la dirección vertical " + Player4Vertical() + " así que sigo devolviendo DONE");
						return InputType.PLAYER4_DONE;
					}
					// Si el jugador ha soltado el botón, devuelve IDLE
					//Debug.Log("El usuario ha soltado el botón vertical, devuelvo IDLE");
					return InputType.PLAYER4_IDLE;
				}
			case 5:
				// Si no está en estado DONE (botón mantenido), ejecuta la acción direccional
				if(input != InputType.PLAYER5_DONE) {
					InputType horizontalValue = Horizontal(controller, InputType.PLAYER5_IDLE);
					if(horizontalValue != InputType.PLAYER5_IDLE) {
						//Debug.Log("El input es Horizontal, devuelvo lo que era = " + horizontalValue);
						return horizontalValue;
					}
					//Debug.Log("El input no es DONE ni Horizontal, así que devuelvo el valor Vertical " + Player5Vertical());
					return Player5Vertical();
				} else {
					//Debug.Log("El input vertical es DONE");
					// Si el jugador sigue manteniendo el botón y no es IDLE, seguirá retornando DONE
					if(Player5Vertical() != InputType.PLAYER5_IDLE) {
						//Debug.Log("El usuario está manteniendo la dirección vertical " + Player5Vertical() + " así que sigo devolviendo DONE");
						return InputType.PLAYER5_DONE;
					}
					// Si el jugador ha soltado el botón, devuelve IDLE
					//Debug.Log("El usuario ha soltado el botón vertical, devuelvo IDLE");
					return InputType.PLAYER5_IDLE;
				}
		}
		return GetIdle(controller);
	}

	// Submit (Confirm)

	static bool Player1Submit() {
		if(Input.GetButtonDown("Submit_J1"))
			return true;
		if(Input.GetButtonDown("Submit_Key"))
			return true;
		return false;
	}

	static bool Player2Submit() {
		if(Input.GetButtonDown("Submit_J2"))
			return true;
		if(Input.GetButtonDown("Submit_Key"))
			return true;
		return false;
	}

	static bool Player3Submit() {
		if(Input.GetButtonDown("Submit_J3"))
			return true;
		if(Input.GetButtonDown("Submit_Key"))
			return true;
		return false;
	}

	static bool Player4Submit() {
		if(Input.GetButtonDown("Submit_J4"))
			return true;
		if(Input.GetButtonDown("Submit_Key"))
			return true;
		return false;
	}

	static bool Player5Submit() {
		if(Input.GetButtonDown("Submit_J5"))
			return true;
		if(Input.GetButtonDown("Submit_Key"))
			return true;
		return false;
	}

	public static bool Submit(int controller) {
		switch(controller) {
			case 1:
				return Player1Submit();
			case 2:
				return Player2Submit();
			case 3:
				return Player3Submit();
			case 4:
				return Player4Submit();
			case 5:
				return Player5Submit();
		}
		return Player1Submit();
	}

	// Cancel

	static bool Player1Cancel() {
		if(Input.GetButtonDown("Cancel_J1"))
			return true;
		if(Input.GetButtonDown("Cancel_Key"))
			return true;
		return false;
	}

	static bool Player2Cancel() {
		if(Input.GetButtonDown("Cancel_J2"))
			return true;
		if(Input.GetButtonDown("Cancel_Key"))
			return true;
		return false;
	}

	static bool Player3Cancel() {
		if(Input.GetButtonDown("Cancel_J3"))
			return true;
		if(Input.GetButtonDown("Cancel_Key"))
			return true;
		return false;
	}

	static bool Player4Cancel() {
		if(Input.GetButtonDown("Cancel_J4"))
			return true;
		if(Input.GetButtonDown("Cancel_Key"))
			return true;
		return false;
	}

	static bool Player5Cancel() {
		if(Input.GetButtonDown("Cancel_J5"))
			return true;
		if(Input.GetButtonDown("Cancel_Key"))
			return true;
		return false;
	}

	public static bool Cancel(int controller) {
		switch(controller) {
			case 1:
				return Player1Cancel();
			case 2:
				return Player2Cancel();
			case 3:
				return Player3Cancel();
			case 4:
				return Player4Cancel();
			case 5:
				return Player5Cancel();
		}
		return Player1Cancel();
	}

	// Start

	static bool Player1Start() {
		if(Input.GetButtonDown("Start_J1"))
			return true;
		if(Input.GetButtonDown("Start_Key"))
			return true;
		return false;
	}

	static bool Player2Start() {
		if(Input.GetButtonDown("Start_J2"))
			return true;
		if(Input.GetButtonDown("Start_Key"))
			return true;
		return false;
	}

	static bool Player3Start() {
		if(Input.GetButtonDown("Start_J3"))
			return true;
		if(Input.GetButtonDown("Start_Key"))
			return true;
		return false;
	}

	static bool Player4Start() {
		if(Input.GetButtonDown("Start_J4"))
			return true;
		if(Input.GetButtonDown("Start_Key"))
			return true;
		return false;
	}

	static bool Player5Start() {
		if(Input.GetButtonDown("Start_J5"))
			return true;
		if(Input.GetButtonDown("Start_Key"))
			return true;
		return false;
	}

	public static bool Start(int controller) {
		switch(controller) {
			case 1:
				return Player1Start();
			case 2:
				return Player2Start();
			case 3:
				return Player3Start();
			case 4:
				return Player4Start();
			case 5:
				return Player5Start();
		}
		return Player1Start();
	}

	public static InputType GetDone(int controller) {
		switch(controller) {
			case 1:
				return InputType.PLAYER1_DONE;
			case 2:
				return InputType.PLAYER2_DONE;
			case 3:
				return InputType.PLAYER3_DONE;
			case 4:
				return InputType.PLAYER4_DONE;
			case 5:
				return InputType.PLAYER5_DONE;
		}
		return InputType.PLAYER1_DONE;
	}

	public static InputType GetIdle(int controller) {
		switch(controller) {
			case 1:
				return InputType.PLAYER1_IDLE;
			case 2:
				return InputType.PLAYER2_IDLE;
			case 3:
				return InputType.PLAYER3_IDLE;
			case 4:
				return InputType.PLAYER4_IDLE;
			case 5:
				return InputType.PLAYER5_IDLE;
		}
		return InputType.PLAYER1_IDLE;
	}

	public static InputType GetLeft(int controller) {
		switch(controller) {
			case 1:
				return InputType.PLAYER1_LEFT;
			case 2:
				return InputType.PLAYER2_LEFT;
			case 3:
				return InputType.PLAYER3_LEFT;
			case 4:
				return InputType.PLAYER4_LEFT;
			case 5:
				return InputType.PLAYER5_LEFT;
		}
		return InputType.PLAYER1_LEFT;
	}

	public static InputType GetRight(int controller) {
		switch(controller) {
			case 1:
				return InputType.PLAYER1_RIGHT;
			case 2:
				return InputType.PLAYER2_RIGHT;
			case 3:
				return InputType.PLAYER3_RIGHT;
			case 4:
				return InputType.PLAYER4_RIGHT;
			case 5:
				return InputType.PLAYER5_RIGHT;
		}
		return InputType.PLAYER1_RIGHT;
	}

	public static InputType GetUp(int controller) {
		switch(controller) {
			case 1:
				return InputType.PLAYER1_UP;
			case 2:
				return InputType.PLAYER2_UP;
			case 3:
				return InputType.PLAYER3_UP;
			case 4:
				return InputType.PLAYER4_UP;
			case 5:
				return InputType.PLAYER5_UP;
		}
		return InputType.PLAYER1_UP;
	}

	public static InputType GetDown(int controller) {
		switch(controller) {
			case 1:
				return InputType.PLAYER1_DOWN;
			case 2:
				return InputType.PLAYER2_DOWN;
			case 3:
				return InputType.PLAYER3_DOWN;
			case 4:
				return InputType.PLAYER4_DOWN;
			case 5:
				return InputType.PLAYER5_DOWN;
		}
		return InputType.PLAYER1_DOWN;
	}

	public static InputType CalculateIdle(int controller, InputType input) {
		// Debug.Log("CalculateIdle");
		// Debug.Log("input = " + input);
		InputType idle = GetIdle(controller);
		InputType done = GetDone(controller);
		InputType horizontal = Horizontal(controller, input);
		InputType vertical = Vertical(controller, input);
		// Si no es DONE y hay input XY, devuelvo ese input
		if(input != done && (horizontal != idle || vertical != idle)) {
			if(horizontal != idle)
				input = horizontal;
			else if(vertical != idle)
				input = vertical;
			// Debug.Log("****INPUT XY, devuelvo " + input);
			return input;
		} else if(input == done && (horizontal != idle || vertical != idle)) {
			// Si es DONE y hay input XY, sigo devolviendo DONE, porque sigue apretando y no ha soltado
			// Debug.Log("****INPUT DONE y sigue aprentando, devuelvo DONE");
			return done;
		}
		
		// Si no hay input horizontal o vertical, devuelvo IDLE, da igual el DONE
		// Debug.Log("****NO INPUT XY, devuelvo IDLE");
		return idle;
	}

}