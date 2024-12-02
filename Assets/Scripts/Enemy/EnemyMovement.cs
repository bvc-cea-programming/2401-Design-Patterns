using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private Transform[] patrollingTargets;
    
    // Hold the current target
    private Transform _currentTarget;
    private NavMeshAgent _agent;
    private bool _isPatrolling = true;
    
    private void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
        
        //Choose the first target
        ChooseRandomTarget();
    }

    private void FixedUpdate()
    {
        UpdatePatrolling();
        UpdateTargetFollow();
    }

    public void SetPatrolling(bool value)
    {
        _isPatrolling = value;
    }

    public void StopMovement()
    {
        _agent.isStopped = true;
    }

    public void StartMovement()
    {
        _agent.isStopped = false;
    }
    

    public void FollowTarget(Transform target)
    {
        _isPatrolling = false;
        _currentTarget = target;
    }

    private void UpdatePatrolling()
    {
        if(!_isPatrolling) return;
        
        if (_agent.remainingDistance <= 0.5f)
        {
            ChooseRandomTarget();
        }
    }

    private void UpdateTargetFollow()
    {
        if(_isPatrolling) return;
        
        _agent.SetDestination(_currentTarget.position);
    }

    private void ChooseRandomTarget()
    {
        _currentTarget = patrollingTargets[Random.Range(0, patrollingTargets.Length)];
        _agent.SetDestination(_currentTarget.position);
    }
}
