﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManger : MonoBehaviour {

	public float timeTillNextLevel = 0.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (timeTillNextLevel > 0) {

			timeTillNextLevel -= Time.deltaTime;

			if (timeTillNextLevel < 0) {
				LoadNextScene ();
			}
		}
	}
	public void LoadNextScene(){
		int currentIndex = SceneManager.GetActiveScene ().buildIndex;
		SceneManager.LoadScene (currentIndex + 1);
	}

	public void LoadPreviousLevel(){
		SceneManager.LoadScene (0);
	}}