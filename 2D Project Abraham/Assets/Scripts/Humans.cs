using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Humans : MonoBehaviour
{
    public int vidas_humanos;
    public Player_Stadictics player;
    public Enemy_controller velocidad;
    public Animator Animacion;
    public AudioSource sonido_muerte;

    private void Start()
    {
        player = GameObject.FindObjectOfType<Player_Stadictics>();
        sonido_muerte = GetComponent<AudioSource>();
    }

    public void OnMouseDown()
    {

        vidas_humanos--;

        if (vidas_humanos == 0)
        {
            velocidad.Velocidad_Movimiento = 0;

            
            Animacion.SetBool("IsDeath", true);

            player.Vidas--;
            player.UpdateVidas();   
        }
        
    }


    public void MyMusicOn() 
    {
        sonido_muerte.Play();
    }

    public void MyOnDestroy()
    {
        Destroy(gameObject);
    }
}
