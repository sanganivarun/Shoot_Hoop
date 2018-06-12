﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeRemainingDisplay : MonoBehaviour {
	LevelManger levelManager;
	Text text;

	// Use this for initialization
	void Start () {
		levelManager = FindObjectOfType<LevelManger> ();
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Time Reamaining:    " + levelManager.timeTillNextLevel;
	}
}