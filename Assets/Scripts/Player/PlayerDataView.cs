using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerDataView : MonoBehaviour
{
    [SerializeField] private CharacterDataController _CharacterDataController;

    [Header("UI Elements")]
    [SerializeField] private TMP_Text txtPlayerHealth;

    private void OnEnable()
    {
        _CharacterDataController.onHealthUpdated += UpdateHealthText;
    }

    private void OnDisable()
    {
        _CharacterDataController.onHealthUpdated -= UpdateHealthText;
    }

    private void UpdateHealthText(float value)
    {
        txtPlayerHealth.SetText("Health: " + value);
    }
}
