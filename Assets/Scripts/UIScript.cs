using UnityEngine;
using System.Collections;

public class UIScript : MonoBehaviour {
	string timer;
	int time = 120;
	int score = 0;
	int waveNum = 1;
	bool startWave = false;
	bool life1 = true;
	bool life2 = true;
	bool life3 = true;
	Texture2D heart;

	// Use this for initialization
	void Start () {
		Count ();
		Wave ();
		Health ();
	}
	
	// Update is called once per frame
	void Update () {
		timer = time.ToString ();
	}
	void OnGUI(){
		GUI.Label (new Rect (Screen.width / 2 - 70, 10, 70, 40), "Time: " + timer);
		GUI.Label (new Rect (Screen.width / 2 - 70, Screen.height - 30, 70, 40), "Score: " + score);
		GUI.Label (new Rect (10, Screen.height - 30, 70, 40), "Wave: " + waveNum);
		if (startWave){
			GUI.Label (new Rect (Screen.width/2-30, Screen.height/2 - 40, 70, 40), "Wave: " + waveNum);
		}

		if (life1) {
			GUI.Label(new Rect (Screen.width-30, 10, 70, 40), heart);
		}

	}

	void Wave(){
		
	}

	void Health(){

	}

	void Count(){
		StartCoroutine ("Countdown");
	}

	IEnumerator Countdown(){
		while (time > 0) {
			yield return new WaitForSeconds(1f);
			time --;
		}
	}

}
