using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	//public float speed;
	public float moveSpeed = 10;
	public float turnSpeed = 60;
	public Animation anim;
	int jumpHash = Animator.StringToHash("Idle");
	int attack02Hash = Animator.StringToHash("Attack_02");

	private Rigidbody rb;

	void Start () {
		anim = GetComponent<Animation>();
		rb = GetComponent<Rigidbody> ();
	}

	// Use this for initialization
	void Update ()
	{
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
//			anim = Walk;
		}

		if(Input.GetKey(KeyCode.DownArrow))
			transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);

		if(Input.GetKey(KeyCode.LeftArrow))
			transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);

		if(Input.GetKey(KeyCode.RightArrow))
			transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);

		if(Input.GetKey(KeyCode.Space))
			transform.Translate(0, 10*Time.deltaTime, 0);


	}
}

//using UnityEngine;
//using System.Collections;
//
//public class PlayerController : MonoBehaviour {
//
//	private Rigidbody rb;
//
//	public float speed;
//	public float tilt;
//
//	// Use this for initialization
//	void Start () {
//		rb = GetComponent<Rigidbody> ();
//		defaultRotation = rb.rotation;
//	}
//
//	void FixedUpdate(){
//		float moveHorizontal = Input.GetAxis ("Horizontal");
//		float moveVertical = Input.GetAxis ("Vertical");
//
//		Vector3 verticalMovement = new Vector3 (0.0f, 0.0f, moveVertical);
//		rb.position += (verticalMovement.) * speed;
//		//rb.rotation - defaultRotation
//
//		Vector3 horizontalMovement = new Vector3 (0.0f, moveHorizontal, 0.0f);
//		Quaternion deltaRotation = Quaternion.Euler(horizontalMovement);
//		rb.MoveRotation (rb.rotation * deltaRotation);
//
////		rb.MovePosition(movement * speed);
////		rb.AddRelativeForce(movement * speed);
//	}
//}