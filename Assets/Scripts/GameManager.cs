using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    private GameObject gUI;
    bool gameHasEnded = false;
    private float restartDelay = 1f;

    private bool isPaused = false;

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("1");
    }
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("RestartRound", restartDelay);
        }
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0f;
        FindObjectOfType<GUI>().uiPauseGame();
    }
    public void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1;
        FindObjectOfType<GUI>().uiResumeGame();
    }
    private void RestartRound()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    private void Update()
    {
        if ((Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape)) && isPaused == false && SceneManager.GetActiveScene().name != "Menu")
        {
            PauseGame();
        }
        else if ((Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape)) && isPaused == true && SceneManager.GetActiveScene().name != "Menu")
        {
            ResumeGame();
        }

        if (SceneManager.GetActiveScene().name == "Scoreboard")
        {
            FindObjectOfType<StopWatch>().StopTime();
        }
        if (SceneManager.GetActiveScene().name == "Credits")
        {
            Destroy(GameObject.FindWithTag("StopWatch"));
        }
        if (
        Input.GetKey(KeyCode.R))
        {
            FindObjectOfType<GameManager>().RestartGame();
            Destroy(GameObject.FindWithTag("StopWatch"));
        }
    }

}

