using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterStone : MonoBehaviour
{
  public float amountOfCollectedWaterStones; //Переменная, в которой хранится количество собранных WaterStones
		
   void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("Water"))
		{
			Destroy(this.gameObject);
			amountOfCollectedWaterStones++;
		}
	}
}
