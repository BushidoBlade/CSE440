using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	public float moveSpeed;
	private Vector3 target;

	// Use this for initialization
	void Start () {
		target = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			target += Vector3.left * moveSpeed * Time.deltaTime;
			target.z = transform.position.z;
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			target += Vector3.right * moveSpeed * Time.deltaTime;
			target.z = transform.position.z;
		}
		if (Input.GetKey(KeyCode.UpArrow))
		{
			target += Vector3.up * moveSpeed * Time.deltaTime;
			target.z = transform.position.z;
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			target += Vector3.down * moveSpeed * Time.deltaTime;
			target.z = transform.position.z;
		}
		if (Input.GetMouseButtonDown(0)) {
			target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			target.z = transform.position.z;
		}

		transform.position = Vector3.MoveTowards (transform.position, target, moveSpeed * Time.deltaTime);
	} 
}
