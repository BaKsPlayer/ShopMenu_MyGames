using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestPurchaseInfo : MonoBehaviour
{
    [SerializeField] private int priceInSpins;
    public int PriceInSpins => priceInSpins;

    [SerializeField] private Range goldRandomRange;
    public Range GoldRandomRange => goldRandomRange;
}
