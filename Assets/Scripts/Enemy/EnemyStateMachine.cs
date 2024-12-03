using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateMachine : BaseStateMachine
{
    private Animator animator;
    // Keep track of all the states
    private EnemyPatrolling _enemyPatrollingState;
    private EnemyFollowing _enemyFollowingState;
    private EnemyAlert _enemyAlertState;

    public EnemyPatrolling EnemyPatrollingState => _enemyPatrollingState;
    public EnemyFollowing EnemyFollowingState => _enemyFollowingState;
    public EnemyAlert EnemyAlertState => _enemyAlertState;
    
    // Keep track of supporting components
    private EnemyMovement _enemyMovement;
    private EnemyDetection _enemyDetection;
    private EnemyAlertVisualizer _enemyAlertVisualizer;

    public EnemyMovement EnemyMovement => _enemyMovement;
    public EnemyDetection EnemyDetection => _enemyDetection;
    public EnemyAlertVisualizer EnemyAlertVisualizer => _enemyAlertVisualizer;

    public Animator EnemyAnimation => animator;

    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        Debug.Log(animator);
        _enemyPatrollingState = new EnemyPatrolling(this);
        _enemyFollowingState = new EnemyFollowing(this);
        _enemyAlertState = new EnemyAlert(this);
        
        _enemyMovement = GetComponent<EnemyMovement>();
        _enemyDetection = GetComponent<EnemyDetection>();
        _enemyAlertVisualizer = GetComponent<EnemyAlertVisualizer>();
        
    }

    private void Start()
    {
        // Switch to the default state of patrolling
        SetState(_enemyPatrollingState);
    }
}
