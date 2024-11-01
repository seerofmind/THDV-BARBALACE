using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour
{
    public GameObject winText; // Texto que se muestra al ganar
    public GameObject playerCamera; // Referencia a la cámara del jugador
    public GameObject targetGameObject; // El GameObject que se activará/desactivará
    private bool hasCollectable = false; // Booleano para verificar si se tiene el coleccionable

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            winText.SetActive(true);
            // Activar el targetGameObject si se tiene el coleccionable
            if (hasCollectable)
            {
                targetGameObject.SetActive(true);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            winText.SetActive(false);
            targetGameObject.SetActive(false); // Desactiva el targetGameObject al salir
        }
    }
}
