using UnityEngine;
using System.Collections;

public class turet_02_range_trigger : MonoBehaviour {
	public Transform bullet_02_spawn ;
	public GameObject bullet ;
	private float time;

	void Start(){
		time = Time.realtimeSinceStartup;
	}


	
	void OnTriggerStay(Collider col)
	{
		if (col.gameObject.name == "monster1_damage" || col.gameObject.name == "monstre2_trigger") {
			if ((Time.realtimeSinceStartup - time) > 0.5) {
				GameObject clone;
				clone = Instantiate (bullet, bullet_02_spawn.position, Quaternion.identity) as GameObject;	
				time = Time.realtimeSinceStartup;
			}
		}
	}

}
