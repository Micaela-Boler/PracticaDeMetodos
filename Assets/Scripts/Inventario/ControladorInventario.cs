using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorInventario : MonoBehaviour
{
    [SerializeField] GameObject moneda;
    [SerializeField] int cantidadDeObjetos;

    public nventarioDeJugador inventario;



    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            inventario.AgregarObjetos(moneda, cantidadDeObjetos);

        else if (Input.GetMouseButtonDown(1))
            inventario.QuitarObjeto(moneda, cantidadDeObjetos);
    }
}
