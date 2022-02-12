using UnityEngine;
public class GUI : MonoBehaviour
{
    [Header("Level Complete")]
    [SerializeField] private GameObject completeLevelUI;

    [Header("Level Failed")]
    [SerializeField] private GameObject failedLevelUI;
    [SerializeField] private GameObject failedLevelUnderGroundUI;

    [Header("Level Paused")]
    [SerializeField] private GameObject levelPausedMenuUI;

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
        Destroy(completeLevelUI);
    }
    public void uiLevelFailedUnderGround()
    {
        failedLevelUnderGroundUI.SetActive(true);
        Destroy(failedLevelUI);
        Destroy(completeLevelUI);
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
