﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketRight_controller : MonoBehaviour {

	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {

		rb = this.GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.UpArrow)) {
			rb.velocity = new Vector2 (0f, 15f);

		} else if (Input.GetKey (KeyCode.DownArrow)) {
			rb.velocity = new Vector2 (0f, -15f);

		} else {
			rb.velocity = new Vector2 (0f, 0f);

		}

	}
}
