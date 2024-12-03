using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDataController : MonoBehaviour
{
    [SerializeField] private CharacterData data;

    //events that can be listened to
    public event Action<float> onHealthUpdated; 

    public void AppendHealth(float value)
    {
        data.health += value;
        onHealthUpdated?.Invoke(data.health);
    }

    private void Start()
    {
        data.health = data.maxHealth;
    }

    public float GetMaxHealth()
    {
        return data.maxHealth;
    }


}
