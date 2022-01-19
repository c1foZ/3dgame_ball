using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CurrentLevel : MonoBehaviour
{
    public Text levelNumber;
    void Awake()
    {
        levelNumber.text = SceneManager.GetActiveScene().name;
    }
}
