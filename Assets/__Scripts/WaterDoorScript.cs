using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDoorScript : MonoBehaviour
{
    public float waterObjectsOnPlatform; // Параметр, который содержит количество объектов с тегом Water возле двери

    // В зависимости от параметров waterObjectsOnPlatform и waterStonesCollected открываем или закрываем двери
    void Update()
    {
       if(waterObjectsOnPlatform == 0f) 
	   {
	   	   closeDoor();
	   }
	   else if(waterStonesCollected())
	   {
	      openDoor();
	   }
    }

	// Функции, в которых описываем, как происходит открытие или закрытие двери
	private void openDoor()
	{
		this.GetComponent<MeshRenderer>().enabled=false;
	}

	private void closeDoor()
	{
		this.GetComponent<MeshRenderer>().enabled=true;
	}

	// Функция, которая определяет, собраны ли все WaterStone
	bool waterStonesCollected()
	{
		if(GameObject.FindGameObjectWithTag("WaterStone") == null)
		return true;
		else return false;
	}
}
