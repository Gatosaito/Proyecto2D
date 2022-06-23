using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmashEnemy: MonoBehaviour
{
    public int vidas_enemigo;
    public Animator Animacion;
    public Enemy_controller velocidad;
    public AudioSource sonido_muerte;

    IEnumerator cambioColor;
    public Color normalColor;  //Color blanco
    public Color damageColor;  //Color rojo

    float lastTimeEffect;
    public float timeEffect;

    public SpriteRenderer mySprite;


    private void Start()
    {
        mySprite = GetComponent<SpriteRenderer>();
        sonido_muerte = GetComponent<AudioSource>();
    }

    public void OnMouseDown()
    {
        vidas_enemigo--;
        OnStartChangeColor();

        if (vidas_enemigo == 0)
        {
            velocidad.Velocidad_Movimiento = 0;

            Animacion.SetBool("IsDeath", true);
        }
        
    }
    public void MyEnemyMusicOn()
    {
        sonido_muerte.Play();
    }

    private void OnStartChangeColor()
    {
        if (cambioColor != null)
        {
            StopCoroutine(cambioColor);
        }
        cambioColor = OnChangeColor();
        StartCoroutine(cambioColor);
    }

    IEnumerator OnChangeColor()
    {
        lastTimeEffect = timeEffect;

        while (lastTimeEffect >= 0)
        {
            lastTimeEffect -= Time.deltaTime;

            if (lastTimeEffect % .2f < .1f)
            {
                mySprite.color = damageColor;
            }
            else
            {
                mySprite.color = normalColor;
            }
            yield return new WaitForEndOfFrame();
        }
        mySprite.color = normalColor;
    }
}
