using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScriptA : MonoBehaviour {
	//Keeping camera focused on the player
	// 0,0 is buttom left. Camera.pixelWidth, Camera.pixelHeight is upper righ.
	//camer.WorldToScreenPoiint is the transform's position to the camera pixels.

	public Transform player;
	[Tooltip("Parameter in percentage of screen that player can get to before camera starts moving")]
	public float maxX = 80f, minX = 20f, maxY = 80f, minY=20f;
	Camera myCamera;
	private int cameraWidth, cameraHeight;

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
		PercXY percxy = PosPercScreen (screenPos.x, screenPos.y);
		if (percxy.percX > maxX) {
	//		myCamera.transform.Translate(player.position.x 
		}
		if (percxy.percX < minX) {

		}
		if (percxy.percY > maxY) {

		}
		if (percxy.percY < minY) {

		}
	}

	public PercXY PosPercScreen (float posX, float posY){
		//keep track of the percentage of the screen the player's icon has moved to (in order to start moving camera)
		float percX = 100*posX/cameraWidth;
		float percY = 100 * posY / cameraHeight;
		PercXY myPPS = new PercXY(percX, percY);
		return myPPS;
	}

	private void followPlayer(){
		
	}
}

public class PercXY{

	public float percX;
	public float percY;

	public PercXY(float x, float y){
		this.percX = x;
		this.percY = y;
	}

	public void displayIt(){
		Debug.Log ("PercX = " + this.percX + ", PercY = " + this.percY);
	}

}
