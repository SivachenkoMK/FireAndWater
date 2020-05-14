using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoMovementForPlayer : MonoBehaviour
{
    // Исполнительная перемення
    MovementForPlayer Controller = new MovementForPlayer();
    private void Awake()
    {
        Controller.Player = this.gameObject;
        Controller.InitKey();
    }
    private void FixedUpdate()
    {
        Controller.CallAllMovement();
    }
}
