using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(RectTransform), typeof(HorizontalLayoutGroup))]
public class OffersContentController : MonoBehaviour
{
    [SerializeField] private DragHandler dragHandler;
    [SerializeField] private OffersCountPanel offersCountPanel;
    [SerializeField] private GameObject offerPrefab;
    [SerializeField] private float speed = 10f;

    private HorizontalLayoutGroup layoutGroup;
    private RectTransform rectTransform;
    private bool isMoving;
    private int currentIndex = 0;
    private float range ;

    private void Awake()
    {
        layoutGroup = GetComponent<HorizontalLayoutGroup>();
        rectTransform = GetComponent<RectTransform>();

        range = layoutGroup.spacing + offerPrefab.GetComponent<RectTransform>().sizeDelta.x;

        offersCountPanel.Initizlize(transform.childCount);
        offersCountPanel.ActivateCircle(currentIndex);

        dragHandler.OnBeginDragInput += BeginDrag;
        dragHandler.OnEndDragInput += EndDrag;
    }

    private void OnDestroy()
    {
        dragHandler.OnBeginDragInput -= BeginDrag;
        dragHandler.OnEndDragInput -= EndDrag;
    }

    private void BeginDrag()
    {
        isMoving = false;
    }

    private void EndDrag()
    {
        isMoving = true;
    }

    private void Update()
    {
        if (isMoving == false)
        {
            return;
        }

        currentIndex = CalculateIndex();
        offersCountPanel.ActivateCircle(currentIndex);
        rectTransform.localPosition = Vector2.MoveTowards(rectTransform.localPosition, new Vector2(-currentIndex * range, rectTransform.localPosition.y), speed * Time.deltaTime);
    }

    private int CalculateIndex()
    {
        return Mathf.RoundToInt(-rectTransform.localPosition.x / (range - layoutGroup.spacing / 2));
    }
}
