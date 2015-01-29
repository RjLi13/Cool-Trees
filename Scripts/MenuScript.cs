using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	void OnGUI(){
		const int buttonWidth = 54;
		const int buttonHeight = 30;

		Rect buttonRect = new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(2 * Screen.height / 3) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			);
		if(GUI.Button(buttonRect,"Start!"))
		{
			//Change string name to stage
			Application.LoadLevel("Stage1");
		}

		const int buttonWidth2 = 100;
		const int buttonHeight2 = 30;

		Rect buttonRect2 = new Rect(
			Screen.width / 2 - (buttonWidth2 / 2),
			(5 * Screen.height / 6) - (buttonHeight2 / 2),
			buttonWidth2,
			buttonHeight2
			);

		if(GUI.Button(buttonRect2,"Instructions!"))
		{
			//Change string name to stage
			Application.OpenURL("file:///Users/ruijing/Documents/GameJam/Assets/gamejam_howtoplay.html");
		}
	}
}

