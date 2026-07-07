using ByteClub.MayorOffice.UI.InteractIcon;
using UnityEngine;

namespace ByteClub.MayorOffice.Players
{
    public class PlayerInteractionTrigger : MonoBehaviour
    {
        [SerializeField] private IconController _icon;

        private Player _player;
        private IInteractable _currentInteractable;

        private void Awake()
        {
            _player = GetComponentInParent<Player>();
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out IInteractable interactable))
            {
                Debug.Log($"TRIGGER ENTERED: {other.name}");
                _currentInteractable = interactable;
                _icon.EnableIcon();
            }
        }

        private void OnTriggerExit(Collider other)
        {
            IInteractable interactable = other.GetComponent<IInteractable>();

            if (interactable == _currentInteractable)
            {
                _currentInteractable = null;
                _icon.DisableIcon();
            }
        }

        public void Interact()
        {
            if (_currentInteractable != null)
            {
                _currentInteractable.Interact(_player);
                _icon.DisableIcon();
            }
        }
    }
}
