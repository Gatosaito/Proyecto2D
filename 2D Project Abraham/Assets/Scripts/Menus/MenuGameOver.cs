using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGameOver : MonoBehaviour
{
    public void MenuMain() 
    {
       
        SceneManager.LoadScene("Main Menu");

    }

    public void Salir() 
    {

        Application.Quit();

    }
}
