using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterData", menuName = "Character Data")]

public class CharacterData : ScriptableObject
{
    [SerializeField] public float maxHealth = 100f;
    [SerializeField] public float health;

    public float GetHealth() => health;
    public float GetMaxHealth() => maxHealth;
}
