using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement2D : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveSpeed = 5f;
    public float jumpForce = 7f;

    private Rigidbody2D rb;
    private float horizontalInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true; 
    }

    void Update()
    {
        // 1. Keyboard fallback so you can still test on PC!
        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            horizontalInput = Input.GetAxisRaw("Horizontal");
        }

        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(horizontalInput * moveSpeed, rb.linearVelocity.y);
    }

    // --- MOBILE BUTTON CONTROLS ---

    public void Jump()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
    }

    public void MoveLeft()
    {
        horizontalInput = -1f;
    }

    public void MoveRight()
    {
        horizontalInput = 1f;
    }

    public void StopMoving()
    {
        // Only stop if the keyboard isn't being pressed
        if (Input.GetAxisRaw("Horizontal") == 0)
        {
            horizontalInput = 0f;
        }
    }
}