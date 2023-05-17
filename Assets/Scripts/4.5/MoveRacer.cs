using UnityEngine;

public class MoveRacer : MonoBehaviour
{
    [SerializeField] private GameObject _nextRacer;
    [SerializeField] private float _speed = 0.06f;
    private bool _canMove = false;
    private float _distance = 0f;

    void FixedUpdate()
    {
        if (!_canMove)
            return;

        transform.position = Vector3.MoveTowards(transform.position, _nextRacer.transform.position, _speed);
        transform.LookAt(_nextRacer.transform);
    }

    public bool CheckDistance()
    {
        if (Vector3.Distance(transform.position, _nextRacer.transform.position) <= _distance)
            return true;

        return false;
    }

    public float Distance
    {
        get { return _distance; }
        set { _distance = value; }
    }

    public bool CanMove
    {
        get { return _canMove; }
        set { _canMove = value; }
    }
}
