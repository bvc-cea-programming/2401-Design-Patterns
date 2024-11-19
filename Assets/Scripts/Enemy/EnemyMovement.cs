using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private Transform[] patrollingTargets;

    //Hold the current target
    private Transform _currentTarget;

    private NavMeshAgent _agent;

    private bool _isPatrolling = true;

    private void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();

        //Choose the first target
        ChooseRandomTarget();
    }

    // Update is called once per frame
    void Update()
    {
        UpdatePatrolling();
        UpdateTargetFollow();
    }

    public void SetPatrolling(bool value)
    {
        _isPatrolling = value;
        _agent.isStopped = !value;
    }


    public void FollowTarget(Transform target)
    {
        _isPatrolling = false;
        _currentTarget = target;
        Debug.Log(target.gameObject.name);
    }


    private void UpdatePatrolling()
    {
        if(!_isPatrolling) return;

        if(_agent.remainingDistance <= 0.5f)
        {
            ChooseRandomTarget();
        }
    }

    private void UpdateTargetFollow()
    {
        if (_isPatrolling) return;

        _agent.SetDestination(_currentTarget.position);
    }

    private void ChooseRandomTarget()
    {
        _currentTarget = patrollingTargets[Random.Range(0, patrollingTargets.Length)];
        _agent.SetDestination(_currentTarget.position);
    }

    public void StopMovement()
    {
        _agent.isStopped = true;
    }

    public void StartMovement()
    {
        _agent.isStopped = false;
    }
}
