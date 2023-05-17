using UnityEngine;

public class MoveRacerTwo : MonoBehaviour
{
    [SerializeField] private GameObject _nextRacer;
    [SerializeField] private float _speed = 0.06f;
    private Transform _stick;
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

    public void GiveStick()
    {
        _stick = this.transform.GetChild(1);
        _stick.parent = _nextRacer.transform;
        _stick.transform.localPosition = new Vector3(0.5f, 0, 0.7f);
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
