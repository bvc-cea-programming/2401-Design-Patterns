using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CharacterDataController : MonoBehaviour
{
    [SerializeField] private CharacterData data;
    public event Action<float> OnHealthUpdated;
    public void AppendHealth(float value)
    {
        data.Health += value;
        OnHealthUpdated?.Invoke(data.Health);
    }

}
