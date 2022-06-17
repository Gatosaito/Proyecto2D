using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Stadictics : MonoBehaviour
{
    public int Vidas = 3;
    public GameObject[] corazones;

   

    public void UpdateVidas() 
    {

        int VidasNecesarias = 3;

        if (Vidas > 3)
        {
            Vidas = VidasNecesarias;
        }

        for (int i = 0; i < corazones.Length; i++)
        {
            if (i > Vidas - 1)
            {
                corazones[i].GetComponent<Animator>().SetBool("Vidallena", false);
            }
            else
            {
                corazones[i].GetComponent<Animator>().SetBool("Vidallena", true);
            }
        }

    }
}
