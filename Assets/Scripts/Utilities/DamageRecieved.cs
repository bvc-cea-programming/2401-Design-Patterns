using UnityEngine;

public class DamageRecieved : MonoBehaviour
{
  private CharacterDataController _dateController;

  private void Awake()
  {
    _dateController = GetComponent<CharacterDataController>();
  }

  private void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag("Damagable"))
    {
      _dateController.AppendHealth(-5);
    }
  }
}
