using UnityEngine;
using UnityEngine.UI;
public class Menu : MonoBehaviour
{
    private void btnStartGame()
    {
        GameManager.Instance.StartGame();
    }
    private void btnRestartGame()
    {
        GameManager.Instance.RestartGame();
    }
    private void btnQuitGame()
    {
        GameManager.Instance.QuitGame();
    }
    private void btnResumeGame()
    {
        GameManager.Instance.ResumeGame();
    }
    private void btnBackToMenu()
    {
        GameManager.Instance.BackToMenu();
    }



}
