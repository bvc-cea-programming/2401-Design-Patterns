using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterHealthBarView : MonoBehaviour
{
    [SerializeField] private CharacterDataController characterDataController;
    [Header("UI")]
    [SerializeField] private Image playerHPBar;

    private void OnEnable()
    {
        characterDataController.OnHealthUpdated += UpdateHealthBar;
    }
    private void OnDisable()
    {
        characterDataController.OnHealthUpdated -= UpdateHealthBar;
    }
    private void UpdateHealthBar(float value)
    {
        playerHPBar.fillAmount = value / characterDataController.data.MaxHealth;
    }
}
