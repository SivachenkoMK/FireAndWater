using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireDoorScript : MonoBehaviour
{
   public float fireObjectsOnPlatform; // Параметр, который содержит количество объектов с тегом Fire возле двери

    // В зависимости от параметров fireObjectsOnPlatform и fireStonesCollected открываем или закрываем двери
    void Update()
    {
       if(fireObjectsOnPlatform == 0f) 
	   {
	   	   closeDoor();
	   }
	   else if(fireStonesCollected())
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

	// Функция, которая определяет, собраны ли все FireStone
	bool fireStonesCollected()
	{
		if(GameObject.FindGameObjectWithTag("FireStone") == null)
		return true;
		else return false;
	}
}
