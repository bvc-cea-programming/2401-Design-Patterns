using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CharacterHealthBarView : MonoBehaviour
{
    [SerializeField] private CharacterData _characterData;

    [SerializeField] private Image _image;

    private float _target;

    void Start()
    {
        _image = GetComponent<Image>();
        _characterData.health = _characterData.maxHealth;
    }

    void Update()
    {
        // Update the target based on the player's health value
        _target = _characterData.GetHealth() / _characterData.GetMaxHealth();

        // Update the fill amount of the Health bar
        _image.fillAmount = Mathf.Lerp(_image.fillAmount, _target, Time.deltaTime); // Lerp the value smoothly over time
    }
}
