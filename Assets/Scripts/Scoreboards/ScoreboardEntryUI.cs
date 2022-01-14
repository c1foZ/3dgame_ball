
using TMPro;
using UnityEngine;

public class ScoreboardEntryUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI entryNameText = null;
    [SerializeField] private TextMeshProUGUI entryScoreText = null;

    public void Initialise(ScoreboardEntryData scoreboardEntryData)
    {
        entryNameText.text = scoreboardEntryData.entryName;
        entryScoreText.text = scoreboardEntryData.entryScore.ToString();
    }
}
