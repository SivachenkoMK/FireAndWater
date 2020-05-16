using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
   public GameObject obstacle; //Препятствие, на котором висит скрипт с параметром objectsOnButtons

   // Функции, которые изменяют параметр objectsOnButtons, когда кто-то заходит или выходит из зоны кнопки
   private void OnTriggerEnter(Collider other)
   {
   	   obstacle.GetComponent<ObstacleScript>().objectsOnButtons+=1f;
   }

   private void OnTriggerExit(Collider other)
   {
   	   obstacle.GetComponent<ObstacleScript>().objectsOnButtons-=1f;
   }
}
