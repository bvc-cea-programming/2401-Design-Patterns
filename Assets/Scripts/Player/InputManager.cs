using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    // Player will listen to this
    public event Action<Vector2> onMove;
    public event Action onInteract;
    
    private PlayerInput _playerInput;
    
    private void OnEnable()
    {
        SetupInputs();
    }

    private void OnDisable()
    {
        DisableInputs();
    }

    private void SetupInputs()
    {
        _playerInput = new PlayerInput();
        _playerInput.Player.Move.performed += OnMove;
        _playerInput.Player.Interact.performed += OnInteract;
        _playerInput.Enable();
    }

    private void DisableInputs()
    {
        if(_playerInput == null) return;
        
        _playerInput.Player.Move.performed -= OnMove;
        _playerInput.Player.Interact.performed -= OnInteract;
        _playerInput.Disable();
        _playerInput = null;
    }

    private void OnMove(InputAction.CallbackContext context)
    {
        onMove?.Invoke(context.ReadValue<Vector2>());
    }

    private void OnInteract(InputAction.CallbackContext context)
    {
        onInteract?.Invoke();
    }
}
