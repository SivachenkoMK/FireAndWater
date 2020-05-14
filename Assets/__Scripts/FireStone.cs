﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireStone : MonoBehaviour
{   
	void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("Fire"))
		{
			Destroy(this.gameObject);
		}
	}
	
}
