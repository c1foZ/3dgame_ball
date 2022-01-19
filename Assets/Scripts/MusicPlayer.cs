using UnityEngine;
public class MusicPlayer : MonoBehaviour
{
    static MusicPlayer music = null;
    void Awake()
    {
        if (music != null)
        {
            Destroy(gameObject);
        }
        else
        {
            music = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }
}