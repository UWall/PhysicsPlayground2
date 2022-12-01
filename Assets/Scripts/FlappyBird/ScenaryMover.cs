using UnityEngine;

public class ScenaryMover : MonoBehaviour
{
    [SerializeField]private float speed, lifetime;
    private void Start()
    {
        Invoke("Die", lifetime);
    }

    private void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.fixedDeltaTime;
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
