using UnityEngine;
using System.Collections;

public class CoinCreator : MonoBehaviour {
    public GameObject prefab;
    private AudioSource audioSource;
    public AudioClip audioClip;
    public int ofsSpeed;
	// Use this for initialization
	void Start ()
	{
	    audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = audioClip;
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1") && Score.scoreCount > 0) {
			var ofs = new Vector3(Mathf.Sin(Time.time * ofsSpeed), 0 , 0);
			Instantiate (prefab, transform.position + ofs, transform.rotation);
			Score.scoreCount -= 1;
            audioSource.Play();
		}	
	}
}
