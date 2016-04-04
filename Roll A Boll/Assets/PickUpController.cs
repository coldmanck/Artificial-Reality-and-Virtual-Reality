using UnityEngine;
using System.Collections;

public class PickUpController : MonoBehaviour {

	public ParticleSystem smoke;

	// Use this for initialization
	void Start () {
		smoke = GetComponent<ParticleSystem> ();
//		smoke.Stop ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Player")) {
			smoke.Play ();
			this.gameObject.SetActive (false);	
		}
	}
}
