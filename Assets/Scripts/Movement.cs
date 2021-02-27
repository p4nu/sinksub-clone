using UnityEngine;

[RequireComponent(typeof(PlayerInput))]
public class Movement : MonoBehaviour
{
    [SerializeField] private float speed = 1f;

    private PlayerInput _playerInput;

    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
    }

    private void FixedUpdate()
    {
        transform.Translate(new Vector2(_playerInput.Horizontal * speed, 0));
    }
}
