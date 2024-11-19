using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowState : BaseState
{
    private EnemyStateMachine _stateMachine;
    private Transform _threat;
    public EnemyFollowState(EnemyStateMachine stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public override void EnterState()
    {
        Debug.Log("Enemy now entering the Following state");

        _stateMachine.EnemyDetection.EnemyPowerful(20f, 180f);
    }

    public override void ExitState()
    {
        Debug.Log("Enemy now exiting the Following state");
    }

    public override void UpdateState()
    {
        //If the threat is still around, keep following it. If not, go to the patrolling state
        _threat = _stateMachine.EnemyDetection.GetRecentThreat();

        if(_threat)
        {
            _stateMachine.EnemyMovement.StartMovement();
            _stateMachine.EnemyMovement.FollowTarget(_threat);
        }
        else
        {
            _stateMachine.SetState(_stateMachine.EnemyPatrollingState);
        }
    }
}
