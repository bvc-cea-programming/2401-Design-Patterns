using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerDataViewer : MonoBehaviour
{
    
 [SerializeField] private CharacterDataController characterDataController;
 [Header("Player Data")]
 [SerializeField] private TMP_Text playerHealth;

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
     playerHealth.SetText("Health = "+value);
 }
}
