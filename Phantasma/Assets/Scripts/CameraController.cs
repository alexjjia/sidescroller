using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject target; //target, in this scenario.

	// Use this for initialization
	void Start () {
		//this.transform.position = target.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 transform = new Vector3(target.transform.position.x, this.transform.position.y, this.transform.position.z);

		this.transform.position = transform;
		
	}
}
