using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharactereHealthBarView : MonoBehaviour
{
    [SerializeField] private CharacterDataController _characterDataController;

    [Header("UI Elements")]
    [SerializeField] private Image healthBarFill; // The Image component for the health bar fill
    [SerializeField] private float maxHealth = 100f; // Maximum health value

    private void OnEnable()
    {
        _characterDataController.onHealthUpdated += UpdateHealthBar;
    }

    private void OnDisable()
    {
        _characterDataController.onHealthUpdated -= UpdateHealthBar;
    }

    private void Start()
    {
        // Initialize the health bar to full
        healthBarFill.fillAmount = 1f;
    }

    private void UpdateHealthBar(float currentHealth)
    {
        // Update the health bar based on the current health
        healthBarFill.fillAmount = currentHealth / maxHealth;
    }
}