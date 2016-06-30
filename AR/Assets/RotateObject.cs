using UnityEngine;
using System.Collections.Generic;
using System;
using Vuforia;

public class RotateObject : MonoBehaviour {

	public GameObject[] gameObejctsArray;
	public Bounds bounds;
	public float speed = 30.0f;

	public Collider target;

	private bool m_StartRotating;
	public bool StartRotating
	{
		get { return m_StartRotating; }
		set { m_StartRotating = value; }
	}

	void Awake()
	{
		m_Instance = this;
	}

	void Update()
	{
		if(target.enabled)
		{
			transform.Rotate(Vector3.up * speed * Time.deltaTime);
		}
	}

	// Singleton methods 
	private static RotateObject m_Instance = null;

	private RotateObject() { }

	public static RotateObject Instance
	{
		get { return m_Instance; }
	}

//	// Use this for initialization
//	void Start () {
//		var collider = gameObject.GetComponent<BoxCollider> ();
//		if (collider == null) {
//			collider = gameObject.AddComponent<BoxCollider>();
//			Debug.Log("No Collider is Detected");
//		}
//		bounds = collider.bounds;
//	}
	
//	// Update is called once per frame
//	void Update () {
//	
//	}
}
