using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterHealthBarView : MonoBehaviour
{
    [SerializeField] private CharacterDataController _characterDataController;

    [Header("UI Elements")]
    [SerializeField] private Image hpBar;
    private float maxHealth;

    private void OnEnable()
    {
        _characterDataController.onHealthUpdated += UpdateHealth;
    }

    private void OnDisable()
    {
        _characterDataController.onHealthUpdated -= UpdateHealth;
    }

    private void Start()
    {
        maxHealth = _characterDataController.GetMaxHealth();   
    }

    private void UpdateHealth(float value)
    {
        if (value >= 0 && value <= maxHealth)
        {
            hpBar.fillAmount = value / maxHealth;
        }
        else if (value < 0)
        {
            hpBar.fillAmount = 0;
        }
        else if (value > maxHealth)
        {
            hpBar.fillAmount = 1;
        }
    }
}
