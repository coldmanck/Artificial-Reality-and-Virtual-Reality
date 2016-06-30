using UnityEngine;
using System.Collections;

public class Hunt : MonoBehaviour {

	public GameObject[] allObjects = new GameObject[7];

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Hunting(int id){
		if (id == 0)
			gameObject.SetActive (false);
		else {
			for (int i = 0; i < id; ++i) {
				if (allObjects [i].activeInHierarchy) {
					ResetAll ();
					break;
				} else
					gameObject.SetActive (false);
			}
		}
	}

	public void ResetAll(){
		for (int i = 0; i < allObjects.Length; ++i) {
			allObjects [i].SetActive (true);
			allObjects [i].GetComponent<Renderer>().material.color = Color.red;
		}
	}
}
