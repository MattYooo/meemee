using UnityEngine;
using System.Collections;

public class kick : MonoBehaviour {
	public GameObject Player;
	public float kickpower;
	public float radius;
	void Update(){
		float distance = Vector3.Distance (transform.position, Player.transform.position);
		if(distance<radius){if(Input.GetMouseButtonDown(0)){
				GetComponent<Rigidbody> ().AddForce (transform.forward * kickpower);
			}}
	}

}