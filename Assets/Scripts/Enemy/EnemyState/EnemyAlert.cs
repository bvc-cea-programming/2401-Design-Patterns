using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAlert : BaseState
{
    private EnemyStateMachine _stateMachine;
    private float _timer;

    public EnemyAlert(EnemyStateMachine stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public override void EnterState()
    {
        //Stop the movement of the player
        _stateMachine.EnemyMovement.StopMovement();
        _stateMachine.EnemyMovement.SetPatrolling(false);

        //Show the alert gizmo "!"
        _stateMachine.EnemyAlertVisualizer.ShowAlert();

        _timer = 0;
    }

    public override void ExitState()
    {
        
    }

    public override void UpdateState()
    {
        //Wait for a moment and go to follow state
        _timer += Time.deltaTime;
        if(_timer > _stateMachine.EnemyAlertVisualizer.AlertTime)
        {
            StartFollow();
        }
    }

    private void StartFollow()
    {
        _stateMachine.SetState(_stateMachine.EnemyFollowState);
    }
}
