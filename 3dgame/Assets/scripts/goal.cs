using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class goal : MonoBehaviour {
	public Text scoretext;
	private int score=0;

	void OnTriggerEnter (Collider collision){
		if (collision.gameObject.tag.Equals("Sphere")) {
			score += 1;
			scoretext.text = "score is" + score; 
			Debug.Log ("ey boss");
		}
	}
}
