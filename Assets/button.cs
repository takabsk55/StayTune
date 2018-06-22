using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour {
	public int thisAnswer;
	public GameObject maru;
	public GameObject batsu;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
	public void clicked(){
		Debug.Log ("click");
		if (thisAnswer == GameObject.Find("questionmake").GetComponent<question>().answer) {
			maru.SetActive (true);
		} else {
			batsu.SetActive (true);

		}
		GameObject.Find ("questionmake").GetComponent<question> ().stopQuestion ();
		Invoke ("next",1.0f);
	}
	void next(){
		Debug.Log ("hoge");
		GameObject.Find ("questionmake").GetComponent<question> ().makeQuestion();

	}

}
