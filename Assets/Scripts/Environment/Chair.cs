using ByteClub.MayorOffice.Players;
using UnityEngine;

namespace ByteClub.MayorOffice.Environment
{
    public class Chair : MonoBehaviour, IInteractable
    {
        public void Interact(Player player)
        {
            Debug.Log("Character sits down.");
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
