using UnityEngine;
using System.Collections;

public class WallMover : MonoBehaviour {
	private Transform cameraTransform;
	private float spriteWidth = 21f;
	private float startCameraX;
	// Use this for initialization
	void Start () {
		cameraTransform = Camera.main.transform;
		startCameraX = cameraTransform.position.x;
	}
		
	// Update is called once per frame
	void Update () {
		if ((transform.position.x + spriteWidth + startCameraX + 1.1f) < cameraTransform.position.x) {
			Vector3 newPos = transform.position;
			newPos.x += spriteWidth; 
			transform.position = newPos;
		}
	}
}