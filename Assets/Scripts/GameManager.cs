using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;
    private float restartDelay = 1f;
    private bool isPaused = false;
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.Log("Nope");
            }

            return _instance;
        }
    }
    private void Awake()
    {
        _instance = this;
    }
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
    private void PauseGame()
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
    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
        Destroy(GameObject.FindWithTag("StopWatch"));
    }
    private void Update()
    {
        if ((Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape)) && isPaused == false && SceneManager.GetActiveScene().name != "Menu" && SceneManager.GetActiveScene().name != "Scoreboard" && SceneManager.GetActiveScene().name != "Credits")
        {
            PauseGame();
        }
        else if ((Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape)) && isPaused == true && SceneManager.GetActiveScene().name != "Menu" && SceneManager.GetActiveScene().name != "Scoreboard" && SceneManager.GetActiveScene().name != "Credits")
        {
            ResumeGame();
        }

        if (SceneManager.GetActiveScene().name == "Scoreboard")
        {
            StopWatch stopwatch = FindObjectOfType<StopWatch>();
            if (stopwatch != null)
            {
                stopwatch.StopTime();
            }
        }
        if (
        Input.GetKey(KeyCode.R) && (SceneManager.GetActiveScene().name != "Scoreboard"))
        {
            FindObjectOfType<GameManager>().RestartGame();
            Destroy(GameObject.FindWithTag("StopWatch"));
        }
    }

}

