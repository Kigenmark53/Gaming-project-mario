using UnityEngine;

// This line automatically adds a Rigidbody2D to your platform so you don't have to!
[RequireComponent(typeof(Rigidbody2D))] 
public class MovingPlatform : MonoBehaviour
{
    [Header("Movement Settings")]
    public float speed = 2f;      // How fast it moves
    public float distance = 3f;   // How high and low it goes

    private Vector2 startPosition;
    private Rigidbody2D rb;

    void Start()
    {
        // Grab the Rigidbody and the starting location
        rb = GetComponent<Rigidbody2D>();
        startPosition = transform.position;

        // Tell the physics engine this is a moving platform, not a falling brick
        rb.bodyType = RigidbodyType2D.Kinematic; 
    }

    // We use FixedUpdate instead of Update whenever we are moving physics objects!
    void FixedUpdate()
    {
        // Calculate the new up/down position
        float newY = startPosition.y + Mathf.Sin(Time.time * speed) * distance;
        
        // Tell the physics engine to smoothly push the platform to the new spot
        rb.MovePosition(new Vector2(startPosition.x, newY));
    }
}