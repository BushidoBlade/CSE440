using UnityEngine;
using System.Collections;

public class WallMover : MonoBehaviour {
	private Transform cameraTransform;
	private float backgroundWidth;
	private float wallWidth;
	private float startCameraX;

	// Use this for initialization
	void Start () {
		backgroundWidth = 21.0f;
		SpriteRenderer spriteRenderer = renderer as SpriteRenderer;
		wallWidth = spriteRenderer.sprite.bounds.size.x;
		cameraTransform = Camera.main.transform;
		startCameraX = cameraTransform.position.x;
	}
		
	// Update is called once per frame
	void Update () {
		if ((transform.position.x + backgroundWidth + startCameraX + wallWidth) < cameraTransform.position.x) {
			Vector3 newPos = transform.position;
			newPos.x += backgroundWidth; 
			transform.position = newPos;
		}
	}
}