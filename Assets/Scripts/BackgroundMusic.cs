using UnityEngine;
using UnityEngine.SceneManagement;
public class BackgroundMusic : MonoBehaviour
{
    static BackgroundMusic instance;

    [SerializeField] private AudioClip[] MusicClips;
    [SerializeField] private AudioSource Audio;

    private void Awake()
    {
        if (instance == null) { instance = this; }
        else { Destroy(gameObject); }
        DontDestroyOnLoad(gameObject);
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        switch (scene.name)
        {
            case "Menu":
                Audio.clip = MusicClips[0];
                Audio.Play();
                break;
            case "1":
                if (Audio.clip != MusicClips[1])
                {
                    Audio.clip = MusicClips[1];
                    Audio.Play();
                }
                break;
            case "5":
                if (Audio.clip != MusicClips[2])
                {
                    Audio.clip = MusicClips[2];
                    Audio.Play();
                }
                break;
            default:
                Audio.clip = MusicClips[3];
                break;
        }
    }

}
