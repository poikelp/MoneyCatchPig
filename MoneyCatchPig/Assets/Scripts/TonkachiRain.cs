using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TonkachiRain : MonoBehaviour {

	float coolTime;
	float time = 0;
	GameObject tonk;
	Vector3 pos;

	// Use this for initialization
	void Start () {
		tonk = (GameObject)Resources.Load ("tonkachi");
		coolTime = Random.Range (1.0f, 3.0f);
		pos = Vector3.up * 6;
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if (time > coolTime) {
			pos.x = Random.Range (-8.0f, 8.0f);
			Instantiate (tonk, pos, Quaternion.identity);
			time = 0;
			coolTime = Random.Range (1.0f, 3.0f);
		}
	}
}
