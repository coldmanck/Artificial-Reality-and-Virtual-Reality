using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	private int count;
	private Rigidbody rb;

	public float speed;
	public Text countText, winText;
//	public AudioClip pointSound;
	public AudioSource audio1, audio2;

	// Use this for initialization
	void Start () {
		audio1 = GetComponent<AudioSource>();
		audio2 = GetComponent<AudioSource>();
		rb = GetComponent<Rigidbody> ();
		count = 0;
		SetCountText ();
		winText.text = "";
	}

	void FixedUpdate(){
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Pick Up")) {
//			GameObject s = (GameObject)Instantiate(Smoke, transform.position, Quarternion.identity);
//			Destroy (s, 0.5);

			count += 1;
			SetCountText ();
			audio1.Play();

		}
	}

	void SetCountText(){
		countText.text = "Count: " + count.ToString ();
		if(count == 8)
			winText.text = "You Win!";
	}
}
