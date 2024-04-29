using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamerespawn : MonoBehaviour
{
   public float threshold;
   public Vector3 spawnpoint;


    // Update is called once per frame
    void Update()
    {
        if(transform.position.y <threshold)
        {
            transform.position = spawnpoint;
            GameManager.health -= 1;
        }
    }
}
