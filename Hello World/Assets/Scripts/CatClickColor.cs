using UnityEngine;
using System.Collections;

public class CatClickColor : MonoBehaviour {
	private Animator anim;
	private bool isCatClicked;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		isCatClicked = false;
		anim.SetBool("CatClicked", false); 
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown() {
		if (isCatClicked == true) { 
			isCatClicked = false;
			anim.SetBool("CatClicked", false); 
		}
		else { 
			isCatClicked = true;
			anim.SetBool("CatClicked", true); 
		}
	}

}
