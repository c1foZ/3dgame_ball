using UnityEngine;
using UnityEngine.UI;

public class StopWatch : MonoBehaviour
{
    static StopWatch timer = null;
    public Text TimerText;
    public bool playing;
    private float Timer;
    float currentTime; // your current timer (without logic)
    float highscore = 99999; // set it to a really high value by default
    void start()
    {
        highscore = PlayerPrefs.GetFloat("best"); // get your previous highscore
    }
    // //on level completed:
    // {
    //     if(currentTime <= highscore //your best time
    //     {
    //        highscore = currentTime;
    //        PlayerPrefs.SetFloat("best", highscore); // save your score
    //     }
    // }

    void Awake()
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

            Timer += Time.deltaTime;
            int minutes = Mathf.FloorToInt(Timer / 60F);
            int seconds = Mathf.FloorToInt(Timer % 60F);
            int milliseconds = Mathf.FloorToInt((Timer * 100F) % 100F);
            TimerText.text = minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");
        }

    }

}