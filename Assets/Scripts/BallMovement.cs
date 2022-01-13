using UnityEngine;
public class BallMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 40f;
    public float jumpForce = 20f;
    public bool ballIsOnTheGround = true;
    // Start is called before the first frame update

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("w") || Input.GetKey("up"))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (ballIsOnTheGround && Input.GetKey("space"))
        {
            rb.AddForce(0, jumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
            Debug.Log("Jump");
            ballIsOnTheGround = false;
        };

        if (Input.GetKey("s") || Input.GetKey("down"))
        {
            rb.AddForce(0, 0, -1000 * Time.deltaTime);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Ground")
        {
            ballIsOnTheGround = true;
            Debug.Log("Is on the Ground");
        }
    }
}
