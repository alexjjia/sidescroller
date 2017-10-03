using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	Animator anim;
	public int speed;
	private float threshold; 

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		threshold = 0.25f;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 panoramic = new Vector3 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"));
		if (transform.position.y >= 0.25) { //ensures player doesn't exceed the 'ground' of the background.
			transform.position = new Vector3 (transform.position.x, 0.2499f, -1);

		} else if (transform.position.y <= -4.25) { //ensures player doesn't go under the 'ground of the background.
			transform.position = new Vector3 (transform.position.x, -4.2499f, -1);
		}
		else {
			transform.position += panoramic * Time.deltaTime * speed; //movement.
		}

	}

	void FixedUpdate() {
		if ((Input.GetAxis ("Horizontal") != 0) || Input.GetAxis ("Vertical") != 0)
			anim.SetBool ("isMoving", true);
		else {
			anim.SetBool ("isMoving", false);
		}
	}
}