using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class EnemySeenState : State
{
    Transform destination;

    public EnemySeenState(StateController stateController) : base(stateController) { }

    public override void CheckTransitions()
    {
        //If not seen, transition back to EnemyChaseState
    }

    public override void Act()
    {
        UnityEngine.Debug.Log("Seen");
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
