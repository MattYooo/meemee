using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class scoreman : MonoBehaviour {
	public int score;
	public GameObject text;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		text.GetComponent <Text> ().text="score equals " + score;
	
	}
}
