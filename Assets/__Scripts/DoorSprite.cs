using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSprite : MonoBehaviour
{
    public GameObject door;

    void Update()
    {
      if(door.GetComponent<DoorScript>().IsOpened==true)
	  {
	  	  this.GetComponent<SpriteRenderer>().enabled=false;
	  }  
	  else
	   this.GetComponent<SpriteRenderer>().enabled=true;
    }
}
