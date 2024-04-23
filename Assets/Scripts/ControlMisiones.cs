using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMisiones : MonoBehaviour
{

    [SerializeField] GameObject mision;

    public Misiones misiones;

    int objetivo = 6;



    void Start()
    {
        mision.SetActive(false);
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
            misiones.IniciarMision(mision, objetivo);

        if (Input.GetKeyDown(KeyCode.Escape)) 
        misiones.CancelarMision(mision); 


        misiones.CompletarMision(objetivo);
    }
}
