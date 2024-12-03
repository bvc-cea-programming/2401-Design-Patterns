using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UI;

public class CharacterHealthBar : MonoBehaviour
{
    [SerializeField] private CharacterDataController characterDataController;
    [SerializeField] private Image _healthBar;
    [SerializeField] private CharacterData _characterData;

    private void Awake()
    {  
        _healthBar.fillAmount = _characterData.MaxHealth;
    }

    private void OnEnable()
    {
        characterDataController.OnHealthUpdate += UpdateHealthBar;
    }

    private void OnDisable()
    {
        characterDataController.OnHealthUpdate -= UpdateHealthBar;
    }

    private void UpdateHealthBar(float value)
    {
        _healthBar.fillAmount = value / _characterData.MaxHealth;
    }


}
