using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ThreeNumberComparer : MonoBehaviour
{
    [SerializeField] private TMP_InputField _a;
    [SerializeField] private TMP_InputField _b;
    [SerializeField] private TMP_InputField _c;
    [SerializeField] private TMP_Text _d;
    
    private float _af;
    private float _bf;
    private float _cf;

    private float _first;
    private float _second;

    public void Compare()
    {
        ChooseNumbers();

        if(Mathf.Approximately(_first, _second))
            _d.text = $"{_first}, {_second} Равны";
        else
            _d.text = $"{_first}, {_second} Не равны";
    }

    private void ChooseNumbers()
    {
        _af = float.Parse(_a.text);
        _bf = float.Parse(_b.text);
        _cf = float.Parse(_c.text);

        if(_af>=_bf && _af>=_cf && _bf >= _cf)
        { 
            _first = _af;
            _second = _bf;
        }
        else if(_bf>=_af && _bf>=_cf && _cf>=_af)
        {
            _first = _bf;
            _second = _cf;
        }
        else
        {
            _first = _af;
            _second = _cf;
        }
    }
}
