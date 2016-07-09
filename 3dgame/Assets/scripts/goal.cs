using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class goal : MonoBehaviour {
	private int score=0;
	public GameObject scoreman;
	void OnTriggerEnter (Collider collision){
		if (collision.gameObject.tag.Equals("Sphere")) {
			scoreman.GetComponent <scoreman>().score+=1;
			GameObject.Destroy (this);
		}
	}
}
