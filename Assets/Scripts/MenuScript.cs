using UnityEngine;
using System.Collections;

[RequireComponent (typeof(Animator))]

public class MenuScript : MonoBehaviour {
	Animator anim;
	private bool menuPausa = false;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (menuPausa) {
				continuar ();
			} else {
				pausa ();
			}
		}
	}

	public void pausa() {
		menuPausa = true;
		anim.SetBool ("opciones", false);
		anim.SetBool ("Pausa", true);
		Time.timeScale = 0f;
	}

	public void salir(){
		Application.Quit ();
		Debug.Log ("Saliendo");
	}

	public void opciones(){
		anim.SetBool ("Pausa", true);
		anim.SetBool ("opciones", true);
	}
	public void continuar(){
		menuPausa = false;
		anim.SetBool ("Pausa", false);
		anim.SetBool ("opciones", false);
		Time.timeScale = 1f;
	}
}
