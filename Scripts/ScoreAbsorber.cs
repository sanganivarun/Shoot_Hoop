using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAbsorber : MonoBehaviour {
	public int score;
	// Use this for initialization
	void Start () {
		ScoreKepper oldKeeper = FindObjectOfType<ScoreKepper> ();
		score = 1;
		if (oldKeeper) {
			score = oldKeeper.score;
			Destroy (oldKeeper.gameObject);
		
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
