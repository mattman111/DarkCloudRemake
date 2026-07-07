using UnityEngine;


namespace ByteClub.MayorOffice.UI.InteractIcon
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class IconController : MonoBehaviour
    {
        private SpriteRenderer _spriteRenderer;
        [SerializeField] private bool _startDisabled;

        private void Awake()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
        }

        private void OnEnable()
        {
            if (_startDisabled)
            {
                DisableIcon();
            }
        }

        public void DisableIcon()
        {
           _spriteRenderer.enabled = false;
        }

        public void EnableIcon()
        {
            _spriteRenderer.enabled = true;
        }
    }
}
