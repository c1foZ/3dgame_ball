using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class StopWatch : MonoBehaviour
{
    static StopWatch timer = null;
    public TextMeshProUGUI TimerText;
    public RectTransform RtTimer;
    public float SavedTimer;
    public bool playing;
    public float Timer;
    float currentTime; // your current timer (without logic)
    // float highscore = 99999; // set it to a really high value by default
    // void start()
    // {
    //     highscore = PlayerPrefs.GetFloat("best"); // get your previous highscore
    // }
    // //on level completed:
    // {
    //     if(currentTime <= highscore //your best time
    //     {
    //        highscore = currentTime;
    //        PlayerPrefs.SetFloat("best", highscore); // save your score
    //     }
    // }

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
        if (playing == true)
        {
            if (SceneManager.GetActiveScene().name == "Scoreboard")
            {
                playing = false;
                Debug.Log("Time stopped");
                // savedTimer = Timer;
                Debug.Log(Timer);
                Debug.Log(TimerText.text);
                RtTimer.offsetMin = new Vector2(0, 0);
                RtTimer.offsetMax = new Vector2(0, 0);

            }
            Timer += Time.deltaTime;
            int minutes = Mathf.FloorToInt(Timer / 60F);
            int seconds = Mathf.FloorToInt(Timer % 60F);
            int milliseconds = Mathf.FloorToInt((Timer * 100F) % 100F);
            TimerText.text = minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");
        }
        if (SceneManager.GetActiveScene().name == "Credits")
        {
            Destroy(gameObject);
        }

    }

}