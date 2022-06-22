using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmashEnemy: MonoBehaviour
{
    public int vidas_enemigo;
    public Animator Animacion;
    public Enemy_controller velocidad;

    public void OnMouseDown()
    {
        vidas_enemigo--;

        if (vidas_enemigo == 0)
        {
            velocidad.Velocidad_Movimiento = 0;

            Animacion.SetBool("IsDeath", true);
        }
        
    }
}
