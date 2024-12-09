using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterHealthBarView : MonoBehaviour
{
    [SerializeField] private CharacterDataController _CharacterDataController;

    [Header("UI Elements")]
    [SerializeField] private Image HPBar;

    private void OnEnable()
    {
        _CharacterDataController.onHealthUpdated += UpdateHealthText;
    }

    private void OnDisable()
    {
        _CharacterDataController.onHealthUpdated -= UpdateHealthText;
    }

    private void UpdateHealthText(float value, float maxValue)
    {
        HPBar.fillAmount = Mathf.Clamp(value / maxValue, 0, 1);
    }
}
