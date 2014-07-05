using UnityEngine;
using System.Collections;

public class CoinCreator : MonoBehaviour {
	public GameObject prefab;
	public int ofsSpeed;
	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1") && Score.scoreCount > 0) {
			var ofs = new Vector3(Mathf.Sin(Time.time * ofsSpeed), 0 , 0);
			Instantiate (prefab, transform.position + ofs, transform.rotation);
			Score.scoreCount -= 1;
		}	
	}
}
