using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	[SerializeField]
	Sprite[] spri;
	Score sco;
	SpriteRenderer rend;

	// Use this for initialization
	void Start () {
		sco = GameObject.Find ("Text").GetComponent<Score> ();
		rend = GetComponent<SpriteRenderer> ();
		gameObject.SetActive (false);
		if (sco.score < 500000) {
			rend.sprite = spri [0];
		} else {
			rend.sprite = spri [1];
			transform.localScale = new Vector3 (4.7f, 5.3f, 0.0f);
		}
	}

	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Submit")) {
			SceneManager.LoadScene (0);
		}
	}
}
