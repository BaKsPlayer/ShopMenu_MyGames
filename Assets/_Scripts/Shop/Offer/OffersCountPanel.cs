using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffersCountPanel : MonoBehaviour
{
    [SerializeField] private OfferCircle offerCirclePrefab;

    private List<OfferCircle> offerCircles = new List<OfferCircle>();

    public void Initizlize(int totalOrdersCount)
    {
        foreach (Transform tr in transform)
        {
            offerCircles.Add(tr.GetComponent<OfferCircle>());
        }

        for (int i = 0; i < totalOrdersCount; i++)
        {
            if (i < offerCircles.Count)
            {
                offerCircles[i].SetActive(false);
            }
            else
            {
                Instantiate(offerCirclePrefab, transform).SetActive(false);
            }
        }
    }

    public void ActivateCircle(int index)
    {
        foreach (var circle in offerCircles)
        {
            circle.SetActive(false);
        }

        offerCircles[index].SetActive(true);
    }
}
