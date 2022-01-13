using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CurrentLevel : MonoBehaviour
{


    public Text levelNumber;

    // Update is called once per frame
    void Awake()
    {
        levelNumber.text = SceneManager.GetActiveScene().name;
    }
}
