using ByteClub.MayorOffice.Players;

namespace ByteClub.MayorOffice
{
    public interface IInteractable
    {
        public void OnPlayerEntered(Player player);
        public void OnPlayerExited(Player player);
        public void Interact(Player player);
    }
}
