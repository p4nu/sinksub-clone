using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    internal float Horizontal;

    private void Update()
    {
        Horizontal = Input.GetAxis("Horizontal");
    }
}
