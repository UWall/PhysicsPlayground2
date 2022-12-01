using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float thrustForce;
    [SerializeField] private KeyCode jumpKey;
    private Rigidbody rb;
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }
    
    private void Update()
    {
        if (Input.GetKeyDown(jumpKey) == true)
        {
            rb.velocity = Vector3.zero;
            rb.AddRelativeForce(Vector3.up * thrustForce * Time.fixedDeltaTime, ForceMode.Impulse);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Pipe") == true)
        {
            GameManager.instance.Reset();
        }
    }

    private void OnTriggerExit()
    {
        GameManager.instance.GainPoints();
    }
}
