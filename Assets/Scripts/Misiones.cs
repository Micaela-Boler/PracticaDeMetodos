using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Misiones : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI misionTexto;

    public nventarioDeJugador contadorDeObjeto;



    public void IniciarMision(GameObject Mision, int objetivo)
    {
        Mision.SetActive(true);
        misionTexto.text = "Colecciona " + objetivo.ToString() + " objetos para completar la mision. (Click Derecho para recolectar objetos)";
    }


    public void CompletarMision(int objetivo)
    {
        if (contadorDeObjeto.contarObjetos >= objetivo)
            Debug.Log("Mision completada");
    }


    public void CancelarMision(GameObject Mision)
    {
        Mision.SetActive(false);
        Debug.Log("La mision se cancelo");

        contadorDeObjeto.contarObjetos = 0;
    }

}
