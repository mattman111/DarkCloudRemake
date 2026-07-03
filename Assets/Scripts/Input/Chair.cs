using UnityEngine;

namespace ByteClub.MayorOffice
{
    public class Chair : MonoBehaviour, IInteractable
    {
        public void Interact()
        {
            Debug.Log("Character sits down.");
        }
    }
}
