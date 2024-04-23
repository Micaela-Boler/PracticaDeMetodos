using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntaje : MonoBehaviour
{ 
    public ActualizarPuntaje actualizarPuntaje;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coleccionable"))
        {
            actualizarPuntaje.actualizarPuntos(2);
            Destroy(other.gameObject);
        }
    }
        

}
