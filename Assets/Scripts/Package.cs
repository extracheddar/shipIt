﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Package : MonoBehaviour
{
	public float forwardThrust;
	
	// Update is called once per frame
	void Update () {
		Debug.Log(forwardThrust);
		if (forwardThrust <= 0)
		{
			forwardThrust = 0;
		}
		else
		{
			transform.Translate(Vector3.up * (Time.deltaTime * forwardThrust));
			forwardThrust = forwardThrust - 1.25f * Time.deltaTime;			
		}
		
	}
}