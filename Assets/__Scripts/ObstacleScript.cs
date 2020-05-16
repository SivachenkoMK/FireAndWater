using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
   public float objectsOnButtons; //Параметр, который содержит количество объектов, которые нажимают на кнопки, отвечающие за это препятствие

   // В зависимости от параметра objectsOnButtons открываем или закрываем препятствие
      void Update() 
    {
       if(objectsOnButtons == 0f)
	   {
	   	   closeObstacle();
	   }
	   else 
	   openObstacle();
    }
	
	// Функции, в которых описываем,как происходит открытие и закрытие препятствия
	private void openObstacle()
	{
	   this.GetComponent<MeshRenderer>().enabled=false;
	   this.GetComponent<Collider>().enabled=false;
	}

	private void closeObstacle()
	{
	   this.GetComponent<MeshRenderer>().enabled=true;
	   this.GetComponent<Collider>().enabled=true;
	}
}
