using UnityEngine;
using System.Collections;

public class cam_switch : MonoBehaviour {

	public Camera rear_cam;
	public Camera right_cam;
	public Texture cam;

	void Start () {
		right_cam.enabled = false;
		rear_cam.enabled = true;
	}

	void OnGUI(){

		if (GUI.Button (new Rect (Screen.width - 60, Screen.height - 60, 60, 60), "Cam")) {
			rear_cam.enabled = !rear_cam.enabled;
			right_cam.enabled = !right_cam.enabled;
		}

	}
}
