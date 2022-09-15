using System.Collections;
using System.Collections.Generic;
using TMPro;
using UniRx;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class TimerText : MonoBehaviour
{
    private int remainingSeconds;
    private TextMeshProUGUI text;

    private void Awake()
    {
        remainingSeconds = Random.Range(1 * 60 * 60, 3 * 60 * 60);

        text = GetComponent<TextMeshProUGUI>();

        Observable.Interval(1.ToTimeSpan()).TakeUntilDisable(gameObject).Subscribe(_ =>
        {
            remainingSeconds--;
            UpdateText();
        });
    }

    private void UpdateText()
    {
        text.text = remainingSeconds.ToTimeSpan().ToString();
    }
}
