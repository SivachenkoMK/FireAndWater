using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
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

	// Функции, в которых описываем,как происходит поднятие или спуск платформы
	private void RaisePlatform()
	{
	    this.transform.position=upPosition;
	}

	private void LowerPlatform()
	{
		 this.transform.position=downPosition;
	}
}
