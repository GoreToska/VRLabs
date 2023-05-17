using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceTwo : MonoBehaviour
{
    [SerializeField] private List<GameObject> _racers = new();
    [SerializeField] private float _distance;

    private int _currentRacer = 0;

    private void Awake()
    {
        foreach (var item in _racers)
            item.GetComponent<MoveRacerTwo>().Distance = _distance;

        _racers[_currentRacer].GetComponent<MoveRacerTwo>().CanMove = true;
    }

    private void Update()
    {
        CheckDistance(_currentRacer);
    }

    private void CheckDistance(int index)
    {
        if (_racers[index].GetComponent<MoveRacerTwo>().CheckDistance())
        {
            _racers[index].GetComponent<MoveRacerTwo>().CanMove = false;
            _racers[index].GetComponent<MoveRacerTwo>().GiveStick();
            _currentRacer = GetValidIndex(index);
            _racers[GetValidIndex(index)].GetComponent<MoveRacerTwo>().CanMove = true;
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
