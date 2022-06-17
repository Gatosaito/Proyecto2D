using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_controller : MonoBehaviour
{
    public float Velocidad_Movimiento;
    public Transform[] Puntos_Movimiento;
    public Transform[] Puntos_Movimiento2;
    public float Distancia_Minima;

    private int Siguiente_Paso = 0;

    private int numero_aleatorio;

    public SpriteRenderer spriterenderer;

    private void Start()
    {
        

        numero_aleatorio = Random.Range(1, 3);

        spriterenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        

        if (numero_aleatorio == 1)
        {

            transform.position = Vector2.MoveTowards(transform.position, Puntos_Movimiento[Siguiente_Paso].position, Velocidad_Movimiento * Time.deltaTime);

            if (Vector2.Distance(transform.position, Puntos_Movimiento[Siguiente_Paso].position) < Distancia_Minima)
            {
                Siguiente_Paso += 1;
            }
        }
        else
        {

            transform.position = Vector2.MoveTowards(transform.position, Puntos_Movimiento2[Siguiente_Paso].position, Velocidad_Movimiento * Time.deltaTime);

            if (Vector2.Distance(transform.position, Puntos_Movimiento2[Siguiente_Paso].position) < Distancia_Minima)
            {
                Siguiente_Paso += 1;
            }
        }

    }

    /* private void Girar() 
     {
         if (transform.position.x < Puntos_Movimiento[Siguiente_Paso].position.x)
         {
             spriterenderer.flipX = true;
         }
         else
         {
             spriterenderer.flipX = false;
         }


                 if (Siguiente_Paso >= Puntos_Movimiento.Length)
                 {
                     Destroy(gameObject);
                 }


     }*/
}
