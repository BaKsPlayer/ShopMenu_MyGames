using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinsPurchaseInfo : MonoBehaviour
{
    [SerializeField] private float priceInDollars;
    public float PriceInDollars => priceInDollars;

    [SerializeField] private int valueInSpins;
    public int ValueInSpins => valueInSpins;
}
