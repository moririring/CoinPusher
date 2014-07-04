using UnityEngine;
using System.Collections;

public class Line2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other) {
		Destroy(other.gameObject);
		Score.scoreCount += 3;
	}
}
