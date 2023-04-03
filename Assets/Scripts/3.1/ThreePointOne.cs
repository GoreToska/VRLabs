using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreePointOne : MonoBehaviour
{
    //first step
    private string _helloString = "Hello, world!";

    //second step
    private int _firstInt = 3;
    private int _secondInt = 4;
    private int _thirdInt = 5;

    //third step
    private int _count = 50;
    private string _name = "Car";
    private int _price = 500;

    //fourth step 
    private int _a = 5;
    private int _b = 10;
    private int _temp;

    private void Awake()
    {
        Debug.Log(_helloString);

        Debug.Log($"{_firstInt} {_secondInt} {_thirdInt}");

        Debug.Log($"{_name} {_count * _price}");

        Debug.Log($"{_a} {_b}");
        _temp = _a;
        _a = _b;
        _b = _temp;
        Debug.Log($"{_a} {_b}");

        Debug.Log($"Numbers - {_a}, {_b}\nSum {_a + _b}, diff {_a - _b}, prod {_a * _b}");
    }

    public void SayHello()
    {
        Debug.Log(_helloString);
    }
}
