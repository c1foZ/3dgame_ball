using UnityEngine;
public class Menu : MonoBehaviour
{
    private void btnStartGame()
    {
        FindObjectOfType<GameManager>().StartGame();
    }
    private void btnRestartGame()
    {
        FindObjectOfType<GameManager>().RestartGame();
    }
    private void btnQuitGame()
    {
        FindObjectOfType<GameManager>().QuitGame();
    }
    private void btnResumeGame()
    {
        FindObjectOfType<GameManager>().ResumeGame();
    }


}
