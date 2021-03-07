using UnityEngine;
using Random = UnityEngine.Random;

namespace Enemy
{
    public class EnemyMovement : MonoBehaviour
    {
        [SerializeField] private float minSpeed = 0.2f;
        [SerializeField] private float maxSpeed = 1f;

        private float _speed;

        private void Start()
        {
            _speed = Random.Range(minSpeed, maxSpeed);
        }

        private void FixedUpdate()
        {
            transform.Translate(_speed * Time.fixedDeltaTime * Vector2.right);
        }
    }
}
