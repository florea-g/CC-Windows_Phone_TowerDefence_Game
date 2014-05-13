using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
	
		if (GUI.Button (new Rect ((Screen.width - 150) / 2,(Screen.height - 80) / 2, 150, 30), "Start")) {
				Application.LoadLevel("TD");
			}
			
		if (GUI.Button (new Rect ((Screen.width - 150) / 2,(Screen.height - 10) / 2, 150, 30), "Exit")) {
				Application.Quit();
			}

	}


}
