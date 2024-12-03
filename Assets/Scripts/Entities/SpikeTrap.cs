using UnityEngine;

public class SpikeTrap : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        Debug.Log("Spike Disabled!");
    }
}
