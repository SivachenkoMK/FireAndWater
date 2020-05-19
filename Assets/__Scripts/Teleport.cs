using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField]
    public GameObject target; // В эту переменную помещаем пустой геймобджект, и присваиваем его позицию объекту, который зайдёт в триггер

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.position = target.transform.position;
    }
}