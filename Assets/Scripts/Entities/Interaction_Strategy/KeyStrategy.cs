using UnityEngine;

public class KeyStrategy : InteractStrategy
{
    [SerializeField] private GameObject keyObject;
    private IInteractable _keyInteractable;

    public override void SetInteractable(IInteractable interactable)
    {
        _keyInteractable = interactable;
    }

    public override void EnableStrategy()
    {
        keyObject.SetActive(true);
        Debug.Log("Using the key!");
    }

    public override void ExecuteStrategy()
    {
        if (_keyInteractable is Door)
        {
            _keyInteractable.Interact();
        }
        else
        {
            Debug.Log("I cannot use a key to do this interaction!");
        }
    }

    public override void DisableStrategy()
    {
        _keyInteractable = null;
        keyObject.SetActive(false);
    }
}
