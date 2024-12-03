using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CharacterDataController : MonoBehaviour
{
    [SerializeField] public CharacterData data;
    public event Action<float> OnHealthUpdated;
    private void Awake()
    {
        data.Health = data.MaxHealth;
    }
    public void AppendHealth(float value)
    {
        data.Health += value;
        OnHealthUpdated?.Invoke(data.Health);
    }

}
