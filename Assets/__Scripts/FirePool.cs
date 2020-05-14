using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePool : MonoBehaviour
{
float timeOfDestroying=0.1f;
  
	void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("Water"))
		{
			Destroy(other.gameObject, timeOfDestroying);
		}
	}
}
