using UnityEngine;

namespace Enemy
{
    public class EnemyMovement : MonoBehaviour
    {
        [SerializeField] private float speed = 5f;

        private void FixedUpdate()
        {
            transform.Translate(speed * Time.fixedDeltaTime * Vector2.right);
        }
    }
}
