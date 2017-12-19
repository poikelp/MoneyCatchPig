using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public int score = 0;
	Text tex;
	int changeCount = 0;
	Pig pig;

	// Use this for initialization
	void Start () {
		tex = GetComponent<Text> ();
		pig = GameObject.Find ("Pig").GetComponent<Pig> ();
	}

	// Update is called once per frame
	void Update () {
		if (score < 0)
			score = 0;
		tex.text = score.ToString("C0");
		tex.fontSize = 10 + Mathf.Min(score / 5000, 140);
		if (changeCount < 1 && score >= 100000) {
			pig.ChangeColor ();
			changeCount++;
		} else if (changeCount < 2 && score >= 250000) {
			pig.ChangeColor ();
			changeCount++;
		} else if (changeCount < 3 && score >= 500000) {
			pig.ChangeColor ();
			changeCount++;
		}
	}
}
