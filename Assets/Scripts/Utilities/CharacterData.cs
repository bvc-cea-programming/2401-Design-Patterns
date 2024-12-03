using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
[CreateAssetMenu(fileName = "CharacterData", menuName = "SOs/CharacterData")]
public class CharacterData : ScriptableObject
{
    public float Health;
    public float MaxHealth;
}
