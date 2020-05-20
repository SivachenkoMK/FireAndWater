using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerForObstacle : MonoBehaviour
{
    public GameObject Obstacle; // Из этого объекта получим переменную, которая отвечает за открытие и закрытие препятствия и соответственно деактивирование и активирование триггера
	
	// Метод, который определяет, нужно ли активировать триггер
    void Update()
    {
       if(Obstacle.GetComponent<ObstacleScript>().objectsOnButtons == 0f) 
	   {
	   	   this.GetComponent<Collider>().enabled=true;
	   }
	   else  this.GetComponent<Collider>().enabled=false;
    }
	
	// Прописываем удаление объекта, который попал в триггер(то есть когда препятствие задевает объект)
	void OnTriggerEnter(Collider other)
	{
		Destroy(other.gameObject);
	}
}
