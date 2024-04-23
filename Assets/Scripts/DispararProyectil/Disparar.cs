using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public InstanciarBala disparo;
 

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            disparo.DispararProyectil(transform.position, 20);
    }
}
