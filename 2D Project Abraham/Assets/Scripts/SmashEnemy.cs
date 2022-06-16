using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmashEnemy: MonoBehaviour
{
    private void Start()
    {
        
    }
    public void OnMouseDown()
    {
        gameObject.SetActive(false);
    }
}
