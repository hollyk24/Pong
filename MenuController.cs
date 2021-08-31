using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MenuController : MonoBehaviour {

	public Button PlayButton;
	public Button QuitButton; 
	public Button HelpButton;


	public void PlayGame(){

		SceneManager.LoadScene (1);
	}

	public void QuitGame(){

		Application.Quit ();
	}

	public void HelpMenu(){

		SceneManager.LoadScene (4);
	}
}
