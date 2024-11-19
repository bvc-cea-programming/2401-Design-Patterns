using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateMachine : BaseStateMachine
{
    //Keep track of all the states
    private EnemyPatrollingState _enemyPatrollingState;
    private EnemyFollowState _enemyFollowState;
    private EnemyAlert _enemyAlertState;

    public EnemyPatrollingState EnemyPatrollingState => _enemyPatrollingState;
    public EnemyFollowState EnemyFollowState => _enemyFollowState;
    public EnemyAlert EnemyAlertState => _enemyAlertState;

    //Keep track of supporting components
    private EnemyMovement _enemyMovement;
    private EnemyDetection _enemyDetection;
    private EnemyAlertVisualizer _enemyAlertVisualizer;

    public EnemyMovement EnemyMovement => _enemyMovement;
    public EnemyDetection EnemyDetection => _enemyDetection;
    public EnemyAlertVisualizer EnemyAlertVisualizer => _enemyAlertVisualizer;

    private void Awake()
    {
        _enemyPatrollingState =  new EnemyPatrollingState(this);
        _enemyFollowState = new EnemyFollowState(this);
        _enemyAlertState = new EnemyAlert(this);

        _enemyMovement = GetComponent<EnemyMovement>();
        _enemyDetection = GetComponent<EnemyDetection>();
        _enemyAlertVisualizer = GetComponent<EnemyAlertVisualizer>();
    }

    private void Start()
    {
        //Switch to the default state of patrolling
        SetState(_enemyPatrollingState);
    }
}
