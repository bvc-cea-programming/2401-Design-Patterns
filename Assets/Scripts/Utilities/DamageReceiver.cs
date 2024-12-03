using UnityEngine;

public class DamageReceiver : MonoBehaviour
{
    private CharacterDataController _dataController;
    private void Awake()
    {
        _dataController = GetComponent<CharacterDataController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("damageable"))
        {
            _dataController.AppendHealth(-5);

        }
    }
}
