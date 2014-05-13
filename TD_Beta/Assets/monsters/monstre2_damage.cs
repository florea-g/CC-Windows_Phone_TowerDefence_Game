using UnityEngine;
using System.Collections;

public class monstre2_damage : MonoBehaviour {
	public SpawnMonsters gold;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(Collider col)
	{
		gold =  GameObject.Find("Cube").GetComponent<SpawnMonsters>();
		if (col.gameObject.name == "canon_bullet(Clone)") {
			Destroy(col.gameObject);
			this.gameObject.transform.parent.SendMessage("Get_dmg",15);
		}
		
		
		if (col.gameObject.name == "turret_02_bullet 1(Clone)") {
			Destroy(col.gameObject);
			this.gameObject.transform.parent.SendMessage("Get_dmg",10);
			
		}

		if (col.gameObject.name == "Back-wall") {
			this.gameObject.transform.parent.SendMessage ("Stop");
			gold.until_death += 1;
			Destroy(this.gameObject.transform.parent.gameObject);
		}

		if (col.gameObject.name == "canon_damage") {
			Destroy(col.gameObject.transform.parent.gameObject);
			Destroy(this.gameObject.transform.parent.gameObject);
		}
		
		if (col.gameObject.name == "turet_02_damage") {
			Destroy(col.gameObject.transform.parent.gameObject);
			Destroy(this.gameObject.transform.parent.gameObject);
		}
	}
}
