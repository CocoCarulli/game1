using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class patrolstate : Istate
{
  private NavMeshAgent agent;
  private Transform waypoints;

  private enemy enemy;
  private enemystatemachine stateMachine;


  public patrolstate(enemy enemy, enemystatemachine stateMachine)
  {
    this.enemy = enemy;
    this.stateMachine = stateMachine;
    agent = enemy.agent;
    waypoints = enemy.waypoints;
    
  }


  public bool Isatdestination
  {
    get {return agent.remainingDistance <= agent.stoppingDistance;}
  }
  private void SelectDestination()
  {
     int numWaypoints = waypoints.childCount;

     int rndIndex = Random.Range(0, numWaypoints);
     Transform target = waypoints.GetChild(rndIndex);
     agent.SetDestination(target.position);
  }

  public void Enter()
  {
    SelectDestination();
  }

  public void Update()
  {
    if (Isatdestination)
        SelectDestination();

    if (enemy.CanSeePlayer())
    {
        stateMachine.TransitionTo(stateMachine.chasestate);
    }
  }

}
