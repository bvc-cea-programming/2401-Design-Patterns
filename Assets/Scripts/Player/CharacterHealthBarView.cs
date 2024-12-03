using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterHealthBarView : MonoBehaviour
{
    [SerializeField] private CharacterDataController _characterDataController;

    [Header("UI Elements")]
    [SerializeField] private Image HealthBar;

    private void OnEnable()
    {
        _characterDataController.onHealthUpdated += UpdateHealthText;

    }

    private void OnDisable()
    {
        _characterDataController.onHealthUpdated -= UpdateHealthText;
    }

    private void UpdateHealthText(float value)
    {
        HealthBar.fillAmount = value / 100;
    }
}
