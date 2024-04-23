using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nventarioDeJugador : MonoBehaviour
{
    [SerializeField] List<GameObject> objetos;
    public int contarObjetos;


    public void AgregarObjetos(GameObject objeto, int cantidad)
    {
        for (int i = 0; i < cantidad; i++)
        {
            objetos.Add(objeto);
            Debug.Log("Se agregaron " + cantidad + " objetos al inventario");
        }

        contarObjetos = objetos.Count;
    }


    public void QuitarObjeto(GameObject objeto, int cantidad)
    {
        for (int i = 0; i < cantidad; i++)
        {
            objetos.Remove(objeto);
            Debug.Log("Se eliminaron " + cantidad + " objetos del inventario");
        }

        contarObjetos = objetos.Count;
    }
}
