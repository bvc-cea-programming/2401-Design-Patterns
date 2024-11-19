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

    private Transform _threat;
    
    public override void EnterState()
    {
        Debug.Log("Enemy now entering the following state");
    }

    public override void UpdateState()
    {
        Debug.Log("Hey stop! I am following youuuuuu!!! >_<");
        // if the threat is still around, keep following it. If not, go to the patrolling state
        _threat = _stateMachine.EnemyDetection.GetRecentThreat();

        if (_threat)
        {
            _stateMachine.EnemyMovement.StartMovement();
            _stateMachine.EnemyMovement.FollowTarget(_threat);
        }
        else
        {
            _stateMachine.SetState(_stateMachine.EnemyPatrollingState);
        }
    }

    public override void ExitState()
    {
        Debug.Log("Enemy now exiting the following state");
    }
}
