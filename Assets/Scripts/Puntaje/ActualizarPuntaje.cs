using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ActualizarPuntaje : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI puntaje;
    int puntos;


    public void actualizarPuntos(int puntosGanados)
    {
        puntos = puntos + puntosGanados;

        puntaje.text = "Puntaje: " + puntos.ToString();

    }
}
