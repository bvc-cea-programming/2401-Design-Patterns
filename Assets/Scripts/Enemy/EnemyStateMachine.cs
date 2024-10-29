using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateMachine : BaseStateMachine
{
    // Keep track of all the states
    private EnemyPatrolling _enemyPatrollingState;
    private EnemyFollowing _enemyFollowingState;

    public EnemyPatrolling EnemyPatrollingState => _enemyPatrollingState;
    public EnemyFollowing EnemyFollowingState => _enemyFollowingState;
    
    // Keep track of supporting components
    private EnemyMovement _enemyMovement;
    private EnemyDetection _enemyDetection;

    public EnemyMovement EnemyMovement => _enemyMovement;
    public EnemyDetection EnemyDetection => _enemyDetection;

    private void Awake()
    {
        _enemyPatrollingState = new EnemyPatrolling(this);
        _enemyFollowingState = new EnemyFollowing(this);
        
        _enemyMovement = GetComponent<EnemyMovement>();
        _enemyDetection = GetComponent<EnemyDetection>();
    }
}
