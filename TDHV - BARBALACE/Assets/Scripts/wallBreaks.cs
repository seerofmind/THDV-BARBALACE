using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallBreaks : MonoBehaviour
{
    public int collectablesCollected = 0; // Counter for collectables
    public GameObject wall; // Assign the wall object you want to disappear
    public GameObject keyMessageText; // The UI text for "You don't have the key"
    public float messageDuration = 2f; // How long the message stays on screen
    private bool messageShown = false;
    void OnTriggerEnter(Collider other)
    {
        
        if (collectablesCollected >= 1)
            {
                RemoveWall();

        }

    }


    void RemoveWall()
    {
    // Deactivate or destroy the wall
        wall.SetActive(false); // This makes the wall disappear
                           // Alternatively, you can destroy the wall
                           // Destroy(wall);
 
    }
    void ShowMessage()
    {
        if (!messageShown)
        {
            keyMessageText.SetActive(true); // Show the "You don't have the key" message
            messageShown = true;
            Invoke("HideMessage", messageDuration); // Hide the message after a few seconds
        }
    }

    void HideMessage()
    {
        keyMessageText.SetActive(false); // Hide the message after the delay
        messageShown = false; // Reset message shown state
    }

}
