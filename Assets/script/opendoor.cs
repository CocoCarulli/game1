using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshObstacle))]

public class opendoor : MonoBehaviour
{
    //private bool isOpen = false;
    
    [SerializeField] Vector3 openPosition = Vector3.down;
    [SerializeField] float speed = 1f;

    Vector3 StartPosition;
    Vector3 EndPosition;


    private void Start()
    {
        StartPosition = transform.position;
        EndPosition = transform.position + openPosition;

    }

    private void MoveDoor()
    {
        if (Vector3.Distance(transform.position, EndPosition) > 0.01f)
        {
          transform.position += openPosition.normalized * speed *Time.deltaTime;
        }
        else
        {
          transform.position = EndPosition;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        MoveDoor();
    }
}
