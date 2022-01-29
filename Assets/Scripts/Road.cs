using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    float Speed = 2.3f;
    Vector2 position;
    Vector2 newPos;

     void Awake()
    {
        position = new Vector2(0f, transform.position.y);
    }

     void Start()
    {
        
    }

    void Update()
    {
        newPos.y -= Speed * Time.deltaTime;
        transform.position = new Vector2(0f, newPos.y);

        if (newPos.y < -9.07f)
            newPos = position;
        
    }
}
