using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDataController : MonoBehaviour
{
    [SerializeField] private CharacterData data;

    public event Action<float, float> onHealthUpdated;

    private void Start()
    {
        data.health = data.maxHealth;
        onHealthUpdated?.Invoke(data.health, data.maxHealth);
    }

    public void AppendHealth(float value)
    {
        data.health += value;
        if (data.health > data.maxHealth)
        {
            data.health = data.maxHealth;
        }
        onHealthUpdated?.Invoke(data.health, data.maxHealth);
    }
}
