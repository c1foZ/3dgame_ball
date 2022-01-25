using UnityEngine.EventSystems;
using UnityEngine;

public class ButtonOnFocus : MonoBehaviour
{
    public GameObject selectButton;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape))
        {
            EventSystem.current.SetSelectedGameObject(
                     selectButton);
        }
    }
}