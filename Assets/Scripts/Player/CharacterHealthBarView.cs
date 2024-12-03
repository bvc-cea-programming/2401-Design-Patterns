using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterHealthBarView : MonoBehaviour
{
    [SerializeField] private CharacterDataController _characterDataController;

    [Header("UI health bar")]
    [SerializeField] private Image healthBar;



    private void OnEnable()
    {
        _characterDataController.OnHealthBarChanged += UpdateHealthBar;

    }
    private void OnDisable()
    {
        _characterDataController.OnHealthBarChanged -= UpdateHealthBar;
    }
    private void UpdateHealthBar(float cur,float max)
    {
        healthBar.fillAmount = cur /max ;
    }
}
