using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetection : MonoBehaviour
{
    [SerializeField] private float viewRadius;
    [SerializeField] private LayerMask detectionLayerMask;
    
    [Range(0, 360)]
    [SerializeField] private float viewAngle;

    private List<Transform> _visibleThreats = new List<Transform>();

    private void FixedUpdate()
    {
        Detect();
    }

    public Transform GetRecentThreat()
    {
        if (_visibleThreats.Count == 0) return null;

        return _visibleThreats[0];
    }

    public void SetDetectionParams(float ViewRadius, float ViewAngle)
    {
        viewAngle = ViewAngle;
        viewRadius = ViewRadius;
    }

    private void Detect()
    {
        _visibleThreats.Clear();
        
        // get all the colliders within the area of the enemy
        var targetsInViewRadius = Physics.OverlapSphere(transform.position, viewRadius, detectionLayerMask);

        for (var i = 0; i < targetsInViewRadius.Length; i++)
        {
            var target = targetsInViewRadius[i].transform;
            var directionToTarget = (target.position - transform.position).normalized;
            
            //check if the target is within the spectrum
            if (Vector3.Angle(transform.forward, directionToTarget) < viewAngle/2)
            {
                _visibleThreats.Add(target);
                Debug.Log("Threat Detected!");
            }
        }
    }
    
    
    
    [Header("Gizmo")]
    [SerializeField] private float viewSpectrumIterator=5;
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        foreach (var target in _visibleThreats)
        {
            Gizmos.DrawLine(transform.position, target.position);
        }
        
        Gizmos.color = Color.yellow;
        float halfFOV = viewAngle / 2.0f;

        for (float i = -halfFOV; i < halfFOV; i+=viewSpectrumIterator)
        {
            Quaternion rayRot = Quaternion.AngleAxis( i, Vector3.up );
            Vector3 rayDir = rayRot * transform.forward;
            Gizmos.DrawRay( transform.position, rayDir * viewRadius );
        }
        
        Gizmos.color = Color.red;
        Quaternion leftRayRotation = Quaternion.AngleAxis( -halfFOV, Vector3.up );
        Quaternion rightRayRotation = Quaternion.AngleAxis( halfFOV, Vector3.up );
        Vector3 leftRayDirection = leftRayRotation * transform.forward;
        Vector3 rightRayDirection = rightRayRotation * transform.forward;
        Gizmos.DrawRay( transform.position, leftRayDirection * viewRadius );
        Gizmos.DrawRay( transform.position, rightRayDirection * viewRadius );
        
    }
}
