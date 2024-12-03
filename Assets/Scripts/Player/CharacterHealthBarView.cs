using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterHealthBarView : MonoBehaviour
{
    [SerializeField] private CharacterDataController characterDataController;
    [SerializeField] private Image healthBarImage;

    private void OnEnable()
    {
        characterDataController.onHealthUpdated += UpdateHealthBar;
    }

    private void OnDisable()
    {
        characterDataController.onHealthUpdated -= UpdateHealthBar;
    }

    private void UpdateHealthBar(float health)
    {
       
        healthBarImage.fillAmount = health / 100f;
    }
}