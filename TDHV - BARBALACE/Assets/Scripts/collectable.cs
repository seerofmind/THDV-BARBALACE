using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable : MonoBehaviour
{
    private Renderer objectRenderer;
    private Collider objectCollider;
    public int score;
    [SerializeField] private List<GameObject> collectedItems;
    private List<GameObject> gears = new List<GameObject>();
  
    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        objectCollider = GetComponent<Collider>();

    }
    void CollectItem(GameObject item)
    {
        collectedItems.Add(item); // Add the item to the list
        Debug.Log("Collected: " + item.name);
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
            score = score + 1;
            Debug.Log(score);
        }

    }
}


