using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public void btnStartGame()
    {
        FindObjectOfType<GameManager>().StartGame();
    }
    public void btnRestartGame()
    {
        FindObjectOfType<GameManager>().RestartGame();
    }
    public void btnQuitGame()
    {
        FindObjectOfType<GameManager>().QuitGame();
    }
    public void btnResumeGame()
    {
        FindObjectOfType<GameManager>().ResumeGame();
    }


}
