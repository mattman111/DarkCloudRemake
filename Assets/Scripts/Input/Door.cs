using UnityEngine;

namespace ByteClub.MayorOffice
{
    public class Door : MonoBehaviour, IInteractable
    {
        public void Interact()
        {
            Debug.Log("Door opens/closes.");
        }
    }
}
