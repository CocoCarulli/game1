using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemystatemachine
{

    public Istate CurrentState {get; private set;}
    public chasestate chasestate;
    public patrolstate patrolstate;

   public enemystatemachine(NavMeshAgent agent, Transform playertransform, enemy enemy)
   {
    chasestate = new chasestate(enemy, this);
    patrolstate = new patrolstate(enemy, this);
   }

   public void Update()
   {
    CurrentState?.Update();
   }

   public void TransitionTo(Istate nextState)
   {
    CurrentState?.Exit();
    CurrentState = nextState;
    CurrentState.Enter();
   }

   public void Initializate(Istate startingState)
   {
    CurrentState = startingState;
    startingState.Enter();
   }
}
