using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable : MonoBehaviour
{
    private Renderer objectRenderer;
    private Collider objectCollider;
    public int score;

    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        objectCollider = GetComponent<Collider>();

    }
    void SetInvisibleAndDisableCollision()
    {
        if (objectRenderer != null)
        {
            objectRenderer.enabled = false; // Make the object invisible
        }

        if (objectCollider != null)
        {
            objectCollider.enabled = false; // Disable collisions
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SetInvisibleAndDisableCollision();
            score = score + 10;
            Debug.Log(score);
        }
    }




}
