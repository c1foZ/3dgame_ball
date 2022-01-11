using UnityEngine;

public class BallCollision : MonoBehaviour
{
    public BallMovement movement;
    public Rigidbody rb;
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Wall")
        {
            movement.enabled = false;
            rb.AddForce(100, 500, 100);
            FindObjectOfType<GameManager>().EndGame();
        };
    }
}
