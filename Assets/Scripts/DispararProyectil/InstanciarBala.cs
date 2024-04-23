using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarBala : MonoBehaviour
{
    [SerializeField] GameObject bala;


    public void DispararProyectil(Vector3 posicionInicial, float velocidad)
    {
        GameObject ClonDeBala = Instantiate(bala, posicionInicial, Quaternion.identity);
        Rigidbody bulletRB = ClonDeBala.GetComponent<Rigidbody>();

        bulletRB.AddRelativeForce(transform.forward * velocidad, ForceMode.Impulse);


        Destroy(ClonDeBala, 5f);
    }
}
