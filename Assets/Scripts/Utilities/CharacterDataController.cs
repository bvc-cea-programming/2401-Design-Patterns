using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDataController : MonoBehaviour
{
    [SerializeField]
    private CharacterData data;

    public event Action<float> onHealthUpdated;

    public void AppendHealth(float value)
    {
        data.health += value;
        onHealthUpdated?.Invoke(data.health);
    }
}
