using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterHealthBarView : MonoBehaviour
{
    [SerializeField] private CharacterDataController characterDataController;

    [Header("UI Elements")]
    [SerializeField] private Slider playerHealthBar;

    private void OnEnable()
    {
        characterDataController.onHealthBarUpdated += UpdateHealthBar;
    }

    private void OnDisable()
    {
        characterDataController.onHealthBarUpdated -= UpdateHealthBar;
    }

    private void UpdateHealthBar(float health, float maxHealth)
    {
        playerHealthBar.value = health / maxHealth;
    }
}
