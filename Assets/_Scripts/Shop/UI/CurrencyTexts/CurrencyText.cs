using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class CurrencyText : MonoBehaviour
{
    protected TextMeshProUGUI text;

    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        Initialize();
    }

    private void OnDisable()
    {
        Stop();
    }

    protected abstract void Initialize();

    protected abstract void Stop();

    protected abstract void ValueChanged();
}
