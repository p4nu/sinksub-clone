using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(PlayerMovement))]
    public class RestrictXPosition : MonoBehaviour
    {
        [SerializeField] private float maxX = 8f;

        private PlayerMovement _playerMovement;

        private void Awake()
        {
            _playerMovement = GetComponent<PlayerMovement>();
        }

        private void Update()
        {
            ClampPosition();

            // ReSharper disable once CompareOfFloatsByEqualityOperator
            if (Mathf.Abs(transform.position.x) == maxX)
            {
                _playerMovement.ResetVelocity();
            }
        }

        private void ClampPosition()
        {
            var transformPosition = transform.position;

            transformPosition.x = Mathf.Clamp(transformPosition.x, -maxX, maxX);

            transform.position = transformPosition;
        }
    }
}
