using UnityEngine;
using System.Collections;

public class DKPPlusInvis : MonoBehaviour {

	public AudioClip invisibleTriggerSound;

	void OnTriggerEnter2D( Collider2D other ) {
		audio.PlayOneShot(invisibleTriggerSound);
	}

	// Update is called once per frame
	void Update () {
		
	}
}