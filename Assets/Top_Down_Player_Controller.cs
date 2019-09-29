using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Top_Down_Player_Controller : MonoBehaviour {

	public float speedHorizaontal = 0.01f;
	public float speedVertical = 0.01f;

	private Rigidbody2D playerRB;

	private float lastAngle;

	// Use this for initialization
	void Start () {
		playerRB = GetComponent<Rigidbody2D>();
		Debug.Log (playerRB);
		Debug.Log ("Hello?");
	}
	
	// Update is called once per frame
	void Update () {
		float horz = Input.GetAxis("Horizontal");
		float vert = Input.GetAxis("Vertical");
		Move(horz, vert);
		RotateTransform(horz, vert);
	}

	void Move(float horz, float vert){
		transform.Translate(horz * speedHorizaontal, 0, 0, Space.World);
		transform.Translate(0,vert * speedVertical, 0, Space.World);
	}

	void RotateTransform(float horz, float vert){
		//https://answers.unity.com/questions/904038/how-do-you-convert-inputgetaxis-to-rotation-in-deg.html
		//https://docs.unity3d.com/ScriptReference/Transform.Rotate.html

		if (horz != 0 || vert != 0){
			float myAngle = Mathf.Atan2 (horz, -vert) * Mathf.Rad2Deg;
			Debug.Log ("My Angle = " + myAngle);
			lastAngle = myAngle;
			transform.eulerAngles = new Vector3 (0, 0, myAngle);
			//transform.Rotate(0, 0, myAngle, Space.World) - Worth keeping to trip out SPINNING SPRITES
		} else {
			transform.eulerAngles = new Vector3 (0,0, lastAngle);
		}
	}
}
