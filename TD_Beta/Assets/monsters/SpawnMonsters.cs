using UnityEngine;
using System.Collections;

public class SpawnMonsters : MonoBehaviour {
	public Transform[] SpawnPoint;
	public GameObject[] monster;
	public float temps; 
	public float score;
	public GameObject Player;
	public int tower_val;
	public int tower;
	public int gold;
	public int until_death;
	public Texture texture_right;
	public Texture texture_left;
	public Texture texture_canon;
	public Texture texture_turet;
	public GUISkin skin;
	public bool game_lost;
	public cam_switch camera_check;
	public int level;

	// Use this for initialization
	void Start () {
		temps = Time.realtimeSinceStartup;
		score = 0;
		tower_val = 0;
		tower = 0;
		gold = 35;
		until_death = 0;
		game_lost = false;
		level = 0; 
	}
	
	// Update is called once per frame
	void Update () {
		if (score >= (level*100)+100 ){
			level += 1;
		}

		if (until_death == 10) {
			game_lost = true;
		}

		if (Time.timeScale != 0) {
						int random_monter = Random.Range (0, 2);
						int random_point = Random.Range (0, 5);
						GameObject clone;

						if ((Time.realtimeSinceStartup - temps) > 2 ) {
								clone = Instantiate (monster [random_monter], SpawnPoint [random_point].position, Quaternion.identity) as GameObject;
								temps = Time.realtimeSinceStartup;
						}
				}
		if (Input.GetKeyDown(KeyCode.Escape)) {
			Time.timeScale = 0;
			}
	}


	void OnGUI(){
		GUI.skin = skin;
		camera_check =  GameObject.Find("CameraSwitcher").GetComponent<cam_switch>();

		if (game_lost == true) {
				
			Time.timeScale = 0;
			GUI.Label (new Rect ((Screen.width - 200) / 2,(Screen.height - 80) / 2, 200, 30), "You are dead");
			if (GUI.Button (new Rect ((Screen.width - 100) / 2,(Screen.height - 20) / 2, 100, 30), "Menu"))
				Application.LoadLevel("Intro");
		}

		if (Time.timeScale == 0 && game_lost != true) {
			if (GUI.Button (new Rect ((Screen.width - 100) / 2,(Screen.height - 80) / 2, 100, 30), "Resume"))
				Time.timeScale = 1;
			if (GUI.Button (new Rect ((Screen.width - 100) / 2,(Screen.height - 20) / 2, 100, 30), "Menu"))
				Application.LoadLevel("Intro");
		}

		if (game_lost == false) {
						GUI.Label (new Rect (Screen.width - (Screen.width - 10), Screen.height - (Screen.height - 10), 300, 30), "Score: " + score);
						GUI.Label (new Rect (Screen.width - (Screen.width - 10), Screen.height - (Screen.height - 40), 100, 30), "Gold: " + gold);
						GUI.Label (new Rect (Screen.width - (Screen.width - 10), Screen.height - (Screen.height - 70), 200, 30), "" + until_death + " /10 Until death");
				}
		if (Time.timeScale != 0) {
					if(camera_check.right_cam.enabled == false)
					{
						if (GUI.RepeatButton (new Rect (Screen.width - (Screen.width - texture_left.width - texture_right.width), Screen.height - texture_right.height, texture_right.width, texture_right.height), texture_right)) {
								if (Player.transform.position.x > -8.47)		
										Player.transform.Translate (Vector3.right * 5f * Time.deltaTime);
						}

						if (GUI.RepeatButton (new Rect (Screen.width - (Screen.width - texture_left.width), Screen.height - texture_left.height, texture_left.width, texture_left.height), texture_left)) {
								if (Player.transform.position.x < 2.60)
										Player.transform.Translate (Vector3.left * 5f * Time.deltaTime);
						}
					}

						if (GUI.Button (new Rect (Screen.width - 60, Screen.height - (Screen.height - 5), 60, 60), texture_canon)) {
								tower_val = 2;
								tower = 0;
						}

						if (GUI.Button (new Rect (Screen.width - 60, Screen.height - (Screen.height - 70), 60, 60), texture_turet)) {
								tower = 1;
								tower_val = 0;
						}
				}
	}

}
