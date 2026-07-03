using UnityEngine;

namespace ByteClub.MayorOffice.Environment
{
    public class Door : MonoBehaviour, IInteractable
    {
        public void Interact()
        {
            Debug.Log("Door opens/closes.");
        }
    }
}
