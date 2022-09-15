using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public void PurchaseSpins(SpinsPurchaseInfo buttonInfo)
    {
        Wallet.Instance.AddSpins(buttonInfo.ValueInSpins);
    }

    public void PurchaseChest(ChestPurchaseInfo buttonInfo)
    {
       if (buttonInfo.PriceInSpins <= Wallet.Instance.Spins)
        {
            Wallet.Instance.SpendSpins(buttonInfo.PriceInSpins);

            var randomGoldValue = Random.Range(buttonInfo.GoldRandomRange.min, buttonInfo.GoldRandomRange.max);
            Wallet.Instance.AddGold(randomGoldValue);
        }
    }
}
