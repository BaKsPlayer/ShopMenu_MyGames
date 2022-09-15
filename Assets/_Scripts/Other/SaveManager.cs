using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("Gold", Wallet.Instance.Gold);
        PlayerPrefs.SetInt("Spins", Wallet.Instance.Spins);
    }
}
