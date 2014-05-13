using UnityEngine;
using System.Collections;

public class mouseclick_ground : MonoBehaviour {
	public GUISkin skin2;
	public SpawnMonsters mouse_t;
	public SpawnMonsters mouse_t2;
	public SpawnMonsters gold;
	public GameObject turette;
	public GameObject turette2;
	public bool activate_gui;
	// Use this for initialization
	void Start () {
		activate_gui = false;
	}

	// Update is called once per frame
	void Update () {
	
	}
	IEnumerator OnMouseDown(){
		int i = 0;
		GameObject clone;
		mouse_t =  GameObject.Find("Cube").GetComponent<SpawnMonsters>();
		mouse_t2 =  GameObject.Find("Cube").GetComponent<SpawnMonsters>();
		gold =  GameObject.Find("Cube").GetComponent<SpawnMonsters>();
		if (Input.GetMouseButtonDown (0) && mouse_t.tower == 1) {
						if (gold.gold >= 10)
						{
						mouse_t.tower = 0;
						clone = Instantiate (turette, this.transform.position, Quaternion.identity) as GameObject;
						clone.transform.Rotate (270, 180, 0);
						gold.gold -= 10;
						}
						else
						{
						activate_gui = true;
						yield return new WaitForSeconds(2.0f);
						activate_gui = false;
						}
						
						
				}
		if (Input.GetMouseButtonDown (0) && mouse_t2.tower_val == 2) {
			if (gold.gold >= 15)
			{
			mouse_t2.tower_val = 0;
			clone = Instantiate (turette2,this.transform.position,Quaternion.identity) as GameObject;
			clone.transform.Rotate(270,180,0);
			clone.transform.Translate(Vector3.forward * 50f * Time.deltaTime);
			gold.gold -= 15;
			}
			else
			{
				activate_gui = true;
				yield return new WaitForSeconds(2.0f);
				activate_gui = false;
			}
		}
	}

	void OnGUI(){
		GUI.contentColor = Color.red;
		GUI.skin = skin2;
		if (activate_gui == true)
		GUI.Label(new Rect(Screen.width-(Screen.width - 10),Screen.height-(Screen.height - 100), 200, 50), "Not Enought Money");
		}


}