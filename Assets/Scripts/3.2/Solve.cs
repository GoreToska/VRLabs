using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Solve : MonoBehaviour
{
    [SerializeField] private TMP_InputField _a;
    [SerializeField] private TMP_InputField _b;
    [SerializeField] private TMP_InputField _c;
    [SerializeField] private TMP_Text _res;

    private float _af;
    private float _bf;
    private float _cf;

    private void Parse()
    {
        _af = float.Parse(_a.text);
        _bf = float.Parse(_b.text);
        _cf = float.Parse(_c.text);
    }

    public void SolveButton()
    {
        Parse();

        if( Mathf.Approximately(_af, 0))
        {
            _res.text = "a = 0 - не решить";
            return;
        }

        var D = _bf * _bf - 4 * _af * _cf;
        var x1 = (-_bf + Mathf.Sqrt(D*D))/2/_af;
        var x2 = (-_bf - Mathf.Sqrt(D * D)) / 2 / _af;
        _res.text = $"{x1} {x2}";
    }
}
