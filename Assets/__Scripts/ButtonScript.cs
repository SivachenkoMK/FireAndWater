using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject Obstacle; //Препятствие, на которое влияет эта кнопка.

    // Методы, которые изменяют параметр количества объектов открывающих препятствие, когда кто-то наступает на кнопку.
    private void OnTriggerEnter(Collider other)
    {
        Obstacle.GetComponent<ObstacleScript>().objectsOnButtons++;
    }

    private void OnTriggerExit(Collider other)
    {
        Obstacle.GetComponent<ObstacleScript>().objectsOnButtons--;
    }
}
