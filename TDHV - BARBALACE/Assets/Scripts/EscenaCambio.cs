using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscenaCambio : MonoBehaviour
{
    public void ChangeScene(string SampleScene)
    {
        Debug.Log("Intentando cambiar a la escena: " + SampleScene);
        SceneManager.LoadScene(SampleScene);
    }
}


