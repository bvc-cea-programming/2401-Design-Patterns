using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrolling : BaseState
{
    private EnemyStateMachine _stateMachine;
    
    public EnemyPatrolling(EnemyStateMachine stateMachine)
    {
        _stateMachine = stateMachine;
    }
    
    public override void EnterState()
    {
        Debug.Log("Enemy now entering the patrolling state");
    }

    public override void UpdateState()
    {
        
    }

    public override void ExitState()
    {
        Debug.Log("Enemy now exiting the patrolling state");
    }
}
