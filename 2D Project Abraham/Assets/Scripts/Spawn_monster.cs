using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_monster : MonoBehaviour
{
    public Transform xRangeLeft;
    public Transform xRangeRight;
    public Transform yRangeUp;
    public Transform yRangeDown;

    public GameObject[] Enemys;

    public float time_spawn;
    public float repeat_spawnrate = 5;

    private float Cronometro = 0f;
    private float Curva = 180f;

    private void Start()
    {
        InvokeRepeating("SpawnEnemys", time_spawn, repeat_spawnrate);
    }

    private void Update()
    {
        Cronometro += Time.deltaTime;

        if (Cronometro >= Curva)
        {
            repeat_spawnrate--;
            time_spawn--;

            Cronometro = 0;
        }
    }

    public void SpawnEnemys() 
    {
        Vector3 spawnposition = new Vector3(0, 0, 0);

        spawnposition = new Vector3(Random.Range(xRangeLeft.position.x, xRangeRight.position.x), Random.Range(yRangeDown.position.y, yRangeUp.position.y), 0);

        GameObject enemy = Instantiate(Enemys[Random.Range(0, Enemys.Length)], spawnposition, gameObject.transform.rotation);
    }
}
