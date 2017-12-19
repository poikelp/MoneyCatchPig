using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowStage : MonoBehaviour {

	[SerializeField]
	public float speed;
	Vector3 del;
	Transform trans;
	Vector3 pos;

	// Use this for initialization
	void Start () {
		del = new Vector3 (speed, 0, 0);
		trans = transform;
		pos = trans.position;
	}
	
	// Update is called once per frame
	void Update () {
		trans.position = pos;
		pos -= del * Time.deltaTime;
		del *= 1.0001f;
	}
}
