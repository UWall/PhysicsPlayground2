using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]private float speed;

    private void Update()
    {
        PlayerMove();
    }

    private void PlayerMove()
    {
        Vector3 dir = Vector3.zero;
        if(Input.GetKey(KeyCode.W))
        {
            dir = Vector3.forward;
        }
        if(Input.GetKey(KeyCode.A))
        {
            dir = Vector3.left;
        }
        if(Input.GetKey(KeyCode.S))
        {
            dir = Vector3.back;
        }
        if(Input.GetKey(KeyCode.D))
        {
            dir = Vector3.right;
        }

        transform.position += dir * speed * Time.deltaTime;
    }
}
