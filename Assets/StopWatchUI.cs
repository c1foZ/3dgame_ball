using UnityEngine;
using TMPro;
using System;

public class StopWatchUI : MonoBehaviour
{
    [Header("StopWatch Canvas")]
    public GameObject stopWatchUI;
    public TextMeshProUGUI TimerText;

    public void uiStopWatch()
    {
        TimeSpan time = TimeSpan.FromSeconds(FindObjectOfType<StopWatch>().Timer);
        TimerText.text = time.ToString("mm':'ss':'ff");
    }
}
