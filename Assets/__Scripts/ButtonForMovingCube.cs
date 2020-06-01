using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonForMovingCube : MonoBehaviour
{
public GameObject movingCube;
    void OnTriggerEnter(Collider other)
	{
		movingCube.GetComponent<MovingCube>().objectsOnButtons++;
	}
	  void OnTriggerExit(Collider other)
	{
		movingCube.GetComponent<MovingCube>().objectsOnButtons--;
	}
}
