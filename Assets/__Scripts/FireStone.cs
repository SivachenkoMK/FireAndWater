using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireStone : MonoBehaviour
{   
public float amountOfCollectedFireStones; //Переменная, в которой хранится количество собранных FireStones
	void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("Fire"))
		{
			Destroy(this.gameObject);
			amountOfCollectedFireStones++;
		}
	}
	
}
