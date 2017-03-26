﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour {

	string score,overs,nrr,speed;
	Text scoreText, oversText, nrrText,speedText;

	void Start() {
		scoreText = GameObject.Find ("Score").GetComponent<Text> ();
		oversText = GameObject.Find ("Overs").GetComponent<Text> ();
		nrrText = GameObject.Find ("NRR").GetComponent<Text> ();
		speedText = GameObject.Find ("Speed").GetComponent<Text> ();
	}

	public void SetScoreText(string value) {
		scoreText.text = value;
	}

	public void SetOversText(string value) {
		oversText.text = value;
	}

	public void SetNRRText(string value) {
		nrrText.text = value;
	}

	public void SetSpeedText(string value) {
		speedText.text = value;
	}
}
