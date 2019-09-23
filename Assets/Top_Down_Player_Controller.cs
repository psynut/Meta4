using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Top_Down_Player_Controller : MonoBehaviour {

	public float speedHorizaontal = 0.1f;
	public float speedVertical = 0.1f;

	private Rigidbody2D playerRB;

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
		
	}
}
