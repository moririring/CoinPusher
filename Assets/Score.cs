using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	static public int scoreCount; 
	// Use this for initialization
	void Start () {
		scoreCount = 30; 
	}
	
	// Update is called once per frame
	void Update () {
		guiText.text = scoreCount.ToString();
	}
}
