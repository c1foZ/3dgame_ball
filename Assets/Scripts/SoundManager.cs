using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{

    private AudioSource audioSource;
    private Slider mySlider;
    private void Awake()
    {
        audioSource = GameObject.FindGameObjectWithTag("GameMusic").GetComponent<AudioSource>();
        mySlider = GetComponent<Slider>();
    }
    private void OnValueChanged()
    {
        AudioListener.volume = mySlider.value;
    }

}
