using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldText : CurrencyText
{
    protected override void Initialize()
    {
        Wallet.Instance.OnGoldValueChanged += ValueChanged;
        ValueChanged();
    }

    protected override void Stop()
    {
        Wallet.Instance.OnGoldValueChanged -= ValueChanged;
    }

    protected override void ValueChanged()
    {
        text.text = Wallet.Instance.Gold.ToMoneyFormat();
    }
}
