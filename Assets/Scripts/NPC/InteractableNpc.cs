using UnityEngine;
using ByteClub.MayorOffice.Players;

namespace ByteClub.MayorOffice.NPC
{
    public class InteractableNpc : MonoBehaviour, IInteractable
    {
        [SerializeField] private Canvas _popUpNotification;
        [field: SerializeField] public string Name { get; private set; }

        private void Awake()
        {
            _popUpNotification.enabled = false;
        }

        public void Interact()
        {
            Debug.Log($"Player interacted with {Name}.");
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent<Player>(out _))
            {
                SetNotificationVisible(true);
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.TryGetComponent<Player>(out _))
            {
                SetNotificationVisible(false);
            }
        }

        private void SetNotificationVisible(bool visible)
        {
            if (_popUpNotification.enabled == visible)
            {
                return;
            }

            _popUpNotification.enabled = visible;
        }
    }
}
