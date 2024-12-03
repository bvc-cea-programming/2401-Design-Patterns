using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerDataView : MonoBehaviour
{
    [SerializeField] private CharacterDataController _characterDataController;

    [Header("UI Elements")]
    [SerializeField] private TMP_Text txtPlayerHealth;

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
        txtPlayerHealth.SetText("Health: " + value); 
    }
}
