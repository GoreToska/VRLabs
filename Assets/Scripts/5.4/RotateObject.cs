using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField] private float _speed;
    
    void FixedUpdate()
    {
        transform.Rotate(0, _speed * Time.fixedDeltaTime, 0);

    }
}
