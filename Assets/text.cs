using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text : MonoBehaviour {

	private float speed = 1.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void make(){
		transform.position += Vector3.left * speed * Time.deltaTime;
	}
}
