using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    // Static instance for easy access from other scripts
    public static GameManager instance;

    // The number of items the player has collected
    public int collectedItems = 0;

    // The required number of items to proceed
    public int requiredItems = 3;  // You can set this in the Inspector

    private void Awake()
    {
        // Ensure only one GameManager exists
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);  // Keeps the GameManager when scene reloads
        }
        else
        {
            Destroy(gameObject);  // Prevent duplicates on scene reload
        }
    }


    // Method to check if the player has collected enough items
    public bool HasCollectedEnoughItems()
    {
        return collectedItems >= requiredItems;
    }

    // Method to increment the number of collected items
    public void CollectItem()
    {
        collectedItems++;
        Debug.Log("Items Collected: " + collectedItems); // Log to ensure it's being called
    }
}