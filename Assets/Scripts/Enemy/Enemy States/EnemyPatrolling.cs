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

    private Transform _threat;
    
    public override void EnterState()
    {
        Debug.Log("Enemy now entering the patrolling state");
        // Start Patrolling
        _stateMachine.EnemyMovement.StartMovement();
        _stateMachine.EnemyMovement.SetPatrolling(true);
        _stateMachine.EnemyAnimation.SetTrigger("Patrolling");
        
        //set default detection params
        _stateMachine.EnemyDetection.SetDetectionParams(5.0f, 90.0f);
    }

    public override void UpdateState()
    {
        Debug.Log("Enemy is now in patrolling, enemy is also detecting threats");
        
        // if we detect an enemy, go to the follow state
        _threat = _stateMachine.EnemyDetection.GetRecentThreat();
        if (_threat != null)
        {
            _stateMachine.SetState(_stateMachine.EnemyAlertState);
        }
    }

    public override void ExitState()
    {
        Debug.Log("Enemy now exiting the patrolling state");
        
        //Stop patrolling
        _stateMachine.EnemyMovement.SetPatrolling(false);
        _stateMachine.EnemyAnimation.ResetTrigger("Patrolling");
    }
}
