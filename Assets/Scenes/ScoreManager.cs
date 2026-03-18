using UnityEngine;
using TMPro; 

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance; 
    
    public TMP_Text scoreText; 
    private int coins = 0;     

    void Awake()
    {
        // Ensures only one instance exists
        if (instance == null)
        {
            instance = this;
        }
    }

    public void AddCoin()
    {
        coins += 1; 
        
        // This will tell us if the Manager is actually hearing the Coin!
        Debug.Log("The Manager heard the coin! Math is now: " + coins); 
        
        scoreText.text = "Coins: " + coins;
    }
}