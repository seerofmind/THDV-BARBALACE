using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class scoreText : MonoBehaviour
{
    public collectable collectable;
    public TMP_Text tmpText;
    // Start is called before the first frame update
    void Start()
    {
        if (collectable != null)
        {
            Debug.Log("Value from OtherScript: " + collectable.score);
        }
        //tmpText = GetComponent<TMP_Text>();
        if (tmpText != null)
        {
            tmpText.enabled = true; // Make the object invisible
        }
    }

    // Update is called once per frame
    void Update()
    {
        tmpText.text = "Score: " + collectable.score + "/50";
    }
}
