using UnityEngine;
using ByteClub.MayorOffice.Players;

namespace ByteClub.MayorOffice.NPC
{
    public class InteractableNpc : MonoBehaviour, IInteractable
    {
        [SerializeField] private Canvas _popUpNotification;
        [field: SerializeField] public string Name { get; private set; }

        private NpcInteractionTrigger _interactionTrigger;

        private void Awake()
        {
            _popUpNotification.enabled = false;
            _interactionTrigger = GetComponentInChildren<NpcInteractionTrigger>();
        }

        public void Interact(Player player)
        {
            Debug.Log($"Player interacted with {Name}.");
        }

        public void OnPlayerEntered(Player player) => HandlePlayerEntered(player);
        public void OnPlayerExited(Player player) => HandlePlayerExited(player);

        private void HandlePlayerEntered(Player player)
        {
            SetNotificationVisible(true);
        }
        private void HandlePlayerExited(Player player)
        {
            SetNotificationVisible(false);
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
