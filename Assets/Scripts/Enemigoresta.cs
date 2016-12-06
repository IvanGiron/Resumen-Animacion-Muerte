using UnityEngine;
using System.Collections;

public class Enemigoresta : MonoBehaviour {

	private GameObject ranaResta;
	GameObject txtMoneda;
	ControlMonedas ctrl_moneda;
	public int resta;
	// Use this for initialization
	void Start () {
		txtMoneda = GameObject.Find ("TextoMoneda"); //busca los objetos en la escena y el del nombre lo mete
		ctrl_moneda = txtMoneda.GetComponent<ControlMonedas>();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D obj){
		if (obj.tag == "Player" && ranaResta == null) {
			
			ctrl_moneda.sumaMonedas (resta);


		}
	}
}