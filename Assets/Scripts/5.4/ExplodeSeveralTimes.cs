using System.Collections;
using UnityEngine;

public class ExplodeSeveralTimes : MonoBehaviour
{
    [SerializeField] private float _radius;
    [SerializeField] private float _force;
    [SerializeField] private float _secondsToWait;

    private void Awake()
    {
        StartCoroutine(Wait(_secondsToWait));
    }

    private void Explode()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, _radius);

        foreach (var collider in colliders)
        {
            Rigidbody rigidbody = collider.GetComponent<Rigidbody>();
            if (rigidbody)
            {
                rigidbody.AddExplosionForce(_force, transform.position, _radius);
            }
        }
    }

    private IEnumerator Wait(float sec)
    {
        while (true)
        {
            Explode();

            yield return new WaitForSeconds(sec);

        }
    }
}
