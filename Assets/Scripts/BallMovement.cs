using UnityEngine;
public class BallMovement : MonoBehaviour
{
    private Rigidbody rb;
    private float forwardForce = 1000f;
    private float backwardForce = -1000f;
    private float sidewaysForce = 40f;
    private float jumpForce = 250f;
    private bool ballIsOnTheGround = true;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(0, 0, backwardForce * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (ballIsOnTheGround && Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(0, jumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
            ballIsOnTheGround = false;
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
            FindObjectOfType<GUI>().uiLevelFailedUnderGround();
        }
    }
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Ground")
        {
            ballIsOnTheGround = true;
        }
    }
}
