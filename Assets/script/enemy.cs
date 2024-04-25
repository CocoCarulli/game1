using System.Collections;
using System.Collections.Generic;
using System.Text;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class enemy : MonoBehaviour
{
       [SerializeField] public Transform target;
       [HideInInspector] public NavMeshAgent agent;

       public Transform waypoints;

       private enemystatemachine statemachine;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        statemachine = new enemystatemachine(agent, target, this);
        statemachine.Initializate(statemachine.patrolstate);
    }

    public bool CanSeePlayer()
    {
        Vector3 enemyFacing = transform.forward;
        Vector3 enemyPos = transform.position;
        Vector3 enemyToPlayer = target.position - enemyPos;
        Vector3 offset = Vector3.up * 0.01f;


        RaycastHit hit;

        if (Physics.Raycast(enemyPos + offset, enemyToPlayer + offset, out hit, 15f))
        {
            Debug.Log(hit.collider.name);
            if (hit.collider.CompareTag("Player"))
            {
                if (Vector3.Angle(enemyFacing, enemyToPlayer) <= 50f)
                {
                   return true;
                }
            }
        }
        return false;
    }


    void Update()
    {
       statemachine.Update();
       
    }
    
}
