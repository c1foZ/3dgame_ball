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
                PlayClip(MusicClips[0], forced: true);
                break;
            case "1":
                PlayClip(MusicClips[1]);
                break;
            case "5":
                PlayClip(MusicClips[2]);
                break;
            default:
                Debug.LogWarning($"Clip not found | scene = ${scene.name}", this);
                Audio.clip = MusicClips[3];
                break;
        }
    }

    private void PlayClip(AudioClip audioClip, bool forced = false)
    {
        var isSame = audioClip == Audio.clip;
        if (!forced && isSame)
        {
            return;
        }
        if (forced == false && isSame == true)
        {
            return;
        }
        Audio.clip = audioClip;
        Audio.Play();
    }
}
