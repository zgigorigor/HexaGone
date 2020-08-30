using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public float moveSpeed = 400f;

    float movement = 0f;

    public Joystick joystick;

    // Update is called once per frame
    void Update()
    {
        //movement = Input.GetAxisRaw("Horizontal");
        movement = joystick.Horizontal;
    }

    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<ScoreManager>().LoseLife();
    }
}
