using UnityEngine;
using ByteClub.MayorOffice.Players;

namespace ByteClub.MayorOffice.Environment
{
    public class Door : MonoBehaviour, IInteractable
    {
        public void Interact(Player player)
        {
            Debug.Log("Door opens/closes.");
        }

        public void OnPlayerEntered(Player player)
        {
            Debug.Log("Player entered area.");
        }

        public void OnPlayerExited(Player player)
        {
            Debug.Log("Player exited area.");
        }
    }
}
