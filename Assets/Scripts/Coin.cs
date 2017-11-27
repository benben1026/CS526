﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

	private int effectCount = 0;
	private int limite = 10;
	private bool used = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		effectCount++;
		if (effectCount == limite)
			used = true;
	}
	private void OnTriggerEnter2D(Collider2D other){
		if (other.GetComponent<Car> () != null && used) {
			GameController.instance.bonusTime ();
			used = false;

			FindObjectOfType<AudioManager>().Play("EatCoin");

			Destroy (this.gameObject);
		}
	}
		
}
