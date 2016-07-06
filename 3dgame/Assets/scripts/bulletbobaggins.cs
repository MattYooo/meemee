using UnityEngine;
using System.Collections;

public class bulletbobaggins : MonoBehaviour {
	public float speed;
	void OnTriggerEnter (Collider col){
		if (col.gameObject.tag=="Player"){
			GameObject.Destroy (gameObject);
		}
	}
	void FixedUpdate (){
		gameObject.transform.Rotate(Vector3.forward*speed);
	}
}
