using System;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class CharacterDataController : MonoBehaviour
{
    [SerializeField] private CharacterData data;
    public float maxHealth =100f;

    //event
    public event Action<float> OnHealthUpdated;
    //event for hpbar
    public event Action<float, float> OnHealthBarChanged;
   
    public void SetMaxHealth(float value)
    {
        value = maxHealth;
    }
    public void AppendHealth(float value)
    {
        data.health += value;
        SetMaxHealth(100);
        OnHealthUpdated?.Invoke(data.health);
        OnHealthBarChanged?.Invoke(data.health, data.maxHealth);
    }
}
