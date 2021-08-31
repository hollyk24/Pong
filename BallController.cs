using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

	private Rigidbody2D rb;

	public GameObject LeftRacket;
	public GameObject RightRacket;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D> ();

		LeftRacket = GameObject.Find ("RacketLeft");
		RightRacket = GameObject.Find ("RacketRight");

		StartCoroutine (Pause ());

	}
	
	// Update is called once per frame
	void Update () {

		if (Mathf.Abs(this.transform.position.x) >= 50f) {

			//CountScore.canAddScore = true;

			this.transform.position = new Vector3 (0f, 0f, 0f);
			StartCoroutine (Pause ());

		}
	
				
	}

	IEnumerator Pause(){

		int directionX = Random.Range (-1, 2);
		int directionY = Random.Range (-1, 2);

		if (directionX == 0) {
			directionX = 1;
		}
		
		rb.velocity = new Vector2 (0f, 0f);
		yield return new WaitForSeconds (2);
		rb.velocity = new Vector2 (10f * directionX, 8f * directionY);

	}

	void OnCollisionEnter2D (Collision2D hit){

		if (hit.gameObject.name == "RacketLeft") {

			if (LeftRacket.GetComponent<Rigidbody2D> ().velocity.y > 0.5f) {

				rb.velocity = new Vector2 (20f, 15f);

			} else if (LeftRacket.GetComponent<Rigidbody2D> ().velocity.y < -0.5f) {

				rb.velocity = new Vector2 (22f, -22f);

			} else {

				rb.velocity = new Vector2 (22f, 0f);

			}

		}
		if (hit.gameObject.name == "RacketRight") {

			if (RightRacket.GetComponent<Rigidbody2D> ().velocity.y > 0.5f) {

				rb.velocity = new Vector2 (-15f, 15f);

			} else if (RightRacket.GetComponent<Rigidbody2D> ().velocity.y < -0.5f) {

				rb.velocity = new Vector2 (-15f, -15f);

			} else {

				rb.velocity = new Vector2 (-20f, 0f);

			}


		}
	}
}
