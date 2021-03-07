using Player;
using UnityEngine;

[RequireComponent(typeof(Movement))]
public class RestrictXPosition : MonoBehaviour
{
    [SerializeField] private float maxX = 8f;

    private Movement _movement;

    private void Awake()
    {
        _movement = GetComponent<Movement>();
    }

    private void Update()
    {
        ClampPosition();

        // ReSharper disable once CompareOfFloatsByEqualityOperator
        if (Mathf.Abs(transform.position.x) == maxX)
        {
            _movement.ResetVelocity();
        }
    }

    private void ClampPosition()
    {
        var transformPosition = transform.position;

        transformPosition.x = Mathf.Clamp(transformPosition.x, -maxX, maxX);

        transform.position = transformPosition;
    }
}
