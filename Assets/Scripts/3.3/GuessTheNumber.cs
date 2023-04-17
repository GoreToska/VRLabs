using TMPro;
using UnityEngine;

public class GuessTheNumber : MonoBehaviour
{
    [SerializeField] private TMP_InputField _input;
    [SerializeField] private TMP_Text _output;

    private int _number;
    private int _trys = 1;

    void Awake()
    {
        SetNumber();
    }

    private void SetNumber()
    {
        _trys = 1;
        _number = Random.Range(0, 25);
        Debug.Log(_number);
    }

    public void GuessNumber()
    {
        var number = int.Parse(_input.text);
        Debug.Log(number);


        if (number > _number)
        {
            _output.text = "Загаданное число меньше!";
            _trys++;
            return;
        }

        if (number < _number)
        {
            _output.text = "Загаданное число больше!";
            _trys++;
            return;
        }

        if (number == _number)
        {
            _output.text = $"Вы выиграли за {_trys} попыток! Попробуйте еще!";
            SetNumber();
            return;
        }
    }
}
