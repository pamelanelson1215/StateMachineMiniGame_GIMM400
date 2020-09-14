using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChaseState : State
{
    Transform destination;
    public EnemyChaseState(StateController stateController) : base(stateController) { }

    public override void CheckTransitions()
    {
        /*if (!stateController.CheckIfInRange("Player"))
        {
            stateController.SetState(new PatrolState(stateController));
        }*/
    }

    public override void Act()
    {
        UnityEngine.Debug.Log("Chase");
        if (stateController.targetToChase != null)
        {
            destination = stateController.targetToChase.transform;
            stateController.ai.SetTarget(destination);
        }
    }

    public override void OnStateEnter()
    {
        //stateController.ChangeColor(Color.red);
        stateController.ai.agent.speed = 0.5f;
    }
}
