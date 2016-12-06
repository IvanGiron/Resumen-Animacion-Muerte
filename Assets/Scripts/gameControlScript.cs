using UnityEngine;
using System.Collections;

public class gameControlScript : MonoBehaviour {


	private Vector3 puntoInicio;
	public GameObject player;
	public bool estaVivo = true;



	// Use this for initialization
	void Start () {
		puntoInicio = player.transform.position;
	}

	public void respaw(){
		player.transform.position = puntoInicio; //el punto de del personaje es el punto de inciio
	}
	
	public void checkpoint(Vector3 nuevoPunto){
		puntoInicio = nuevoPunto;
	
	}
}
