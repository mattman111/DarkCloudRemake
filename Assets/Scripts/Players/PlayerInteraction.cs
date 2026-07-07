using UnityEngine;

namespace ByteClub.MayorOffice.Players
{
    [RequireComponent(typeof(PlayerInputHandler))]
    public class PlayerInteraction : MonoBehaviour
    {
        private PlayerInputHandler _input;
        private PlayerInteractionTrigger _interactor;

        private void Awake()
        {
            _input = GetComponent<PlayerInputHandler>();
            _interactor = GetComponentInChildren<PlayerInteractionTrigger>();
        }

        private void Update()
        {
            if (_input.InteractPressedThisFrame)
            {
                _interactor?.Interact();
            }
        }
    }
}
