using TMPro;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    [SerializeField] private TMP_InputField a;
    [SerializeField] private TMP_InputField b;
    [SerializeField] private TMP_Text c;

    //3.2.1
    public void Sum()
    {
        c.text = (float.Parse(a.text) + float.Parse(b.text)).ToString();
    }

    public void Sub()
    {
        c.text = (float.Parse(a.text) * float.Parse(b.text)).ToString();
    }

    public void Diff()
    {
        c.text = (float.Parse(a.text) - float.Parse(b.text)).ToString();
    }

    public void Div()
    {
        c.text = (float.Parse(a.text) / float.Parse(b.text)).ToString();
    }
}
