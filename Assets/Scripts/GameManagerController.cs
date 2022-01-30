using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerController : MonoBehaviour
{
    Road road;

     void Start()
    {
        road = GameObject.Find("Road").GetComponent<Road>();

        
      
    }

    private void Update()
    {
        //road.gameObject.transform.position = new Vector2(0f, road.transform.position.y - road.Speed * Time.deltaTime);
    }
}
