using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterHealthBarViewer : MonoBehaviour
{
    [SerializeField] private CharacterDataController characterDataController;
    [SerializeField] CharacterData characterData;
    [Header("Player Data")]
    [SerializeField] private Image playerHealth;

    private void OnEnable()
    {
        characterDataController.onHealthUpdated += UpdatePlayerText;
    }
    private void OnDisable()
    {
        characterDataController.onHealthUpdated -= UpdatePlayerText;
    }
    private void UpdatePlayerText(float value)
    {
        playerHealth.fillAmount = value/characterData.maxHealth;
    }
}
