using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (transform.position.x, 3.6f, transform.position.z); // locks camera y
	}
}