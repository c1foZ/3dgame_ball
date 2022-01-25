using UnityEngine;
public class GUI : MonoBehaviour
{
    public GameObject completeLevelUI;
    public GameObject failedLevelUI;
    public GameObject failedLevelUnderGroundUI;
    public GameObject levelPausedMenuUI;

    public void uiCompleteLevel()
    {
        completeLevelUI.SetActive(true);
        Destroy(failedLevelUI);
        Destroy(failedLevelUnderGroundUI);
    }
    public void uiLevelFailed()
    {
        failedLevelUI.SetActive(true);
        Destroy(failedLevelUnderGroundUI);
    }
    public void uiLevelFailedUnderGround()
    {
        failedLevelUnderGroundUI.SetActive(true);
        Destroy(failedLevelUI);
    }
    public void uiPauseGame()
    {
        levelPausedMenuUI.SetActive(true);
    }
    public void uiResumeGame()
    {
        levelPausedMenuUI.SetActive(false);
    }




}
