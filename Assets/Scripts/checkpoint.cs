using UnityEngine;
using System.Collections;

public class checkpoint : MonoBehaviour {
	
	private gameControlScript gameCS;
	public Sprite banderaOn;
	private bool activada = false;
	// Use this for initialization
	void Start () {
		gameCS = GameObject.Find ("GameControl").GetComponent<gameControlScript>();//buscar el objeto que tiene el script y cogemos su script
	}
	void OnTriggerEnter2D(Collider2D objeto){
		if (objeto.tag == "Player" && !activada) { //preguntar si no esta activada y luego activarlo es que solo lo va a hacer una vez
			GetComponent<SpriteRenderer> ().sprite = banderaOn;
			gameCS.checkpoint (transform.position);
			activada = true;
		}
	
}

}
