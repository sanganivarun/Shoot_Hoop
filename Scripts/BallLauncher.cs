using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour {
	public GameObject ballPrefab;
	public float ballSpeed = 5.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			GameObject instance = Instantiate (ballPrefab);
			instance.transform.position = this.transform.position;
			Rigidbody rB = instance.GetComponent<Rigidbody> ();
			Camera camera = GetComponentInChildren<Camera> ();
			rB.velocity = camera.transform.rotation * Vector3.forward * ballSpeed ;
		}
	}
}
