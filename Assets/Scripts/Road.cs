using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    public float Speed = 2.3f;
    public float HeightSprite;

    public Vector2 position;
    public Vector2 newPos;

    void Awake()
    {

    }

     void Start()
    {
        HeightSprite = GetComponentInParent<SpriteRenderer>().sprite.rect.height / GetComponentInParent<SpriteRenderer>().sprite.pixelsPerUnit;
        position = new Vector2(0f, this.transform.position.y);
        newPos = position;

    }

    void Update()
    {
        MoveRoad();
    }

    void MoveRoad()
    {
        newPos.y -= Speed * Time.deltaTime;
        this.transform.position = new Vector2(0f, newPos.y);

        if (newPos.y <= -HeightSprite)
            newPos.y = HeightSprite;

       
    }

    
}
