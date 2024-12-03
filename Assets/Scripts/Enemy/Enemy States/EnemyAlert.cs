using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAlert : BaseState
{
    private EnemyStateMachine _stateMachine;

    public EnemyAlert(EnemyStateMachine stateMachine)
    {
        _stateMachine = stateMachine;
    }

    private float _timer = 0;

    public override void EnterState()
    {
        // stop the movement of the player
        _stateMachine.EnemyMovement.StopMovement();
        _stateMachine.EnemyMovement.SetPatrolling(false);
        
        // show the alert gizmo " ! "
        _stateMachine.EnemyAlertVisualizer.ShowAlert();
        
        // Make the enemy powerful
        //set default detection params
        _stateMachine.EnemyDetection.SetDetectionParams(20.0f, 180.0f);
       

        _timer = 0;
    }

    public override void UpdateState()
    {
        //Wait for a moment and go to follow state
        _timer += Time.deltaTime;
        if (_timer > _stateMachine.EnemyAlertVisualizer.AlertTime)
        {
            StartFollow();
            _stateMachine.AnimtorControler.SetTrigger("alart");
        }
    }

    public override void ExitState()
    {
        
    }

    private void StartFollow()
    {
        _stateMachine.SetState(_stateMachine.EnemyFollowingState);
        _stateMachine.AnimtorControler.SetTrigger("follow");
    }
}
