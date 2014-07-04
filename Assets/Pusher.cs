using UnityEngine;
using System.Collections;

public class Pusher : MonoBehaviour {

	Vector3 start;
	// Use this for initialization
	void Start () {
		start = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		var vec = new Vector3 (0, 0, Mathf.Sin (Time.time));
		rigidbody.MovePosition(vec + start);
	}
}
