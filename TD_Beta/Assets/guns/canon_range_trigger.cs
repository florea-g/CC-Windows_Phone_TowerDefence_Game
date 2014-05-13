using UnityEngine;
using System.Collections;

public class canon_range_trigger : MonoBehaviour {
	public Transform bullet_02_spawn ;
	public GameObject bullet ;
	private float time;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col)
	{
			
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
