using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;



public class hidingPlace : MonoBehaviour
{
    public GameObject hideText, stopHideText;
    public GameObject normalPlayer, hidingPlayer;
    public GameObject playerCamera;
    public GameObject hidingCamera;
    // public enemyAI monsterScript;
    // public Transform monsterTransform;
    bool interactable, hiding;
    public float loseDistance;

    void Start()
    {
        interactable = false;
        hiding = false;
        playerCamera.SetActive(true);
        hidingCamera.SetActive(false);
    }
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            hideText.SetActive(true);
            interactable = true;
            
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            hideText.SetActive(false);
            interactable = false;
        }
    }
    void Update()
    {
        if (interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                hideText.SetActive(false);
                hidingPlayer.SetActive(true);
                //float distance = Vector3.Distance(monsterTransform.position, normalPlayer.transform.position);
                //if (distance > loseDistance)
                {
                   // if (monsterScript.chasing == true)
                    {
                        //monsterScript.stopChase();
                    }
                }
                stopHideText.SetActive(true);
                hiding = true;
                normalPlayer.SetActive(false);
                interactable = false;
                playerCamera.SetActive(false);
                hidingCamera.SetActive(true);
            }
        }
        if (hiding == true)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                stopHideText.SetActive(false);
                normalPlayer.SetActive(true);
                hidingPlayer.SetActive(false);
                hiding = false;
                playerCamera.SetActive(true);
                hidingCamera.SetActive(false);
            }
        }
    }
}