using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Microsoft.Unity.VisualStudio.Editor;

public class PlayerUI : MonoBehaviour
    
{
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] FirstPersonLook fpsLook;
    private bool isInPause = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isInPause = !isInPause;
            pauseMenu.SetActive(isInPause);
        }
        if (isInPause)
        { 
            Time.timeScale = 0;
            fpsLook.enabled = false;
        }
        else
        {
            Time.timeScale = 1;
            fpsLook.enabled = true;
        }
    }
}
