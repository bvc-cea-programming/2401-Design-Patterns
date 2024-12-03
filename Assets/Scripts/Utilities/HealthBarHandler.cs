using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarHandler : MonoBehaviour
{
    [SerializeField] private CharacterDataController characterDataController;

    [Header("UI elements")]
    [SerializeField] private Image healthBarImage;

    private void OnEnable()
    {
        characterDataController.onHealthUpdated += UpdateHealthBar;
    }

    private void OnDisable()
    {
        characterDataController.onHealthUpdated -= UpdateHealthBar;
    }

    private void UpdateHealthBar(float value)
    {
        healthBarImage.fillAmount = value / 100;
    }
}
