using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowing : BaseState
{
    private EnemyStateMachine _stateMachine;
    
    public EnemyFollowing(EnemyStateMachine stateMachine)
    {
        _stateMachine = stateMachine;
    }
    
    public override void EnterState()
    {
        Debug.Log("Enemy now entering the following state");
    }

    public override void UpdateState()
    {
        
    }

    public override void ExitState()
    {
        Debug.Log("Enemy now exiting the following state");
    }
}
