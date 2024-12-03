using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageReceived : MonoBehaviour
{
    private CharacterDataController _dataController;
    
    void Awake()
    {
        _dataController = GetComponent<CharacterDataController>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("damagable"))
        {
            _dataController.AppendHealth(-5);
        }
    }
}
