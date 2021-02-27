using UnityEngine;

public class RestrictXPosition : MonoBehaviour
{
    [SerializeField] private float maxX = 8f;
    
    private void Update()
    {
        var transformPosition = transform.position;

        transformPosition.x = Mathf.Clamp(transformPosition.x, -maxX, maxX);

        transform.position = transformPosition;
    }
}
