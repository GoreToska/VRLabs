using TMPro;
using UnityEngine;

public class LockPick : MonoBehaviour
{
    [SerializeField] private TMP_Text _time;
    [SerializeField] private TMP_Text _firstSlot;
    [SerializeField] private TMP_Text _secondSlot;
    [SerializeField] private TMP_Text _thirdSlot;

    private float _timeLeft;
    private int _first;
    private int _second;
    private int _third;

    private void Update()
    {
        _timeLeft -= Time.deltaTime;
        _time.text = _timeLeft.ToString();
    }

    private void UpdateSlots()
    {
        _firstSlot.text = _first.ToString();
        _secondSlot.text = _second.ToString();
        _thirdSlot.text = _third.ToString();
    }

    public void UseLockPick()
    {

    }

    public void UseDrill()
    {

    }

    public void UseHammer()
    {

    }
}
