using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class puntoAllAltroNoStop : MonoBehaviour
{
    // Start is called before the first frame update
    private NavMeshAgent agent;
    [SerializeField] private Transform []targets;
    private int index = 0;
    private int sens = 3;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        SetDestination();
    }

    // Update is called once per frame
    void Update()
    {
        if (index < targets.Length)
        {
            if (agent.remainingDistance <= agent.stoppingDistance)
            {
               index += sens;
               if (index >= targets.Length)
               {
                index = targets.Length - 2;
                sens = -1;
               }
               else if (index < 0)
               {
                index = 1;
                sens = 1;
               }

               SetDestination();
            }
        }
       
    }

    void SetDestination()
    {
        agent.SetDestination(targets[index].position);

    }

}
