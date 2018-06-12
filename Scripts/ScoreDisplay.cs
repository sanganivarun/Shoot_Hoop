using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreDisplay : MonoBehaviour {
	Text text;
	ScoreKepper scorekeeper;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
		scorekeeper = FindObjectOfType<ScoreKepper> ();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Score:" + scorekeeper.score; 
	}
}
