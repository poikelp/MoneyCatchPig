using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyYenMaker : MonoBehaviour {

	float coolTime;
	float time = 0;
	Transform trans;
	GameObject yen;
	bool way;

	// Use this for initialization
	void Start () {
		trans = transform;
		yen = (GameObject)Resources.Load ("FlyYen");
		way = trans.position.x < 0;
		coolTime = Random.Range (1.0f, 5.0f);
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if (time > coolTime) {
			GameObject obj = Instantiate (yen, trans.position, Quaternion.identity);
			obj.GetComponent<FlyYen> ().way = this.way;
			time = 0;
			coolTime = Random.Range (1.0f, 5.0f);
		}
	}
}
