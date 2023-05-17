using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartForce : MonoBehaviour
{
    [SerializeField] private float _punchPower = 500;
    private void Awake()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * _punchPower, ForceMode.Impulse);
    }
}
