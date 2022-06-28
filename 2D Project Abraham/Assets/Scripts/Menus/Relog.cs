using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Relog : MonoBehaviour
{
    public float initial_time;
    public float time_scale = -1f;

    public TMP_Text my_text;
    private float tiempoDelFrameConTimeScale = 0f;
    private float tiempoAMostrarEnSegundos = 0f;
    private float escalaDeTiempoAlPausar, escalaDeTiempoInicial;
    public bool estaPausado = false;

    private void Start()
    {
        escalaDeTiempoInicial = time_scale;

        my_text = GetComponent<TMP_Text>();

        tiempoAMostrarEnSegundos = initial_time;

        ActualizarRelog(initial_time);
    }

    private void Update()
    {
        if (!estaPausado)
        {
            tiempoDelFrameConTimeScale = Time.deltaTime * time_scale;

            tiempoAMostrarEnSegundos += tiempoDelFrameConTimeScale;
            ActualizarRelog(tiempoAMostrarEnSegundos);
        }
    }

    public void ActualizarRelog(float tiempoEnSegundos)
    {
        int minutos = 0;
        int segundos = 0;
        string textoDelRelog;

        if (tiempoEnSegundos < 0) tiempoEnSegundos = 0;

        minutos = (int)tiempoEnSegundos / 60;
        segundos = (int)tiempoEnSegundos % 60;

        textoDelRelog = minutos.ToString("00") + ":" + segundos.ToString("00");

        my_text.text = textoDelRelog;

        if (minutos <= 0 && segundos <= 0)
        {
            WinScene();
        }

    }

    public void Pausar()
    {
        if (!estaPausado)
        {
            estaPausado = true;

            escalaDeTiempoAlPausar = time_scale;
            time_scale = 0;
        }
    }

    public void Continuar() 
    {
        if (estaPausado)
        {
            estaPausado = false;
            time_scale = escalaDeTiempoAlPausar;
        }
    }
    public void WinScene()
    {
            SceneManager.LoadScene("Win");
    }
}
