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
	// Use this for initialization
	void Start () {
		makeQuestion ();
	}
	
	// Update is called once per frame
	void Update () {
		obj.GetComponent<text> ().make();
	}
	void makeQuestion(){
		while(true){
			if (flag == 0) {
				num = Random.Range (0, 5);
				name = nameArray [num];
				obj = GameObject.Find (name);
				flag = 1;
				if (name == "stay") {
					answer = 0;
				} else {
					answer = 1;
				}
			}
			break;
		}
	}
}
