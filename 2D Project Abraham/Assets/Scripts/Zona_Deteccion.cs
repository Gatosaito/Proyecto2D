using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zona_Deteccion : MonoBehaviour
{
    public Player_Stadictics Player_stadistic;

    private void Start()
    {
        Player_stadistic.UpdateVidas();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemigo")
        {
            other.GetComponentInParent<MobsScore>().score_mobs();
            Player_stadistic.Vidas--;

            if (Player_stadistic.Vidas == 0)
            {
                Debug.Log("Perdiste mamahuevo");
            }
        }
        if (other.tag == "Humano")
        {
            other.GetComponentInParent<MobsScore>().score_mobs();
            Player_stadistic.Vidas++;
        }


        Player_stadistic.UpdateVidas();
    }
}
