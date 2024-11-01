using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; // Importa el espacio de nombres para la gesti�n de escenas

public class WinText : MonoBehaviour
{
    public Collectable[] collectables; // Cambiado a plural
    public TextMeshProUGUI tmpText;
    public int score;
    public GameObject winCube; // Referencia al cubo donde se gana
    public float interactionDistance = 3f; // Distancia para interactuar
    private bool canWin = false; // Si se puede ganar

    void Start()
    {
        if (tmpText == null)
        {
            tmpText = GetComponent<TextMeshProUGUI>();
        }
    }

    void Update()
    {
        // Actualiza el texto de puntuaci�n
        if (tmpText != null && collectables != null)
        {
            tmpText.text = "Keys: " + score + "/" + collectables.Length;
        }

        // Verifica si el jugador est� cerca del cubo, ha recolectado suficientes objetos y ha presionado "E"
        if (canWin && score >= 1 && Input.GetKeyDown(KeyCode.E))
        {
            RestartScene(); // Llama al m�todo para reiniciar la escena
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto es el cubo espec�fico
        if (other.gameObject == winCube)
        {
            canWin = true; // Permitir ganar
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Si el jugador se aleja del cubo, desactivar la posibilidad de ganar
        if (other.gameObject == winCube)
        {
            canWin = false;
        }
    }

    public void CollectItem()
    {
        score++;
        // Aqu� podr�as desactivar o destruir el coleccionable
        if (score >= 1)
        {
            // L�gica adicional si necesitas cuando se recolectan 1 o m�s objetos
        }
    }

    private void RestartScene()
    {
        SceneManager.LoadScene("SampleScene"); // Reinicia la escena llamada "SampleScene"
    }
}