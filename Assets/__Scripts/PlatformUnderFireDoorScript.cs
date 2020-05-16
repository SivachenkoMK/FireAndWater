using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformUnderFireDoorScript : MonoBehaviour
{
    public GameObject fireDoor;

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
