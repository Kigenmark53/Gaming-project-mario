using UnityEngine;

public class Coin : MonoBehaviour
{
    // This runs the exact moment something touches the coin's trigger zone
    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object that touched the coin is our Player
        if (other.CompareTag("Player"))
        {
            // 1. Tell the Score Manager to add 1 point!
            ScoreManager.instance.AddCoin(); 
            
            // 2. Print a message to the Unity Console so we know it worked!
            Debug.Log("Coin Collected!");
            
            // 3. Destroy(gameObject) completely removes this coin from the game
            Destroy(gameObject);
        }
    }
}