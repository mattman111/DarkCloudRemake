using UnityEngine;

namespace ByteClub.MayorOffice.NPC
{
    public class NpcInteractionTrigger : MonoBehaviour
    {
        private InteractableNpc _npc;

        private void Awake()
        {
            _npc = GetComponentInParent<InteractableNpc>();
        }

        private void OnTriggerEnter(Collider other)
        {
            _npc.PlayerEntered(other);
        }

        private void OnTriggerExit(Collider other)
        {
            _npc.PlayerExited(other);
        }
    }
}
