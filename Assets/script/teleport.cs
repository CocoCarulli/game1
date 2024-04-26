using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
   public Transform teleportPerso;
   public GameObject thePlayer;

   void OnTriggerEnter(Collider other)
   {
    thePlayer.transform.SetPositionAndRotation(teleportPerso.transform.position, teleportPerso.transform.rotation);
    Physics.SyncTransforms();
   }
}
