using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDataController : MonoBehaviour
{
    [SerializeField] private CharacterData data;

    // Events that can be listened
    public event Action<float> onHealthUpdated;

    private void Start()
    {
        // Reset health to 100
        data.health = 100;
        onHealthUpdated?.Invoke(data.health);
    }

    public void AppendHealth(float value)
    {
        data.health += value;
        onHealthUpdated?.Invoke(data.health);
    }
}
