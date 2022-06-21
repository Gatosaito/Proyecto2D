using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmashEnemy: MonoBehaviour
{
    public int vidas_enemigo;

    public void OnMouseDown()
    {
        vidas_enemigo--;

        if (vidas_enemigo == 0)
        {
            Destroy(gameObject);
        }
        
    }
}
