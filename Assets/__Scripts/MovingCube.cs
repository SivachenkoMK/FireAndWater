using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCube : MonoBehaviour
{
  public float objectsOnButtons;
  
  void Update()
  {
  	  if(objectsOnButtons==0)
	  {
	  	 this.GetComponent<Rigidbody>().isKinematic=true;
	  }
	  else
	  this.GetComponent<Rigidbody>().isKinematic=false;
  }
}
