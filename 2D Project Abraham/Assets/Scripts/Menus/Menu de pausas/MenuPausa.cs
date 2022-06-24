using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public GameObject boton_pausa;
    public GameObject menu_pausa;
    public Relog relog;

    private bool juego_pausado = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (juego_pausado)
            {
                Reanudar();
                relog.estaPausado = false;
            }
            else
            {
                Pause();
                relog.estaPausado = true;
            }
        }
    }

    public void Pause() 
    {
        juego_pausado = true;

        Time.timeScale = 0f;

        

        boton_pausa.SetActive(false);
        menu_pausa.SetActive(true);
    }

    public void Reanudar()
    {
        juego_pausado = false;

        Time.timeScale = 1f;


        boton_pausa.SetActive(true);
        menu_pausa.SetActive(false);
    }

    public void Salir() 
    {
        Application.Quit();
    }
}
