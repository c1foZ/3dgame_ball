using UnityEngine;

public class StopWatch : MonoBehaviour
{
    static StopWatch timer = null;
    private float _timer;
    public float Timer
    {
        get
        {
            return _timer;
        }
    }
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
            _timer += Time.deltaTime;
            FindObjectOfType<StopWatchUI>().uiStopWatch();
        }
    }
    public void StopTime()
    {
        playing = false;

    }
}