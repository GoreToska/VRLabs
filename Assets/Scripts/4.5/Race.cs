using System.Collections.Generic;
using UnityEngine;

public class Race : MonoBehaviour
{
    [SerializeField] private List<GameObject> _racers = new();
    [SerializeField] private float _distance;

    private int _currentRacer = 0;

    private void Awake()
    {
        foreach (var item in _racers)
            item.GetComponent<MoveRacer>().Distance = _distance;

        _racers[_currentRacer].GetComponent<MoveRacer>().CanMove = true;
    }

    private void Update()
    {
        CheckDistance(_currentRacer);
    }

    private void CheckDistance(int index)
    {
        if (_racers[index].GetComponent<MoveRacer>().CheckDistance())
        {
            _racers[index].GetComponent<MoveRacer>().CanMove = false;
            _currentRacer = GetValidIndex(index);
            _racers[GetValidIndex(index)].GetComponent<MoveRacer>().CanMove = true;
            Debug.Log(GetValidIndex(index));
        }

    }

    private int GetValidIndex(int index)
    {
        if (index == _racers.Count - 1)
            return 0;
        else
            return index + 1;
    }
}
