using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyYen : MonoBehaviour {

	Transform trans;
	public bool way;
	Vector3 pos;
	[SerializeField]
	float speed;
	float rand;

	// Use this for initialization
	void Start () {
		trans = transform;
		pos = trans.position;
		rand = Random.Range (0.5f, 2.0f);
	}
	
	// Update is called once per frame
	void Update () {
		pos.y = Mathf.Sin (Time.time * 2 * rand) * 2;
		pos.x += (way ? 1 : -1) * Time.deltaTime * speed;
		trans.position = pos;
		if (way) {
			if (trans.position.x > 9)
				Destroy (this.gameObject);
		} else {
			if (trans.position.x < -9)
				Destroy (this.gameObject);
		}
	}

	void OnTriggerEnter2D (Collider2D col){
		if (col.CompareTag ("Player")) {
			GameObject.Find ("Text").GetComponent<Score> ().score += 10000;
			Destroy (this.gameObject);
		}
	}
}