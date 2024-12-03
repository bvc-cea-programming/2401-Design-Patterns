using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerDataView : MonoBehaviour
{
    [SerializeField] private CharacterDataController characterDataController;
    [Header("UI")]
    [SerializeField] private TMP_Text playerHP;

    private void OnEnable()
    {
        characterDataController.OnHealthUpdated += UpdateHealthText;
    }
    private void OnDisable()
    {
        characterDataController.OnHealthUpdated -= UpdateHealthText;
    }
    private void UpdateHealthText(float value)
    {
        playerHP.text = value.ToString();
    }
}
