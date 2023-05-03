using TMPro;
using UnityEngine;

public class LockPick : MonoBehaviour
{
    [SerializeField] private TMP_Text _time;
    [SerializeField] private TMP_Text _firstSlot;
    [SerializeField] private TMP_Text _secondSlot;
    [SerializeField] private TMP_Text _thirdSlot;

    [SerializeField] private GameObject _endCanvas;
    [SerializeField] private TMP_Text _endLabel;

    private float _timeLeft = 60f;
    private int _first = 7;
    private int _second = 3;
    private int _third = 5;

    private bool _isPlaying = true;

    private void FixedUpdate()
    {
        if (_isPlaying)
        {
            _timeLeft -= Time.fixedDeltaTime;
            _time.text = Mathf.Round(_timeLeft).ToString();

            if (_timeLeft <= 0)
            {
                EndGame(false);
            }
        }
    }

    private void UpdateSlots()
    {
        _firstSlot.text = _first.ToString();
        _secondSlot.text = _second.ToString();
        _thirdSlot.text = _third.ToString();

        if (_first == _second && _first == _third)
        {
            EndGame(true);
        }
    }

    private int ValidateSlot(int slot)
    {
        if (slot > 10)
            return 10;

        if (slot < 0)
            return 0;

        return slot;
    }

    public void UseLockPick()
    {
        _first -= 1;
        _second += 1;
        _third += 1;

        _first = ValidateSlot(_first);
        _second = ValidateSlot(_second);
        _third = ValidateSlot(_third);

        UpdateSlots();
    }

    public void UseDrill()
    {
        _first += 1;
        _second -= 1;

        _first = ValidateSlot(_first);
        _second = ValidateSlot(_second);
        _third = ValidateSlot(_third);

        UpdateSlots();
    }

    public void UseHammer()
    {
        _first -= 1;
        _second += 2;
        _third -= 1;

        _first = ValidateSlot(_first);
        _second = ValidateSlot(_second);
        _third = ValidateSlot(_third);

        UpdateSlots();
    }

    private void EndGame(bool win)
    {
        _isPlaying = false;

        if (win)
            _endLabel.text = "Капитан, вы остановили опасных преступников.";
        else
            _endLabel.text = "Капитан, совет безопасности разочарован в Вас. Вы будете заключены на пожизненный срок.";

        this.gameObject.SetActive(false);
        _endCanvas.SetActive(true);
    }
}
