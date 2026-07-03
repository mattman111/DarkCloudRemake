using UnityEngine;

namespace ByteClub.MayorOffice.Environment
{
    public class Chest : MonoBehaviour, IInteractable
    {
        public void Interact()
        {
            Debug.Log("Player interacts with chest.");
        }
    }
}
