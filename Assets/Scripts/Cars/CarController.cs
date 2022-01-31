using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : Cars
{
    float ShiftSpeed;
    float movement;

    // add last and current position that can shifting car

    Rigidbody2D rb;
    Vector2 CarPosition;


    private void Start()
    {
        ShiftSpeed = 15f;
        movement += Input.GetAxis("Horizontal");
        rb = GetComponent<Rigidbody2D>();
        CarPosition = this.transform.position;
    }

    void Update()
    {
        if (movement == 0)
            return;
        if (movement < 0)
        {
            MoveLeft();
        }
        if (movement > 0)
        {
            MoveRight();
        }
    }

    void MoveLeft()
    {
        foreach(var pos in point)
        {
            /* if (pos.position.x < this.transform.position.x)
                 transform.position = Vector2.MoveTowards(this.transform.position, pos.position, movement * ShiftSpeed * Time.deltaTime);
            */

            print(pos);
                
        }
    }

    void MoveRight()
    {

    }
}
