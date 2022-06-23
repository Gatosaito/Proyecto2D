using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void EscenaJuego() 
    {
        SceneManager.LoadScene("Juego");
    }
    public void EscenaCreditos() 
    {
        SceneManager.LoadScene("Creditos");
    }
    public void EscenaOpciones() 
    {
        SceneManager.LoadScene("Opciones");
    }
    public void Irse() 
    {
        Application.Quit();
    }
}
