using UnityEngine;

namespace ByteClub.MayorOffice.Environment
{
    public class Chair : MonoBehaviour, IInteractable
    {
        public void Interact()
        {
            Debug.Log("Character sits down.");
        }
    }
}
