using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAlertVisualizer : MonoBehaviour
{
    [SerializeField] private GameObject alertEffectObject;
    [SerializeField] private float alertTime;

    public float AlertTime => alertTime;

    private Transform _mainCamera;

    private void Start()
    {
        alertEffectObject.SetActive(false);
        _mainCamera = Camera.main.transform;
    }

    public void ShowAlert()
    {
        alertEffectObject.SetActive(true);
        alertEffectObject.transform.forward = _mainCamera.forward; //Make the object look at the camera
        Invoke(nameof(HideInCallstackAttribute), alertTime);
    }

    private void HideAlert()
    {
        alertEffectObject.SetActive(false);
    }
}
