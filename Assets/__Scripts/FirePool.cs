using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePool : MonoBehaviour
{
float timeOfDestroying=0.2f; //Время после попадания Water в триггер, через которое Water уничтожается 
  
	void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("Water"))
		{
			Destroy(other.gameObject, timeOfDestroying);
		}
	}
}
