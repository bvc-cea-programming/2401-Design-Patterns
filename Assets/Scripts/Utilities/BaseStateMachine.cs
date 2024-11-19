using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class BaseStateMachine : MonoBehaviour
{
    protected BaseState CurrentState;

    public virtual void SetState(BaseState newState)
    {
        //Exit the current state if it is available
        CurrentState?.ExitState();

        //Set the new state
        CurrentState = newState;

        //Enter the new state
        CurrentState.EnterState();
    }

    public virtual void Update()
    {
        CurrentState?.UpdateState();
    }
}
