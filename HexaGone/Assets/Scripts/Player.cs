using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    float movement = 0f;
    public float moveSpeed = 400f;
    public bool moveRight;
    public bool moveLeft;

    public Joystick joystick;

    // Update is called once per frame
    void Update()
    {
        movement = KeyboardMovement();
        //movement = JoystickMovement();

    }

    private static float KeyboardMovement() => Input.GetAxisRaw("Horizontal");

    private float JoystickMovement() => joystick.Horizontal;

    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<ScoreManager>().LoseLife();
    }
}
