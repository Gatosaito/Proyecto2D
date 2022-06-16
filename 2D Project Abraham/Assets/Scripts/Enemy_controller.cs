using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_controller : MonoBehaviour
{
    public float Velocidad_Movimiento;
    public Transform[] Puntos_Movimiento;
    public float Distancia_Minima;

    private int Siguiente_Paso = 0;

    public SpriteRenderer spriterenderer;

    private void Start()
    {
        spriterenderer = GetComponent<SpriteRenderer>();
        Girar();
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Puntos_Movimiento[Siguiente_Paso].position, Velocidad_Movimiento * Time.deltaTime);

        if (Vector2.Distance(transform.position, Puntos_Movimiento[Siguiente_Paso].position) < Distancia_Minima)
        {
            Siguiente_Paso += 1;
            if (Siguiente_Paso >= Puntos_Movimiento.Length)
            {
                Girar();
                Destroy(gameObject);
            }
        }
    }

    private void Girar() 
    {
        if (transform.position.x < Puntos_Movimiento[Siguiente_Paso].position.x)
        {
            spriterenderer.flipX = true;
        }
        else
        {
            spriterenderer.flipX = false;
        }
    }
}
