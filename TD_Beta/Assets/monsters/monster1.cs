using UnityEngine;
using System.Collections;

public class monster1 : MonoBehaviour {
	public SpawnMonsters gold;
	public int PV; 
	public int vitesse = 2;
	public SpawnMonsters level_high;

	void Start () {
		level_high =  GameObject.Find("Cube").GetComponent<SpawnMonsters>();
		this.transform.Rotate (0, 180, 0);
		PV = 80 + (level_high.level * 10);
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate(Vector3.back * vitesse * Time.deltaTime);
	}

	public void Get_dmg(int dmg){
		gold =  GameObject.Find("Cube").GetComponent<SpawnMonsters>();
		PV -= dmg;
		if (PV < 0) 
		{
			gold.score += 70;
			gold.gold += 10;
			Destroy(this.gameObject);
		}
	}

	public void Stop(){	
		vitesse = 0;
	}
}
