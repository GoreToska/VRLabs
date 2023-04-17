using TMPro;
using UnityEngine;

public class TwoNumberComparer : MonoBehaviour
{
    [SerializeField] private TMP_InputField _a;
    [SerializeField] private TMP_InputField _b;
    [SerializeField] private TMP_Text _c;

    public void Compare()
    {
        if (Mathf.Approximately(float.Parse(_a.text), float.Parse(_b.text)))
            _c.text = "Равны";
        else
            _c.text = "Не равны";
    }
}
