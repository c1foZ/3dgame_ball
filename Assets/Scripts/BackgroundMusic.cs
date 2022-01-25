using UnityEngine;
using UnityEngine.SceneManagement;
public class BackgroundMusic : MonoBehaviour
{
    static BackgroundMusic instance;

    public AudioClip[] MusicClips;
    public AudioSource Audio;
    public bool isOdd = true;

    void Awake()
    {
        if (instance == null) { instance = this; }
        else { Destroy(gameObject); }

        DontDestroyOnLoad(gameObject);
        Audio.Play();
    }
    private void Start()
    {
        Audio.clip = MusicClips[0];
        Audio.Play();
    }
    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "1" && isOdd == true)
        {
            Audio.clip = MusicClips[1];
            Audio.Play();
            isOdd = false;
        }

        if (SceneManager.GetActiveScene().name == "5" && isOdd == false)
        {
            Audio.clip = MusicClips[2];
            Audio.Play();
            isOdd = true;
        }
    }
}
