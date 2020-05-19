using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformUnderWaterDoor : MonoBehaviour
{
     public GameObject waterDoor; //Из этого объекта берём значение параметра waterObjectsOnPlatform, которое говорит, сколько объектов Water находятся на платформе

	// Методы, которые изменяют waterObjectsOnPlatform в зависимости от того, зашел ли Water в триггер
    private void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("Water"))
		{
			waterDoor.GetComponent<WaterDoorScript>().waterObjectsOnPlatform+=1f;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if(other.CompareTag("Water"))
		{
			waterDoor.GetComponent<WaterDoorScript>().waterObjectsOnPlatform-=1f;
		}
	}
}
