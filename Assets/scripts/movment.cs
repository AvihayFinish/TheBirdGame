using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movment : MonoBehaviour
{
    public float jumpForce = 5f;
    public float speedX = 5f;
    private Rigidbody2D rb;
    [SerializeField] float minY;
    [SerializeField] float maxY;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        rb.velocity = new Vector2(speedX, rb.velocity.y);

        Vector3 currentPosition = transform.position;

        // Clamp the position to the desired bounds on the y-axis
        float clampedY = Mathf.Clamp(currentPosition.y, minY, maxY);

        // Update the position with the clamped value
        transform.position = new Vector3(currentPosition.x, clampedY, currentPosition.z);
    }

     void Jump()
    {
        // Apply an upward force for the jump
        rb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);    
    }
}
