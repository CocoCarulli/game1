using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class round : MonoBehaviour
{
 public Transform teleportport;
 public GameObject thePlayer;

 void OnTriggerEnter(Collider other){
   Debug.Log($"Teleport:{other.name}");
    thePlayer.transform.position = teleportport.transform.position;
 }

}
