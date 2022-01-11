using UnityEngine;
using System;

public class FollowBall : MonoBehaviour
{

    public Transform ball;
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        transform.position = ball.position + offset;
    }
}
