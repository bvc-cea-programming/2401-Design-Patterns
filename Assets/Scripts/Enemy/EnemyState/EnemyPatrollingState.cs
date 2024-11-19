using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrollingState : BaseState
{
    private EnemyStateMachine _stateMachine;
    private Transform threat;
    public EnemyPatrollingState(EnemyStateMachine stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public override void EnterState()
    {
        Debug.Log("Enemy now entering the patrolling state");
        //Start patrolling
        _stateMachine.EnemyMovement.StartMovement();
        _stateMachine.EnemyMovement.SetPatrolling(true);
        _stateMachine.EnemyDetection.EnemyPowerful(5f, 90f);
    }

    public override void ExitState()
    {
        Debug.Log("Enemy now exiting the patrolling state");

        //Stop Patrolling
        _stateMachine.EnemyMovement.SetPatrolling(false);
    }

    public override void UpdateState()
    {
        Debug.Log("Enemy is now in patrolling, enemy is also detecting threats");

        //If we detect an enemy, got to the follow state
        threat = _stateMachine.EnemyDetection.GetRecentThreat();
            if(threat != null )
        {
            _stateMachine.SetState(_stateMachine.EnemyAlertState);
        }
    }
}
