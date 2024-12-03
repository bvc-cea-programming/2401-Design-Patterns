using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageReciever : MonoBehaviour
{
    private CharacterDataController dataController;
    // Start is called before the first frame update
    void Awake()
    {
        dataController = GetComponent<CharacterDataController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "damagable")
        {
            dataController.AppendHealth(-5);
        }
    }
}
