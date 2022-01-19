using System;
using TMPro;
using UnityEngine;

public class ScoreboardEntryUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI entryNameText = null;
    [SerializeField] private TextMeshProUGUI entryScoreText = null;
    private StopWatch stopWatch;
    private float Timer;

    public void Initialise(ScoreboardEntryData scoreboardEntryData)
    {
        entryNameText.text = scoreboardEntryData.entryName;
        TimeSpan time = TimeSpan.FromSeconds(scoreboardEntryData.entryScore);
        entryScoreText.text = time.ToString("mm':'ss','fff");

    }
}
