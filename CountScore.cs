using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountScore : MonoBehaviour {

	public Text Scoreboard;
	public GameObject ball;

	public static bool canAddScore = true;

	private int LeftRacket_Score = 0;
	private int RightRacket_Score = 0;


	// Use this for initialization
	void Start () {

		ball = GameObject.Find ("Ball");

	}
	
	// Update is called once per frame
	void Update () {


		if (ball.transform.position.x >= 50f ) {

			//canAddScore = false;
			LeftRacket_Score ++;

		}
		if (ball.transform.position.x <= -50f ) {

			//canAddScore = false;
			RightRacket_Score ++;

		}

		if (LeftRacket_Score >= 10) {

			SceneManager.LoadScene (2);
		}
			
		if (RightRacket_Score >= 10){
			SceneManager.LoadScene (3);
		}

		Scoreboard.text = LeftRacket_Score.ToString () + " - " + RightRacket_Score.ToString (); 

		print (LeftRacket_Score + " , " + RightRacket_Score);
		
	}
}
