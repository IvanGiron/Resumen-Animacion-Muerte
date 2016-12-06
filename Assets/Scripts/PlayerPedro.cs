using UnityEngine;
using System.Collections;

public class PlayerPedro : MonoBehaviour {


	public float velocidad = 5f;
	public float fsalto = 1f;
	public bool tocandoSuelo = false;
	private Animator animator;
	private Rigidbody2D rb;
	private gameControlScript gameCS;
	public GameObject particulasMuerte;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody2D> ();
		gameCS = GameObject.Find ("GameControl").GetComponent<gameControlScript>();//buscar el objeto que tiene el script y cogemos su script
		}
	
	// Update is called once per frame
	void Update () {
		animator.SetFloat ("velocidad", Mathf.Abs(rb.velocity.x));//Funcion en el animatio llamada velocidad y devuelveme el valor absoluto para que vaya la animacion en los 2 ejes
		if (Input.GetKey ("right")) 
		{
			rb.velocity = new Vector2 (velocidad,rb.velocity.y);
			transform.localScale= new Vector3(1,1,1);

		}

		else if (Input.GetKey ("left")) 
		{
			rb.velocity = new Vector2 (-velocidad,rb.velocity.y);
			transform.localScale= new Vector3(-1,1,1);	

		}

		if (Input.GetKeyDown (KeyCode.Space) && tocandoSuelo) {
			animator.SetBool  ("jump", true);
			rb.AddForce (transform.up*fsalto);
		
		}

		if (Input.GetKeyUp (KeyCode.Space)) {
			animator.SetBool ("jump", false);
		}
	
			
	}

	void OnTriggerStay2D(Collider2D objeto){
		if (objeto.tag == "Suelo") {
			tocandoSuelo = true;
		}
	}

	void OnTriggerExit2D(Collider2D objeto){
		if (objeto.tag == "Suelo") {
			tocandoSuelo = false;
		}
	}

	void OnTriggerEnter2D(Collider2D objeto){
		if (objeto.tag == "Suelo") {
			tocandoSuelo = true;
			animator.SetBool ("jump", false);
		}
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Muerte") {
			Invoke ("muerte", 1);
			Instantiate(particulasMuerte, transform.position, transform.rotation);	
	}

}
	void muerte(){
		gameCS.respaw();
	}

}
