using TMPro;
using UnityEngine;

public class PlayerDataview : MonoBehaviour
{
    [SerializeField] private CharacterDataController characterDataController;


    [Header("UI Element")]
    [SerializeField] private TMP_Text txtplayerHealth;

    private void OnEnable()
    {
        characterDataController.OnHealthUpdate += UpdateHealthText;
    }

    private void OnDisable()
    {
        characterDataController.OnHealthUpdate -= UpdateHealthText;
    }

    private void UpdateHealthText(float value)
    {
        txtplayerHealth.SetText("health: " + value);
    }
}
