using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractStrategy : MonoBehaviour, IStrategy
{
    public abstract void SetInteractable(IInteractable interactable);
    public abstract void EnableStrategy();
    public abstract void ExecuteStrategy();
    public abstract void DisableStrategy();

}
