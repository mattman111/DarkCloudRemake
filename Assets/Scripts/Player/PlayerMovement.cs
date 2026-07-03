using UnityEngine;

namespace ByteClub.MayorOffice.Player
{
    [RequireComponent(typeof(PlayerInputHandler))]
    public class PlayerMovement : MonoBehaviour
    {
        private const float DownwardForce = -2f;
        [SerializeField] private float _playerMoveSpeed;

        private PlayerInputHandler _input;
        private CharacterController _characterController;

        private Vector2 _moveInput;

        private void Awake()
        {
            _input = GetComponent<PlayerInputHandler>();
            _characterController = GetComponent<CharacterController>();
        }

        private void OnEnable()
        {
            _input.Move += OnMove;
        }

        private void OnDisable()
        {
            _input.Move -= OnMove;
        }

        private void OnMove(Vector2 direction)
        {
            _moveInput = direction;
        }

        private void Update()
        {
            Vector3 move = new Vector3(_moveInput.x, 0f, _moveInput.y) * _playerMoveSpeed;
            move.y = DownwardForce;

            _characterController.Move(move * Time.deltaTime);
        }
    }
}
