using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour
{
    [SerializeField] private InputManager inputManager;
    
    // The interaction strategy abstraction
    private InteractStrategy _interactionStrategy;
    
    private IInteractable _currentInteractable;

    private void OnEnable()
    {
        inputManager.onInteract += Interact;
    }

    private void OnDisable()
    {
        inputManager.onInteract -= Interact;
    }

    private void OnTriggerEnter(Collider other)
    {
        _currentInteractable = other.GetComponent<IInteractable>();
        if(_interactionStrategy != null)
            _interactionStrategy.SetInteractable(_currentInteractable);
    }

    private void OnTriggerExit(Collider other)
    {
        _currentInteractable = null;
    }
    
    private void Interact()
    {
        //_currentInteractable?.Interact();
        // Use the interaction strategy to interact instead of directly doing it
        if (_interactionStrategy != null)
        {
            _interactionStrategy.SetInteractable(_currentInteractable);
            _interactionStrategy.ExecuteStrategy();
        }
            
    }

    public void SetInteractionStrategy(InteractStrategy strategy)
    {
        // if we already have a strategy selected, we disable it. The "?" checks if the object is null or not.
        _interactionStrategy?.DisableStrategy(); 
        // we choose the new strategy
        _interactionStrategy = strategy;
        // we enable the new strategy
        _interactionStrategy.EnableStrategy();
        _interactionStrategy.SetInteractable(_currentInteractable);
    }
}
