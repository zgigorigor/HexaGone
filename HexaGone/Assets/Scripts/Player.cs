using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    float movement;
    public float moveSpeed = GameManager.MoveSpeed;
    //private bool moveRight;
    //private bool moveLeft;

    //public Joystick joystick;

    // Update is called once per frame
    void Update()
    {
        movement = KeyboardMovement();
        //movement = JoystickMovement();
        //movement = ButtonMovement();
        //ButtonMovement();
    }

    //public void LeftButtonDown()
    //{
    //    moveLeft = true;
    //    Debug.Log("button down");
    //}
    //public void LeftButtonUp()
    //{
    //    moveLeft = false;
    //}
    //public bool RightButtonDown() => moveRight = true;
    //public bool RightButtonUp() => moveRight = false;

    private static float KeyboardMovement() => Input.GetAxisRaw("Horizontal");

    //private float JoystickMovement() => joystick.Horizontal;

    //public void ButtonMovement()
    //{
    //    if (moveLeft)
    //    {
    //        movement = - moveSpeed;
    //        Debug.Log("checked movement to left");
    //    }
    //    else if (moveRight)
    //    {
    //        movement = moveSpeed;
    //    }
    //}

    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<ScoreManager>().LoseLife();
    }

    
}
