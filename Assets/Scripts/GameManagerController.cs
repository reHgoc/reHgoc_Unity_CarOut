using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerController : MonoBehaviour
{
    Road road;

     void Start()
    {
        road = GameObject.FindGameObjectWithTag("Road").GetComponent<Road>();
    }

     void Update()
    {
        
    }

    public void NextRoad()
    {
        GameObject next = Resources.Load<GameObject>("Prefabs/2"); // here use arrays game object with road
        var SpriteRoad = GameObject.FindGameObjectsWithTag("Road");

        foreach(GameObject go in SpriteRoad)
        {
          //Invoke this method each need time
          go.GetComponent<SpriteRenderer>().sprite = next.GetComponent<SpriteRenderer>().sprite;

        }
        
    }
}
