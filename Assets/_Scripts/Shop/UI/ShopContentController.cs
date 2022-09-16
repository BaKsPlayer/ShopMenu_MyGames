using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopContentController : MonoBehaviour
{
    private RectTransform rectTransform;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    private void OnEnable()
    {
        ResetToZero();
    }

    private void ResetToZero()
    {
        rectTransform.localPosition = new Vector2(rectTransform.localPosition.x, 0);
    }
}
