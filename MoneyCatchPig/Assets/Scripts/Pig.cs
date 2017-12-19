using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pig : MonoBehaviour {

	[SerializeField]
	float speed;
	[SerializeField]
	float jumpPow;
	Vector2 upPow;
	Rigidbody2D rigi;
	int jumpCount = 0;
	Transform trans;
	SpriteRenderer rend;
	Vector3 pos;
	GameObject stage;
	float flowSpeed;

	// Use this for initialization
	void Start () {
		rigi = GetComponent<Rigidbody2D> ();
		upPow = Vector2.up * jumpPow;
		trans = transform;
		rend = GetComponent<SpriteRenderer> ();
		pos = trans.position;
		stage = GameObject.Find ("stage");
		flowSpeed = stage.GetComponent<FlowStage> ().speed;
	}
	
	// Update is called once per frame
	void Update () {
		pos = trans.position;
		if(Input.GetButtonDown("Jump") && jumpCount < 2){
			rigi.AddForce (upPow);
			jumpCount++;
		}
		float hori = Input.GetAxis ("Horizontal") * Time.deltaTime * speed;
		pos.x += hori;
		trans.position = pos;

		if(hori != 0)
			rend.flipX = hori > 0;

		if (trans.position.y < -6) {
			pos.y = 6.0f;
			trans.position = pos;
			rigi.velocity = Vector3.zero;
		}
	}

	void OnCollisionEnter2D (){
		jumpCount = 0;
	}
	void OnCollisionStay2D (){
		pos = trans.position;
		pos.x -= flowSpeed * Time.deltaTime;
		trans.position = pos;
	}


}
