using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 2f;
    public GameObject completeLevelUI;
    public GameObject failedLevelUI;
    public GameObject failedLevelUnderGroundUI;
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        Destroy(failedLevelUI);
        Destroy(failedLevelUnderGroundUI);
    }
    public void LevelFailed()
    {
        failedLevelUI.SetActive(true);
    }
    public void LevelFailedUnderGround()
    {
        failedLevelUnderGroundUI.SetActive(true);
    }
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void RestartAll()
    {
        SceneManager.LoadScene("1");
    }
}

