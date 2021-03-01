using UnityEngine;

[RequireComponent(typeof(PlayerInput))]
[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
    [SerializeField] private float force = 100f;

    private PlayerInput _playerInput;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        UpdatePosition();
    }

    private void UpdatePosition()
    {
        _rigidbody.AddForce(new Vector2(_playerInput.Horizontal * _rigidbody.mass * force * Time.fixedDeltaTime, 0));
    }

    internal void ResetVelocity()
    {
        _rigidbody.velocity = Vector2.zero;
    }
}
