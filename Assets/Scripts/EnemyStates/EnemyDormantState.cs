using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class EnemyDormantState : State
{
    Transform destination;

    public EnemyDormantState(StateController stateController) : base(stateController) { }

    public override void CheckTransitions()
    {
        if (stateController.CheckIfInRange("Player"))
        {
            stateController.SetState(new EnemyChaseState(stateController));
        }
    }

    public override void Act()
    {
        UnityEngine.Debug.Log("Dormant");
    }

    public override void OnStateEnter()
    {
        //destination = stateController.GetNextNavPoint();
        if(stateController.ai.agent != null)
        {
            stateController.ai.agent.speed = 0f;
        }
        
        /*stateController.ai.SetTarget(destination);
        stateController.ChangeColor(Color.blue);*/
    }
}
