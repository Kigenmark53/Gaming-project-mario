using UnityEngine;
// We need this line to load and restart levels!
using UnityEngine.SceneManagement; 

public class DeathZone : MonoBehaviour
{
    // This built-in Unity function runs the moment something touches our Trigger collider
    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object that fell in has the "Player" tag we set earlier
        if (other.CompareTag("Player"))
        {
            // Restart the current active scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}