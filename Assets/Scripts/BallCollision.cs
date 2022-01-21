using UnityEngine;
public class BallCollision : MonoBehaviour
{
    public BallMovement movement;
    public Rigidbody rb;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Wall")
        {
            movement.enabled = false;
            rb.AddForce(100, 100, 100);
            FindObjectOfType<GameManager>().EndGame();
            FindObjectOfType<GUI>().uiLevelFailed();
        };
    }
}
