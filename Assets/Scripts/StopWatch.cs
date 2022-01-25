using UnityEngine;

public class StopWatch : MonoBehaviour
{
    static StopWatch timer = null;
    public float Timer;
    private bool playing = true;
    private void Start()
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
    private void Update()
    {
        if (playing)
        {
            Timer += Time.deltaTime;
            FindObjectOfType<StopWatchUI>().uiStopWatch();
        }
    }
    public void StopTime()
    {
        playing = false;

    }
}