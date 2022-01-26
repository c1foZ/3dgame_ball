using UnityEngine;
public class BallCollision : MonoBehaviour
{
    private BallMovement movement;
    private Rigidbody rb;
    private GUI gUI;
    private void Awake()
    {
        movement = GetComponent<BallMovement>();
        rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collisionInfo)
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
