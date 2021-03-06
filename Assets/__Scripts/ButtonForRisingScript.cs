﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonForRisingScript : MonoBehaviour
{
    public GameObject risingPlatform; //Платформа, на которую влияет эта кнопка.

    // Методы, которые изменяют значение переменной objectsOnButtons.
    private void OnTriggerEnter(Collider other)
    {
        risingPlatform.GetComponent<RisingPlatform>().objectsOnButtons++;
    }

    private void OnTriggerExit(Collider other)
    {
         risingPlatform.GetComponent<RisingPlatform>().objectsOnButtons--;
    }
}
