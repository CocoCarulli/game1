using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class chasestate : Istate
{

    private NavMeshAgent agent;
    private Transform target;

    private enemy enemy;

    private enemystatemachine stateMachine;

    public chasestate(enemy enemy, enemystatemachine stateMachine)
    {
        this.enemy = enemy;
        this.stateMachine = stateMachine;
        agent = enemy.agent;
        target = enemy.target;
    }
    public void Enter()
    {
      Debug.Log("entering chasestate");
    }

    public void Update()
    {
      agent.SetDestination(target.position);
      if (!enemy.CanSeePlayer()){
        stateMachine.TransitionTo(stateMachine.patrolstate);
      }
    }

    public void Exit()
    {
      Debug.Log("exting chasestate");

    }
}
