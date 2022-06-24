using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawn_monster : MonoBehaviour
{
    public Transform xRangeLeft;
    public Transform xRangeRight;
    public Transform yRangeUp;
    public Transform yRangeDown;

    public GameObject[] Enemys;
    public Enemy_controller velocidad;

    public float time_spawn;
    public float repeat_spawnrate;

    public float Cronometro = 0f;
    private float Curva = 10;
    public float tiempo = 360;

   float cantidad = 0.5f;
    public float velocidadMovimiento;

  


    private void Start()
    {       
        SpawnEnemys(1);        
    }

    private void Update()
    {
        
        Cronometro += Time.deltaTime;

        if (Cronometro >= Curva)
        {
            /*repeat_spawnrate--;
            time_spawn--;*/

            Cronometro = 0;

            
            SpawnEnemys(cantidad);
            cantidad += 0.5f;
            
        }
        tiempo-= 1 * Time.deltaTime;
        if (tiempo == 0)
        {
            WinScene();
        }
    }

    public void SpawnEnemys(float cantidad) 
    {
        Vector3 spawnposition = new Vector3(0, 0, 0);
        velocidadMovimiento += 0.2f;

        for (int i = 0; i < cantidad; i++)
        {
            spawnposition = new Vector3(Random.Range(xRangeLeft.position.x, xRangeRight.position.x), Random.Range(yRangeDown.position.y, yRangeUp.position.y), 0);
            GameObject enemy = Instantiate(Enemys[Random.Range(0, Enemys.Length)], spawnposition, gameObject.transform.rotation);
            enemy.GetComponent<Enemy_controller>().SetSpeedMovment(velocidadMovimiento);

        }

    }

    public void WinScene()
    {
        SceneManager.LoadScene("Win");
    }
}
