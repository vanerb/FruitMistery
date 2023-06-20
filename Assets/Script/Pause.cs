using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

    private bool isPaused = false;
    public GameObject pauseM;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
        isPaused = false;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    void PauseGame()
    {
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0f; // Pausa el tiempo en el juego
        isPaused = true;
        // Aqu� puedes realizar otras acciones de pausa, como mostrar un men� de pausa, desactivar controles, etc.
        pauseM.SetActive(true);
    }

    void ResumeGame()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f; // Reanuda el tiempo en el juego
        isPaused = false;
        // Aqu� puedes realizar otras acciones de reanudaci�n, como ocultar el men� de pausa, activar controles, etc.
        pauseM.SetActive(false);
    }
}
