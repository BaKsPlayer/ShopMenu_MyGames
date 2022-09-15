using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfferCircle : MonoBehaviour
{
    [SerializeField] private GameObject activeCircle;

    public void SetActive(bool value)
    {
        activeCircle.SetActive(value);
    } 
}
