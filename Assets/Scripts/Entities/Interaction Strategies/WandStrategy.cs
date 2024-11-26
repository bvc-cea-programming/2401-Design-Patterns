using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class WandStrategy : InteractStrategy
{
    [SerializeField] private GameObject wandObject;
    private IInteractable _wandInteractable;

    public override void SetInteractable(IInteractable interactable)
    {
        _wandInteractable = interactable;
    }
    
    public override void EnableStrategy()
    {
        wandObject.SetActive(true);
        Debug.Log("Using the wand");
    }

    public override void ExecuteStrategy()
    {
        if (_wandInteractable is SpikeTrap)
        {
            _wandInteractable.Interact();
        }
        else
        {
            Debug.Log("I can't use a wand to do this interaction!!!");
        }
    }

    public override void DisableStrategy()
    {
        _wandInteractable = null;
        wandObject.SetActive(false);
    }
}
