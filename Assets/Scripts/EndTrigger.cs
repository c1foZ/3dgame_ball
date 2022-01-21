using UnityEngine;
public class EndTrigger : MonoBehaviour
{
    public GUI gUI;
    void OnTriggerEnter()
    {
        gUI.uiCompleteLevel();
    }
}
