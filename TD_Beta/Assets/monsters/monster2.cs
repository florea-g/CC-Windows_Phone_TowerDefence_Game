using UnityEngine;
using System.Collections;

public class monster2 : MonoBehaviour {
 	
	public SpawnMonsters gold;
	public int PV; 
	public int vitesse = 1;
	public SpawnMonsters level_high;

	void Start () {
		level_high =  GameObject.Find("Cube").GetComponent<SpawnMonsters>();
		this.transform.Rotate (0, 180, 0);
		PV = 100+ (level_high.level * 10);
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
			gold.gold += 15;
			gold.score += 100;
			Destroy(this.gameObject);
		}
	}

	public void Stop(){
		vitesse = 0;
	}
}
