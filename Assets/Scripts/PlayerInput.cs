using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    internal float Horizontal;

    private void Update()
    {
        UpdateHorizontalInput();
    }

    private void UpdateHorizontalInput()
    {
        Horizontal = Input.GetAxis("Horizontal");
    }
}
