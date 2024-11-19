using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAlertVisualizer : MonoBehaviour
{
    [SerializeField] private GameObject alertEffectObject;
    [SerializeField] private float alertTime=1.5f;

    public float AlertTime => alertTime;
    
    private Transform _mainCamera;
    
    void Start()
    {
        alertEffectObject.SetActive(false);
        _mainCamera = Camera.main.transform;
    }

    public void ShowAlert()
    {
        alertEffectObject.SetActive(true);
        alertEffectObject.transform.forward = _mainCamera.forward; // make the object look at the camera
        Invoke(nameof(HideAlert), alertTime);
    }

    private void HideAlert()
    {
        alertEffectObject.SetActive(false);
    }
}
