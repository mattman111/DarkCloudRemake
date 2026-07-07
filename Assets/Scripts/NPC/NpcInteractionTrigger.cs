using System;
using UnityEngine;
using ByteClub.MayorOffice.Players;

namespace ByteClub.MayorOffice.NPC
{
    public class NpcInteractionTrigger : MonoBehaviour
    {
        public event Action<Player> OnPlayerEntered;
        public event Action<Player> OnPlayerExited;

        private void OnTriggerEnter(Collider otherColliding)
        {
            Player player = otherColliding.GetComponent<Player>() ?? otherColliding.GetComponentInParent<Player>();
            if (player != null)
            {
                OnPlayerEntered?.Invoke(player);
            }
        }

        private void OnTriggerExit(Collider otherColliding)
        {
            Player player = otherColliding.GetComponent<Player>() ?? otherColliding.GetComponentInParent<Player>();
            if (player != null)
            {
                OnPlayerExited?.Invoke(player);
            }
        }
    }
}
