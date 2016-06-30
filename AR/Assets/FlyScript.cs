using UnityEngine;
using System.Collections.Generic;
using System;
using Vuforia;

public class FlyScript : MonoBehaviour {

	public GameObject[] gameObejctsArray;
	public Bounds bounds;
	public float speed = 200.0f;

	private bool m_StartFlying;
	public bool StartFlying
	{
		get { return m_StartFlying; }
		set { m_StartFlying = value; }
	}

	void Awake()
	{
		m_Instance = this;
	}

	void Update()
	{
		if(m_StartFlying)
		{
			IEnumerable<TrackableBehaviour> trackableBehaviours = TrackerManager.Instance.GetStateManager().GetActiveTrackableBehaviours();
			int i = 0;
			foreach (TrackableBehaviour trackableBehaviour in trackableBehaviours) {
				gameObejctsArray [i++] = trackableBehaviour.gameObject;
			}

			foreach(GameObject go in gameObejctsArray)
			{
				// go.transform.Rotate(Vector3.right * Time.deltaTime * 10);
				// go.transform.Rotate(Vector3.up * speed * Time.deltaTime);
			}
			transform.Rotate(Vector3.up * speed * Time.deltaTime);

		}
	}

	// Singleton methods 
	private static FlyScript m_Instance = null;

	private FlyScript() { }

	public static FlyScript Instance
	{
		get { return m_Instance; }
	}

}
