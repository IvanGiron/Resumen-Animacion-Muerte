using UnityEngine;
using System.Collections;

public class generador : MonoBehaviour {
	public GameObject[] monedas;
	private GameObject monedaNueva;
	private Transform posSalida;
	private int numeroMoneda = 0;
	private Animator anim;
	private int cajaGris = 0;

	// Use this for initialization
	void Start(){
		posSalida = transform.Find ("PosicionSalida").transform;
		anim = GetComponent<Animator> ();

	}


	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Player" && cajaGris < 3 ) {
			numeroMoneda = Random.Range (0, monedas.Length);
			//Instantiate (moneda, transform.position, transform.rotation); // genero Moneda en el mismo sitio de donde esta el collider
			monedaNueva = (GameObject)Instantiate (monedas[numeroMoneda], posSalida.position, transform.rotation);
			anim.SetTrigger ("Golpe");
			cajaGris =+ cajaGris +1;
		}
		if (cajaGris == 3) {
			anim.SetBool ("CajaGris", true);

		}
	}

	void OnTriggerEnter2D(Collider2D objeto){
		if (objeto.tag == "Player" && monedaNueva == null) {
			//Instantiate (moneda, transform.position, transform.rotation); // genero Moneda en el mismo sitio de donde esta el collider
			monedaNueva = (GameObject)Instantiate (monedas[0], transform.position, transform.rotation);
		}
	}
}
