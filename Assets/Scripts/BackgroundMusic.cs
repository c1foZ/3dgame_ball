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
                // Audio.clip = MusicClips[0];
                // Audio.Play();
                break;
            case "1":
                PlayClip(MusicClips[1]);
                // if (Audio.clip != MusicClips[1])
                // {
                //     Audio.clip = MusicClips[1];
                //     Audio.Play();
                // }
                break;
            case "5":
                PlayClip(MusicClips[2]);
                // if (Audio.clip != MusicClips[2])
                // {
                //     Audio.clip = MusicClips[2];
                //     Audio.Play();
                // }
                break;
            default:
                Debug.LogWarning($"Clip not found | scene = ${scene.name}", this);
                // PlayClip(MusicClips[3]);
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
