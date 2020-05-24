using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPool : MonoBehaviour
{
   float timeOfDestroying=0.2f; //Время после попадания Fire в триггер, через которое Fire уничтожается 
  
	void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("Fire"))
		{
			Destroy(other.gameObject, timeOfDestroying);
		}
	}
}
