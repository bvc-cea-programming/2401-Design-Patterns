using System;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterDataController : MonoBehaviour
{
    [SerializeField] private CharacterData _data;

    public event Action<float> onHealthUpdated;
    public void AppendHealth(float value)
    {
        _data.health += value;
        
        onHealthUpdated?.Invoke( _data.health);
    }
}
