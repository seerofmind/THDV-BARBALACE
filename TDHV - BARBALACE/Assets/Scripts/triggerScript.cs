using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Import scene management

public class RestartGame : MonoBehaviour
{
    // This method will be called when the player enters the trigger collider
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that triggered the collision is the player
        if (other.CompareTag("Player"))
        {
            // Restart the game by reloading the current scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}
