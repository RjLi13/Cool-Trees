using UnityEngine;
using System.Collections;

public class PauseScript : MonoBehaviour {
	public Texture2D btnTexture;
	public bool show_menu = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}



	void OnGUI (){
		if (GUI.Button (new Rect (10, 10, 30, 30), btnTexture)) {
			Time.timeScale = 0.0f;
			show_menu = true;
	
		}
		if (show_menu) {
			if (GUI.Button (new Rect (Screen.width / 2 - 35, Screen.height / 2 - 60, 70, 40), "Resume")) {
				Time.timeScale = 1.0f;
				show_menu = false;
			}
		}
		if (show_menu) {
			if (GUI.Button (new Rect (Screen.width / 2 - 35, Screen.height / 2 + 20, 70, 40), "Quit")) {
				Application.LoadLevel("Menu2");
			}
		}


	}

}
