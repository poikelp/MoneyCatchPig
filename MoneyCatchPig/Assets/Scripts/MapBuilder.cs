using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapBuilder : MonoBehaviour {

	GameObject desk;
	int buildCount = 0;
	Transform trans;
	Vector3 pos;

	// Use this for initialization
	void Start () {
		trans = transform;
		pos = Vector3.right * 9.5f;
		desk = (GameObject)Resources.Load ("Desk");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Build () {
		pos.y = Random.Range (-5.5f, 3.0f);
		GameObject obj = Instantiate (desk, pos, Quaternion.identity);
		obj.transform.parent = trans;
		buildCount++;
	}
}
