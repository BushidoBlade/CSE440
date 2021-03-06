﻿using UnityEngine;
using System.Collections;

public class BackgroundRepeater : MonoBehaviour {
	private Transform cameraTransform;
	private float spriteWidth;
	private float startCameraX;

	// Use this for initialization
	void Start () {
		cameraTransform = Camera.main.transform;
		startCameraX = cameraTransform.position.x;
		SpriteRenderer spriteRenderer = renderer as SpriteRenderer;
		spriteWidth = spriteRenderer.sprite.bounds.size.x;
	}
	
	// Update is called once per frame
	void Update () {
		if( (transform.position.x + spriteWidth + startCameraX) < cameraTransform.position.x) {
			Vector3 newPos = transform.position;
			newPos.x += 2.0f * spriteWidth; 
			transform.position = newPos;
		}
	}
}
