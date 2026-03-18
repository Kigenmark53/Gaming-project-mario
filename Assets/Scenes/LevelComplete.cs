using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object crossing the finish line is the Player
        if (other.CompareTag("Player"))
        {
            Debug.Log("LEVEL 1 COMPLETE! YOU WIN!");
            
            // Right now, we will just restart Level 1 to celebrate.
            // Later, we can change this to load "Level 2"!
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}