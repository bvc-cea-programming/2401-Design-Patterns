using UnityEngine;

public class DamageReceived : MonoBehaviour
{
    private CharacterDataController _datacontroller;

    private void Awake()
    {
        _datacontroller = GetComponent<CharacterDataController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("damageable"))
        {
            _datacontroller.AppendHealth(-5);
        }
    }
}
