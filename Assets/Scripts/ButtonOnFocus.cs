using UnityEngine.EventSystems;
using UnityEngine;

public class ButtonOnFocus : MonoBehaviour
{
    [SerializeField] private GameObject selectButton;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape))
        {
            EventSystem.current.SetSelectedGameObject(
                     selectButton);
        }
    }
}