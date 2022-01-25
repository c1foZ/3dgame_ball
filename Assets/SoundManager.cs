using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour
{

    public AudioSource audioSource;
    public Slider mySlider;
    public void OnValueChanged()
    {
        AudioListener.volume = mySlider.value;
    }

}
