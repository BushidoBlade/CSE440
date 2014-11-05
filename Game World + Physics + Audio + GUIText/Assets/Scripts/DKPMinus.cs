using UnityEngine;
using System.Collections;

public class DKPMinus : MonoBehaviour {
	
	public AudioClip visibleTriggerSound;
	
	void OnTriggerEnter2D( Collider2D other ) {
		audio.PlayOneShot(visibleTriggerSound);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
