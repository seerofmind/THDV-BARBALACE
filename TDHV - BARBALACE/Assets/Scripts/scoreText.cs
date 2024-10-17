using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class scoreText : MonoBehaviour
{
    
    public TMP_Text tmpText;
    // Start is called before the first frame update
public int score;
    void Start()
    {
       
        //tmpText = GetComponent<TMP_Text>();
        if (tmpText != null)
        {
            tmpText.enabled = true; // Make the object invisible
        }
    }

    // Update is called once per frame
    void Update()
    {
        tmpText.text = "Keys: " + score + "/1";
    }
}
