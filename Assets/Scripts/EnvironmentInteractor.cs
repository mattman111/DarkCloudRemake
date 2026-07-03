using Unity.VisualScripting;
using UnityEngine;

namespace ByteClub.MayorOffice
{
    public class EnvironmentInteractor : MonoBehaviour
    {
        [SerializeField] private Collider _collider;
        private IInteractable _interactable;

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out IInteractable interactable))
            {
                _interactable = interactable;
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.TryGetComponent(out IInteractable interactable))
            {
                _interactable = null;
            }
        }

        public void Interact()
        {
            if (_interactable != null)
            {
                _interactable.Interact();
            }
        }
    }
}
