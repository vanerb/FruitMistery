using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene("Juego");
        PlayerPrefs.DeleteAll();
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Opciones()
    {
        SceneManager.LoadScene("Opciones");
    }

    public void Creditos()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void Salir()
    {
        Application.Quit();
    }
}
