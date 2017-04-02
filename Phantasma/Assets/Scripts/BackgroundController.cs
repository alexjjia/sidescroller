using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour {

//	public Queue<Transform> background;
//	public GameObject prefab;
//	public int numBackgroundImages;
////	public GameObject[] backgrnd = new GameObject[4]; //sets a GameObject array of four background images.
//	public GameObject player;
//	private float playerX, playerY;
//	Vector3 nextPosition;
//	// Use this for initialization
//	void Start () {
//		background = new Queue<Transform> (numBackgroundImages);
//		for (int i = 0; i < numBackgroundImages; i++) {
//			Transform obj = (Transform)Instantiate (prefab);
//			obj.localPosition = nextPosition;
//			nextPosition.x += 13.2f * 4f;
//			Debug.Log("local position is for object " + i + " is at: \n" + obj.localPosition);
//			background.Enqueue (obj);
//		}
//		playerX = player.transform.position.x;
//		playerY = player.transform.position.y;
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		if (playerX > 13.2 * 4 * numBackgroundImages || playerX < -13.2 * 4 * numBackgroundImages) {
//			reassign ();
//		}
//		//1. get boundaries of current wallpaper.
//		//2. if crossed, remove last known wallpaper from array
//	}
//
//	private void reassign()
//	{
//		Transform obj = background.Dequeue ();
//		obj.transform.localPosition = nextPosition;
//		background.Enqueue (obj);
//	}
}
