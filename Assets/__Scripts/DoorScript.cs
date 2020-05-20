using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public bool IsOpened;

	[SerializeField]
    private string TagOfNeededObject;

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag(TagOfNeededObject))
			IsOpened = true;
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.CompareTag(TagOfNeededObject))
			IsOpened = false; ;
	}

	private void Update()
	{
		if (IsOpened && StonesCollected())
			OpenDoor();
		else
			CloseDoor();
	}

	private void OpenDoor()
	{
		this.GetComponent<MeshRenderer>().enabled = false;
	}
	
	private void CloseDoor()
	{
		this.GetComponent<MeshRenderer>().enabled = true;
	}

	private bool StonesCollected()
	{
		if (GameObject.FindGameObjectWithTag(TagOfNeededObject + "Stone") == null)
			return true;
		else return false;
	}
}
