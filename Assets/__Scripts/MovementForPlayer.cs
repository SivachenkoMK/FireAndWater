using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementForPlayer
{
    // Персонаж, над которым происходят изменения.
    [HideInInspector]
    public GameObject Player;
    // Базовая скорость персонажа.
    private float Speed { get; set; } = 2f;
    // Переменная, проверяющая, нажата ли кнопка отвечающая за движение влево.
    private bool IsLeftInputPressed = false;
    // Переменная, проверяющая, нажата ли кнопка отвечающая за движение вправо.
    private bool IsRightInputPressed = false;
    // Переменная, проверяющая нажата ли кнопка отвечающая за прыжок.
    private bool IsJumpInputPressed = false;
    // Переменная, отвечающая за сторону движения персонажа. 
    // Может быть -1 - движение влево.
    // Может быть 0 - персонаж не двигается.
    // Может быть 1 - движение вправо.
    private float dx = 0;
    // Переменная отвечающая за движение вверх.
    private float dy = 0;
    // Луч, которым мы проверяем расстояните до земли.
    private RaycastHit hit;
    // Минимальная дистанция до земли при которой игрок сможет прыгнуть от нее.
    private float MaxDistance = 0.005f;
    // Напрваление вниз.
    private Vector3 DirectionDown = Vector3.down;
    // Сила дающаяся игроку во время прыжка.
    private float ForceWhenJump = 7.5f;
    // Переменная отвечающая за нахождение персонажа на земле.
    private bool OnTheGround = false;
    // Луч который бьет персонажу под ноги и смотрит попал ли он во что-то, если да то на каком расстоянии.
    private Ray ray;
    // Метод, проверяющий, может ли персонаж двигаться.
    // Например, если он завяз в болоте, то он двигаться не сможет.
    private KeyCode LeftKey;
    private KeyCode RightKey;
    private KeyCode JumpKey;

    public void InitKey()
    {
        if (Player.tag == "Fire")
        {
            LeftKey = KeyCode.A;
            RightKey = KeyCode.D;
            JumpKey = KeyCode.W;
        }
        if(Player.tag == "Water")
        {
            LeftKey = KeyCode.LeftArrow;
            RightKey = KeyCode.RightArrow;
            JumpKey = KeyCode.UpArrow;
        }
    }

    private bool CanMove()
    {
        return true;
    }

    // Метод, собирающий все входные данные из других методов.
    private void GetInput()
    {
        GetInputForDX();
        GetAllInputForJump();
    }

    // Вызов методов для получения входных данных для горизонтального движения.
    private void GetInputForDX()
    {
        GetInputForMovingLeft();
        GetInputForMovingRight();
    }

    // Вызов методов для получения входных данных и информации для прыжка.
    private void GetAllInputForJump()
    {
        IsGrounded();
        GetInputForJump();
    }

    // Метод, получающий входные данные для движения влево.
    private void GetInputForMovingLeft()
    {
        if (Input.GetKey(LeftKey))
        {
            IsLeftInputPressed = true;
        }
        else
        {
            IsLeftInputPressed = false;
        }
    }

    // Метод, получающий входные данные для движения вправо.
    private void GetInputForMovingRight()
    {
        if (Input.GetKey(RightKey))
        {
            IsRightInputPressed = true;
        }
        else
        {
            IsRightInputPressed = false;
        }
    }

    // Метод, получающий входные данные для прыжка персонажа.
    private void GetInputForJump()
    {
        if (Input.GetKey(JumpKey))
        {
            IsJumpInputPressed = true;
        }
        else
        {
            IsJumpInputPressed = false;
        }
    }

    private bool NotForbidenToJumpFrom(GameObject Object)
    {
        if (!Object.CompareTag("Fire") && !Object.CompareTag("Water"))
            return true;
        return false;
    }

    // Метод, проверяющий неходится ли персонаж на земле.
    private void IsGrounded()
    {
        ray = new Ray(Player.transform.position, DirectionDown);
        Physics.Raycast(ray, out hit);
        if (hit.collider != null && hit.distance <= 0.4 + MaxDistance && NotForbidenToJumpFrom(hit.collider.gameObject))
            OnTheGround = true;
        else
            OnTheGround = false;
    }

    // Метод, выполняющий получение установленых другими методами данных.
    private void SetInput()
    {
        SetDX();
        SetDY();
    }

    // Метод, обрабатывающий dx.
    private void SetDX()
    {
        dx = 0;
        if (IsLeftInputPressed && IsRightInputPressed)
        {
            dx = 0;
        }
        else if (IsLeftInputPressed)
        {
            dx = -1;
        }
        else if (IsRightInputPressed)
            dx = 1;
        else
            dx = 0;
    }

    private void SetDY()
    {
        if (IsJumpInputPressed && OnTheGround)
            dy = 1;
        else
            dy = 0;
    }

    // Временная переменная для обработки смены позиции персонажа.
    Vector3 PlayerPosition;

    // Метод, передвигающий персонажа.
    private void MoveRightOrLeft()
    {
        PlayerPosition = Player.transform.position;
        PlayerPosition = new Vector3(PlayerPosition.x + dx * Speed * Time.deltaTime, PlayerPosition.y, PlayerPosition.z);
        Player.transform.position = PlayerPosition;
    }

    // Прыжок.
    private void Jump()
    {
        Player.GetComponent<Rigidbody>().AddForce(Vector3.up * ForceWhenJump * dy, ForceMode.Impulse);
    }

    // Метод, вызывающий все движение для персонажа.
    // Хочу обьединить движение вверх и вбок в одну строчку.
    private void MovePerson()
    {
        MoveRightOrLeft();
        Jump();
    }

    // Главный метод отвечающая за вызов всех нужных предыдущих методов в нужном порядке.
    public void CallAllMovement()
    {
        GetInput();
        SetInput();
        if (CanMove())
            MovePerson();
    }
}

