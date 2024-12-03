using UnityEngine;
using TMPro;

public class PlayerDataView : MonoBehaviour
{
    [SerializeField] private CharacterDataController characterDataController;

    [Header("UI Elements")]
    [SerializeField] private TMP_Text txtPlayerHealth;

    private void OnEnable()
    {
        characterDataController.onHealthUpdated += UpdateHealthText;
    }

    private void OnDisable()
    {
        characterDataController.onHealthUpdated -= UpdateHealthText;
    }

    private void UpdateHealthText(float health)
    {
        txtPlayerHealth.SetText("Health : " + health);
    }
}
