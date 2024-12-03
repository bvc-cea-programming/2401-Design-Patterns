using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerDataView : MonoBehaviour
{
    [SerializeField] private CharacterDataController characterDataController;

    [Header("UI elements")]
    [SerializeField] private TMP_Text txtPlayerHealth;

    private void OnEnable()
    {
        characterDataController.onHealthUpdated += UpdateHealthText;
    }

    private void OnDisable()
    {
        characterDataController.onHealthUpdated -= UpdateHealthText;
    }

    private void UpdateHealthText(float value)
    {
        txtPlayerHealth.SetText("Health: " + value);
    }
}
