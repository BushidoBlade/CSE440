using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	public float moveSpeed;
	public float jumpSpeed;
	public float maxVelocity;
	public AudioClip jumpSound;
	private float vMagnitude;
	private bool canJump = false;
	private ScoreController score;

	void Start () { 
		score = GameObject.Find("Score").GetComponent<ScoreController>();
	}

	void OnCollisionEnter2D(Collision2D collision) {
		if (collision.gameObject.tag == "FloorCollider") {  // Detects collision with tagged gameObject
			canJump = true;
		}
	}

	void OnTriggerEnter2D( Collider2D trigger ) {
		if (trigger.gameObject.tag == "VisibleTrigger") {
			score.score -= 50;
		}
		if (trigger.gameObject.tag == "InvisibleTrigger") {
			score.score += 100;
		}
	}

	void FixedUpdate () { // Better for RigidBodies
		vMagnitude = rigidbody2D.velocity.magnitude;

		if (Input.GetButtonDown("Jump") && canJump) {
			rigidbody2D.AddForce(Vector3.up * jumpSpeed);
			canJump = false;
			audio.PlayOneShot(jumpSound);
		}
		if (Input.GetButton("Horizontal") && Input.GetAxisRaw("Horizontal") > 0) {
			if (vMagnitude < maxVelocity) { // Caps horizontal movement speed
				rigidbody2D.AddForce(Vector3.right * moveSpeed * Time.deltaTime);
			}

		}
		if (Input.GetButton("Horizontal") && Input.GetAxisRaw("Horizontal") < 0) {
			if (vMagnitude < maxVelocity) {
				rigidbody2D.AddForce(Vector3.left * moveSpeed * Time.deltaTime);
			}
		}
	}

	// Update is called once per frame
	void Update () {
	} 
}
