using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScriptA : MonoBehaviour {
	//Keeping camera focused on the player
	// 0,0 is buttom left. Camera.pixelWidth, Camera.pixelHeight is upper righ.
	//camer.WorldToScreenPoiint is the transform's position to the camera pixels.

	public Transform player;
	Camera myCamera;
	int cameraWidth, cameraHeight;

	// Use this for initialization
	void Start () {
		myCamera = GetComponent<Camera> ();
		cameraWidth = myCamera.pixelWidth;
		cameraHeight = myCamera.pixelHeight;

	}
	
	// Update is called once per frame
	void Update () {
		Vector2 screenPos = myCamera.WorldToScreenPoint (player.position);
		Debug.Log ("Target is " + screenPos.x + " pixels from the left");
		Debug.Log ("Target is " + screenPos.y + " pixels from the buttom");
	}
}
