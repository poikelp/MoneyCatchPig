using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tonkachi : MonoBehaviour {

	Transform trans;


	void Start () {
		trans = transform;

	}

	void Update () {
		if (trans.position.y < -6)
			Destroy (this.gameObject);
	}
}
