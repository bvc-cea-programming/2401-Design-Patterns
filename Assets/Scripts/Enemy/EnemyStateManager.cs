using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateManager : MonoBehaviour
{

    private EnemyMovement _enemyMovement;
    private EnemyDetection _enemyDetection;

    private void Awake()
    {
        _enemyMovement = GetComponent<EnemyMovement>();
        _enemyDetection = GetComponent<EnemyDetection>();
    }

    private void Update()
    {
        
        // if a threat has been detected, follow the threat, if not patrol
        var threat = _enemyDetection.GetRecentThreat();

        if (threat)
        {
            _enemyMovement.FollowTarget(threat);
        }
        else
        {
            _enemyMovement.SetPatrolling(true);
        }

    }
}
