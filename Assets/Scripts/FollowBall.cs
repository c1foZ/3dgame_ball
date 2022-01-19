using UnityEngine;
public class FollowBall : MonoBehaviour
{
    public Transform ball;
    public Vector3 offset;
    void Update()
    {
        transform.position = ball.position + offset;
    }
}