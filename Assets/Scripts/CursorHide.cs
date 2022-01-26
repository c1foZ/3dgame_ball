using UnityEngine;
using UnityEngine.EventSystems;
public class CursorHide : MonoBehaviour
{
    GameObject lastselect;
    private void Start()
    {
        lastselect = new GameObject();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update()
    {
        if (EventSystem.current.currentSelectedGameObject == null)
        {
            EventSystem.current.SetSelectedGameObject(lastselect);
        }
        else
        {
            lastselect = EventSystem.current.currentSelectedGameObject;
        }
    }
}

