using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	public float moveSpeed;
	//public float jumpHeight;
	//private Vector3 target;

	public float jumpSpeed;
	public float maxVelocity;

	// Use this for initialization
	void Start () {
		//target = transform.position;
	}

	void FixedUpdate () { // better for RigidBodies

		if (Input.GetButtonDown("Jump")) {
			rigidbody2D.AddForce(Vector3.up * jumpSpeed);
			//rigidbody2D.velocity = new Vector3(0, jumpHeight, 0);
		}

		float vMagnitude = rigidbody2D.velocity.magnitude;
		if (Input.GetButton("Horizontal") && Input.GetAxisRaw("Horizontal") > 0) {

			if (vMagnitude < maxVelocity) { // cap horizontal movement speed
				rigidbody2D.AddForce(Vector3.right * moveSpeed * Time.deltaTime);
			}

			//target += Vector3.right * moveSpeed * Time.deltaTime;
		}
		if (Input.GetButton("Horizontal") && Input.GetAxisRaw("Horizontal") < 0) {

			if (vMagnitude < maxVelocity) {
				rigidbody2D.AddForce(Vector3.left * moveSpeed * Time.deltaTime);
			}

			//target += Vector3.left * moveSpeed * Time.deltaTime;
		}
		//transform.position = Vector3.MoveTowards (transform.position, target, moveSpeed * Time.deltaTime);
	}

	// Update is called once per frame
	void Update () {
	} 
}
