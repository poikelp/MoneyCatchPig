using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public int score = 0;
	Text tex;

	// Use this for initialization
	void Start () {
		tex = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		tex.text = "￥" + score.ToString();
		tex.fontSize = 10 + score / 5000;
	}
}
