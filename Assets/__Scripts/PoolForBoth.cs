using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolForBoth : MonoBehaviour
{
   float timeOfDestroying=0.2f; //Время после попадания в триггер, через которое уничтожается 
  
	void OnTriggerEnter(Collider other)
	{
		Destroy(other.gameObject, timeOfDestroying);
	}
}
