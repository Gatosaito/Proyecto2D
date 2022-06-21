using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Humans : MonoBehaviour
{
    public int vidas_humanos;
    public Player_Stadictics player;


    private void Start()
    {
        player = GameObject.FindObjectOfType<Player_Stadictics>();
    }

    public void OnMouseDown()
    {

        vidas_humanos--;

        if (vidas_humanos == 0)
        {
            Destroy(gameObject);
            player.Vidas--;
            player.UpdateVidas();   
        }
        
    }
}
