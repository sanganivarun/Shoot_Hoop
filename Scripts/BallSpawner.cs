using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour {
	public GameObject ballPrefab;
	public float ballSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float speed = 5.0f;
		if (Input.GetButtonDown ("Fire1")) {
			GameObject instance = Instantiate (ballPrefab);
			Rigidbody rB = instance.GetComponent<Rigidbody> ();
			rB.velocity = Vector3.forward * ballSpeed;
	}
}
}