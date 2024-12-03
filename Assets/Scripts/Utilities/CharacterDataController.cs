using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDataController : MonoBehaviour
{
    [SerializeField] private CharacterData data;

    //event
    public event Action<float> OnHealthUpdated;
    public void AppendHealth(float value)
    {
        data.health += value;
        OnHealthUpdated?.Invoke(data.health);
    }
}
