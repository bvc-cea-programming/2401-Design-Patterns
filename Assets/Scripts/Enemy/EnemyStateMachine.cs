using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class EnemyStateMachine : BaseStateMachine
{
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
    [SerializeField] private Animator _enemyAnimations;

    public EnemyMovement EnemyMovement => _enemyMovement;
    public EnemyDetection EnemyDetection => _enemyDetection;
    public EnemyAlertVisualizer EnemyAlertVisualizer => _enemyAlertVisualizer;
    public Animator EnemyAnimations => _enemyAnimations;


    private void Awake()
    {
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
