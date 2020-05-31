using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonForMovingPlatform : MonoBehaviour
{
    public GameObject movingPlatform; //Платформа, на которую влияет эта кнопка.

    // Методы, которые изменяют значение переменной objectsOnButtons.
    private void OnTriggerEnter(Collider other)
    {
        movingPlatform.GetComponent<MovingPlatform>().objectsOnButtons++;
    }

    private void OnTriggerExit(Collider other)
    {
         movingPlatform.GetComponent<MovingPlatform>().objectsOnButtons--;
    }
}
