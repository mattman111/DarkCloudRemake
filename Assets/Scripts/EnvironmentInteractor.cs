using System;
using UnityEngine;

namespace ByteClub.MayorOffice
{
    public class EnvironmentInteractor : MonoBehaviour
    {
        [SerializeField] private Collider _collider;

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out IInteractable interactable))
            {
                interactable.Interact();
            }
        }
    }
}
