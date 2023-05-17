using UnityEngine;

public class SuperManPunch : MonoBehaviour
{
    [SerializeField] private float _speed = 0.6f;
    [SerializeField] private float _punchPower = 10;

    private void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, transform.position + Vector3.forward, _speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.layer == LayerMask.NameToLayer("BadBoy"))
        {
            collision.rigidbody.AddForce(collision.transform.forward * _punchPower, ForceMode.Impulse);
        }
    }
}
