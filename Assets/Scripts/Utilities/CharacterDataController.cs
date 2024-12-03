using System;
using UnityEngine;

public class CharacterDataController : MonoBehaviour
{
    [SerializeField] private CharacterData _data;

    //events that can be listenend
    public event Action<float> OnHealthUpdate; 
    public void AppendHealth(float value)
    {
        _data.Health += value;
        Debug.Log("Health is:" +  _data.Health);
        OnHealthUpdate?.Invoke(_data.Health);   
    }


}
