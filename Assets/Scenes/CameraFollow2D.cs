using UnityEngine;

public class CameraFollow2D : MonoBehaviour
{
    [Header("Target Settings")]
    // This is the object the camera will follow
    public Transform target; 
    
    [Header("Camera Settings")]
    // How fast the camera catches up to the player (higher is faster)
    public float smoothSpeed = 5f; 
    // The offset keeps the camera pulled back so it can see the 2D world
    public Vector3 offset = new Vector3(0f, 1f, -10f); 

    // We use LateUpdate for cameras so it moves AFTER the player moves
    void LateUpdate()
    {
        // Make sure we actually have a target attached before trying to follow it
        if (target != null)
        {
            // Calculate where the camera should be
            Vector3 desiredPosition = target.position + offset;
            
            // Smoothly glide the camera to that new position
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
            transform.position = smoothedPosition;
        }
    }
}