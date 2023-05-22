using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    [SerializeField] private List<GameObject> _points = new();
    [SerializeField] private float _speed;

    private int _index;
    private GameObject _target;
    private bool _forward = true;

    void Awake()
    {
        _target = _points[0];
        _index = 0;
    }

    void FixedUpdate()
    {
        MoveObj();
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.transform.position, _speed);
        transform.LookAt(_target.transform);
    }

    void MoveObj()
    {
        if (_forward)
        {
            if(transform.position == _target.transform.position)
            {
                if(_index == _points.Count-1)
                {
                    _forward = false;
                    return;
                }

                _target = _points[_index];
                _index++;
            }

            Move();
        }
        else
        {
            if (transform.position == _target.transform.position)
            {
                if (_index == -1)
                {
                    _forward = true;
                    _index++;
                    return;
                }

                _target = _points[_index];
                _index--;
            }

            Move();
        }
    }
}
