using UnityEngine;
using UnityEngine.Events;

public class Wallet
{
    public int Gold { get; private set; }
    public event UnityAction OnGoldValueChanged;

    public int Spins { get; private set; }
    public event UnityAction OnSpinsValueChanged;

    private static Wallet _instance;
    public static Wallet Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Wallet();

                _instance.Initialize();
            }

            return _instance;
        }
    }

    private void Initialize()
    {
        AddGold(PlayerPrefs.GetInt("Gold"));
        AddSpins(PlayerPrefs.GetInt("Spins"));
    }

    public void AddGold(int amount)
    {
        Gold += amount;
        OnGoldValueChanged?.Invoke();
    }

    public void SpendGold(int amount)
    {
        Gold -= amount;
        OnGoldValueChanged?.Invoke();
    }

    public void  AddSpins(int amount)
    {
        Spins += amount;
        OnSpinsValueChanged?.Invoke();
    }

    public void SpendSpins(int amount)
    {
        Spins -= amount;
        OnSpinsValueChanged?.Invoke();
    }
}
