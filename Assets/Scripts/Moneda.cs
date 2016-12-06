using UnityEngine;
using System.Collections;

public class Moneda : MonoBehaviour {
	private Rigidbody2D rigi;
	GameObject txtMoneda;
	ControlMonedas ctrl_moneda;
	public int suma;
	// Use this for initialization
	void Start () {
		rigi = GetComponent<Rigidbody2D>();
		Destroy (gameObject, 10); // sE DESTRUYE A LOS 3 SEGUNDOS
		rigi.AddForce (new Vector2(Random.Range(-100, 100),100));
		txtMoneda = GameObject.Find ("TextoMoneda"); //busca los objetos en la escena y el del nombre lo mete
		ctrl_moneda = txtMoneda.GetComponent<ControlMonedas>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Player") {
			Destroy (gameObject);
			ctrl_moneda.sumaMonedas (suma);
			 // Se destruye a 1 segundo de tocarla

		}
	}
}
