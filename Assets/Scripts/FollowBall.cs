using UnityEngine;
public class FollowBall : MonoBehaviour
{
    public Transform ball;
    private Vector3 offset;
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            offset = new Vector3(-3, 3.5f, -10);
            Camera.main.transform.rotation = Quaternion.Euler(15, 18, 0);
            transform.position = ball.position + offset;
        }
        else if (Input.GetKey(KeyCode.E))
        {
            offset = new Vector3(3, 3.5f, -10);
            Camera.main.transform.rotation = Quaternion.Euler(15, -18, 0);
            transform.position = ball.position + offset;
        }
        else
        {
            offset = new Vector3(0, 3.5f, -10);
            Camera.main.transform.rotation = Quaternion.Euler(15, 0, 0);
        }
        transform.position = ball.position + offset;
    }
}