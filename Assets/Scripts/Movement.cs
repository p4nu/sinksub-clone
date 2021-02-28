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
        transform.Translate(_playerInput.Horizontal * speed * Time.fixedDeltaTime * Vector3.right);
    }
}
