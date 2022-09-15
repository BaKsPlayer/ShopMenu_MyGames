using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public UnityAction OnBeginDragInput;
    public UnityAction OnEndDragInput;

    public void OnBeginDrag(PointerEventData eventData)
    {
        OnBeginDragInput?.Invoke();
    }

    public void OnDrag(PointerEventData eventData)
    {

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        OnEndDragInput?.Invoke();
    }
}
