using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class question : MonoBehaviour {
	private int flag;
	private string name;
	private int num;
	private string[] nameArray={"stay","bran","M","atama","hiro"};
	private GameObject obj;
	public int answer=0;
	public GameObject maru;
	public GameObject batsu;
	// Use this for initialization
	void Start () {
		makeQuestion ();
	}
	
	// Update is called once per frame
	void Update () {
		obj.GetComponent<text> ().make();
	}

	public void makeQuestion(){
		init ();
		num = Random.Range (0, 5);
		name = nameArray [num];
		obj = GameObject.Find (name);
		if (name == "stay") {
			answer = 0;
		} else {
			answer = 1;
		}
	}

	
	public void stopQuestion(){
		obj = null;
	}

	void init(){
		for (int i=0;i<nameArray.Length;i++){
			obj = GameObject.Find (nameArray[i]);
			obj.transform.position = new Vector3 (3f, 1.92f, -7.78f);
		}
		maru.SetActive (false);
		batsu.SetActive (false);

	}
}
