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
        Debug.Log(other.name);
        if (other.CompareTag("damageable"))
        {
            _dataController.AppendHealth(-5f);
        }
    }
}
