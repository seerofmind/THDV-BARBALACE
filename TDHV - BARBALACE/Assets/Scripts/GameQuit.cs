using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameQuit : MonoBehaviour
{
    // Start is called before the first frame update
    public void QuitGame()
    {
        Debug.Log("El juego se cerrará."); 
        Application.Quit();
    }
}
