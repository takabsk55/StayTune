﻿using UnityEngine;
using System.Collections;

public class mouse : MonoBehaviour
{
	public string cubeTag="button";

	// Update is called once per frame  
	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Ray ray = new Ray();
			RaycastHit hit = new RaycastHit();
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			//マウスクリックした場所からRayを飛ばし、オブジェクトがあればtrue 
			if (Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity))
			{
				if(hit.collider.gameObject.CompareTag(cubeTag))
				{
					hit.collider.gameObject.GetComponent<button>().clicked();
				}
			}
		}
	}

}