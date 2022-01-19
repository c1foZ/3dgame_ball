using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Transform ball;
    public Text scoreText;
    void Update()
    {
        scoreText.text = ball.position.z.ToString("0");
    }
}
