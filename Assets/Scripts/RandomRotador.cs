﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotador : MonoBehaviour {

	public float tumble;

	void Start ()
	{
		GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble; 
	}
		
}
