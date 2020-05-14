using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField]
    private Vector3 Position;
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.position = Position;
    }
}