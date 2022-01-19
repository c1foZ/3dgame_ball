using UnityEngine;
using System;
using TMPro;
using UnityEngine.SceneManagement;

public class StopWatch : MonoBehaviour
{
    static StopWatch timer = null;
    public TextMeshProUGUI TimerText;
    public RectTransform RtTimer;
    public float Timer;
    private bool playing = true;
    void Start()
    {

        if (timer != null)
        {
            Destroy(gameObject);
        }
        else
        {
            timer = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }

    }
    void Update()
    {
        if (playing)
        {
            if (SceneManager.GetActiveScene().name == "Scoreboard")
            {
                playing = false;
                RtTimer.offsetMin = new Vector2(0, 0);
                RtTimer.offsetMax = new Vector2(0, 0);
            }
            Timer += Time.deltaTime;
            TimeSpan time = TimeSpan.FromSeconds(Timer);
            TimerText.text = time.ToString("mm':'ss':'ff");
        }
        if (SceneManager.GetActiveScene().name == "Credits")
        {
            Destroy(gameObject);
        }
        if (
        Input.GetKey(KeyCode.Escape))
        {
            FindObjectOfType<GameManager>().RestartAll();
            Destroy(gameObject);
        }

    }
}