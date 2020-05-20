using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField]
    public Vector3 Destination; 

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.position = Destination;
    }
}