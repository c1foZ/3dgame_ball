using UnityEngine;
public class EndTrigger : MonoBehaviour
{
    private void OnTriggerEnter()
    {
        FindObjectOfType<GUI>().uiCompleteLevel();
    }
}
