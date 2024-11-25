using System.IO;
using UnityEngine;
using TMPro;

public class Scoreboard : MonoBehaviour
{
    [SerializeField] private int maxScoreboardEntries = 5;
    [SerializeField] private Transform highscoresHolderTransform;
    [SerializeField] private GameObject scoreboardEntryObject;

    public GameObject inputField;

    private string SavePath => Path.Combine(Application.persistentDataPath, "highscores.json");

    private void Start()
    {
        if (HasPermissionToSave())
        {
            ScoreboardSaveData savedScores = GetSavedScores();
            UpdateUI(savedScores);
            SaveScores(savedScores);
        }
        else
        {
            Debug.LogWarning("Permission to save file denied.");
        }
    }

    private bool HasPermissionToSave()
    {
        if (Directory.Exists(Application.persistentDataPath))
        {
            return true;
        }
        else
        {
            Debug.LogWarning("Save path is not accessible.");
            return false;
        }
    }

    public void StoreNameAndScore()
    {
        var userScore = FindObjectOfType<StopWatch>().Timer;
        AddEntry(new ScoreboardEntryData()
        {
            entryName = inputField.GetComponent<TextMeshProUGUI>().text,
            entryScore = userScore
        });
    }

    public void AddEntry(ScoreboardEntryData scoreboardEntryData)
    {
        ScoreboardSaveData savedScores = GetSavedScores();

        var index = savedScores.highscores
            .FindIndex((hs) => hs.entryScore > scoreboardEntryData.entryScore);
        var isScoreAdded = index != -1;
        if (isScoreAdded)
        {
            savedScores.highscores.Insert(index, scoreboardEntryData);
        }

        if (!isScoreAdded && savedScores.highscores.Count < maxScoreboardEntries)
        {
            savedScores.highscores.Add(scoreboardEntryData);
        }

        if (savedScores.highscores.Count > maxScoreboardEntries)
        {
            savedScores.highscores.RemoveRange(maxScoreboardEntries, savedScores.highscores.Count - maxScoreboardEntries);
        }

        UpdateUI(savedScores);

        SaveScores(savedScores);
    }

    private void UpdateUI(ScoreboardSaveData savedScores)
    {
        foreach (Transform child in highscoresHolderTransform)
        {
            Destroy(child.gameObject);
        }

        foreach (ScoreboardEntryData highscore in savedScores.highscores)
        {
            Instantiate(scoreboardEntryObject, highscoresHolderTransform).GetComponent<ScoreboardEntryUI>().Initialise(highscore);
        }
    }

    private ScoreboardSaveData GetSavedScores()
    {
        if (!File.Exists(SavePath))
        {
            File.Create(SavePath).Dispose();
            return new ScoreboardSaveData();
        }

        using (StreamReader stream = new StreamReader(SavePath))
        {
            string json = stream.ReadToEnd();
            return JsonUtility.FromJson<ScoreboardSaveData>(json) != null ? JsonUtility.FromJson<ScoreboardSaveData>(json) : new ScoreboardSaveData();
        }
    }

    private void SaveScores(ScoreboardSaveData scoreboardSaveData)
    {
        using (StreamWriter stream = new StreamWriter(SavePath))
        {
            string json = JsonUtility.ToJson(scoreboardSaveData, true);
            stream.Write(json);
        }
    }
}
