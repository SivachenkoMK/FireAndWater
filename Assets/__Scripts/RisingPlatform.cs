using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RisingPlatform : MonoBehaviour
{
  public float objectsOnButtons; //Параметр, который содержит количество объектов, которые нажимают на кнопки, отвечающие за эту платформу

  // Переменные, в которых хранятся верхняя и нижняя позиции платформы
  public Vector3 upPosition;
  public Vector3 downPosition;
  
	// В зависимости от параметра objectsOnButtons вызываем функции для поднятия или спуска платформы
	void Update()
	{
		if (objectsOnButtons == 0f)
		{
			LowerPlatform();
		}
		else
		    RaisePlatform();
	}

	// Функции, в которых описываем,как происходит поднятие или спуск платформы(пока мы не придумали, как сделать анимацию, будем просто активировать и деактивировать коллайдер и меш)
	private void RaisePlatform()
	{
		this.GetComponent<Collider>().enabled=true;
		this.GetComponent<MeshRenderer>().enabled=true;
	}
	private void LowerPlatform()
	{
		this.GetComponent<Collider>().enabled=false;
		this.GetComponent<MeshRenderer>().enabled=false;
	}
}
