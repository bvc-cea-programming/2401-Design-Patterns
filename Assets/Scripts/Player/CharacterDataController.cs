using System;
using UnityEngine;

public class CharacterDataController : MonoBehaviour
{
    [SerializeField] private CharacterData data;

    private void Awake()
    {
        data.health = data.maxHealth;
    }

    //events that can be listened
    public event Action<float> onHealthUpdated;
    public event Action<float, float> onHealthBarUpdated;

    public void AppendHealth(float health)
    {
        data.health += health;
        onHealthUpdated?.Invoke(data.health);
        onHealthBarUpdated?.Invoke(data.health, data.maxHealth);
    }
}
