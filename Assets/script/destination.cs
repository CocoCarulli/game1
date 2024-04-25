using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class destination : MonoBehaviour
{
    private NavMeshAgent agent;
    [SerializeField] protected Transform []targets;
    protected int index = 0;
    protected int sens = 3;
    public bool IsAtDestination{
        get{return agent.remainingDistance <= agent.stoppingDistance;}
    }

    // Start is called before the first frame update
    protected void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        SetDestination();
    }

    // Update is called once per frame
    protected void Update()
    {
       if (IsAtDestination)
       {
        NextDestination();
       }
    }

    protected virtual void NextDestination()
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

    protected void SetDestination()
    {
        agent.SetDestination(targets[index].position);

    }

  
}
