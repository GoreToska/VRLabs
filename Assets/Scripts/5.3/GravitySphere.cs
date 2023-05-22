using UnityEngine;

public class GravitySphere : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger");
        Gravity(other, false);
    }

    private void OnTriggerExit(Collider other)
    {
        Gravity(other, true);
    }

    private void Gravity(Collider collider, bool value)
    {
        collider.gameObject.GetComponent<Rigidbody>().useGravity = value;
    }
}
