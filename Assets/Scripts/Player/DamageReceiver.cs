using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageReceiver : MonoBehaviour
{
    private CharacterDataController _dataController;

    void Awake()
    {
        _dataController = GetComponent<CharacterDataController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Damageable"))
        {
            _dataController.AppendHealth(-5);
        }
    }
}