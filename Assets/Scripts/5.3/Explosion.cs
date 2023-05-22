using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] private float _force = 500;
    [SerializeField] private float _radius = 10;

    private void Awake()
    {
        Explode();
    }

    private void Explode()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, _radius);

        foreach(var collider in colliders)
        {
            Rigidbody rigidbody = collider.GetComponent<Rigidbody>();
            if (rigidbody)
            {
                rigidbody.AddExplosionForce(_force, transform.position, _radius);
            }
        }
    }
}
