using UnityEngine;
using System.Collections;

public class AutodestruccionParticulas : MonoBehaviour {

	ParticleSystem sistemaParticulas;
	// Use this for initialization
	void Start () {
		sistemaParticulas = GetComponent<ParticleSystem>();
		Destroy (gameObject, sistemaParticulas.duration);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
