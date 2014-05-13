using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	private float time;
	// Use this for initialization
	void Start () {

	}
	void OnCollisionEnter(Collision col)
	{
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate (Vector3.back * 20f * Time.deltaTime);
		if (transform.position.z < -13) {
			Destroy(this.gameObject);	
			}
	}


}
