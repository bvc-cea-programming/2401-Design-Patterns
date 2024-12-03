using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterHealthBarView : MonoBehaviour
{
    [SerializeField] private CharacterData _data;
    private float maxHP;
    [SerializeField] private Image HPBar;

    // Start is called before the first frame update
    void Start()
    {
        maxHP = _data.health;
    }

    // Update is called once per frame
    void Update()
    {
        HPBar.fillAmount = Mathf.Clamp(_data.health / maxHP, 0, 1);
    }
}
