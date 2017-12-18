using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desk : MonoBehaviour {

	Transform trans;

	// Use this for initialization
	void Start () {
		trans = transform;
	}
	
	// Update is called once per frame
	void Update () {
		if (trans.position.x < -10) {
			GetComponentInParent<MapBuilder> ().Build ();
			Destroy (this.gameObject);
		}
	}
}
