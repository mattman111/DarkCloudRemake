using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ByteClub.MayorOffice.Player
{
    public class PlayerInputHandler : MonoBehaviour
    {
        private GameInput _input;

        public event Action<Vector2> Move;
        public event Action Interact;

        private void Awake()
        {
            _input = new GameInput();
        }

        private void OnEnable()
        {
            _input.Enable();

            _input.Player.Move.performed += OnMove;
            _input.Player.Move.canceled += OnMove;

            _input.Player.Interact.performed += OnInteract;
            _input.Player.Interact.canceled += OnInteract;
        }

        private void OnDisable()
        {
            _input.Player.Move.performed -= OnMove;
            _input.Player.Move.canceled -= OnMove;

            _input.Player.Interact.performed -= OnInteract;
            _input.Player.Interact.canceled -= OnInteract;

            _input.Disable();
        }

        private void OnMove(InputAction.CallbackContext context)
        {
            Move?.Invoke(context.ReadValue<Vector2>());
        }

        private void OnInteract(InputAction.CallbackContext context)
        {
            Interact?.Invoke();
        }
    }
}
