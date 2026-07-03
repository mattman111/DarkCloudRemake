using ByteClub.MayorOffice.Player;
using UnityEngine;

namespace ByteClub.MayorOffice
{
    [RequireComponent(typeof(PlayerInputHandler))]
    [RequireComponent(typeof(EnvironmentInteractor))]
    public class PlayerInteraction : MonoBehaviour
    {
        private PlayerInputHandler _input;
        private EnvironmentInteractor _interactor;

        private void Awake()
        {
            _input = GetComponent<PlayerInputHandler>();
            _interactor = GetComponent<EnvironmentInteractor>();
        }

        private void OnEnable()
        {
            _input.Interact += OnInteract;
        }

        private void OnDisable()
        {
            _input.Interact -= OnInteract;
        }

        private void OnInteract()
        {
            _interactor.Interact();
        }
    }
}
