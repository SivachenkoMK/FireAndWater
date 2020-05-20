using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformUnderFireDoorScript : MonoBehaviour
{
    public GameObject fireDoor; //Из этого объекта берём значение параметра fireObjectsOnPlatform, которое говорит, сколько объектов Fire находятся на платформе

	// Методы, которые изменяют fireObjectsOnPlatform в зависимости от того, зашел ли Fire в триггер
	private void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("Fire"))
		{
			fireDoor.GetComponent<FireDoorScript>().fireObjectsOnPlatform+=1f;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if(other.CompareTag("Fire"))
		{
			fireDoor.GetComponent<FireDoorScript>().fireObjectsOnPlatform-=1f;
		}
	}
}
