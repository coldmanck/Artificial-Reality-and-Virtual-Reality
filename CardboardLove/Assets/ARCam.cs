using UnityEngine;
using System.Collections;

public class ARCam : MonoBehaviour {

	private WebCamTexture mCamera;
	public Renderer myRenderer;

	// Use this for initialization
	void Start () {
		mCamera = new WebCamTexture ();
		myRenderer.material.mainTexture = mCamera;

		mCamera.Play ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
