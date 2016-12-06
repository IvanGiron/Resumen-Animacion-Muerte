using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControlMonedas : MonoBehaviour {


	private int monedas = 0;
	Text Texto;

	void Start(){
		Texto = GetComponent<Text> ();
		resetear ();
		sumaMonedas (10);
	}

	public void sumaMonedas(int cantidad){
		monedas = monedas + cantidad; // o tambien: monedas += cantidad;
		if (monedas < 0){
			monedas = 0;
		} 

		Texto.text = monedas.ToString ();
	}

	public void resetear(){
		monedas = 0;
		Texto.text = monedas.ToString ();
	}

}
