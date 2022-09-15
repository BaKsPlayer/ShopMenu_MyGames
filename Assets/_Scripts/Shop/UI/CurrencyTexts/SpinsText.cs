using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpinsText : CurrencyText
{
    protected override void Initialize()
    {
        Wallet.Instance.OnSpinsValueChanged += ValueChanged;
        ValueChanged();
    }

    protected override void Stop()
    {
        Wallet.Instance.OnSpinsValueChanged -= ValueChanged;
    }

    protected override void ValueChanged()
    {
        text.text = Wallet.Instance.Spins.ToMoneyFormat();
    }
}
