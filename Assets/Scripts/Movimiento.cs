using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [Header("Ejes de movimientos")]
    private float horizontalInput;
    private float verticalInput;
    private Vector3 vectorMovement;

    [Header("Velocidad de movimiento")]
    public float speed;


    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        vectorMovement = new Vector3(horizontalInput, 0f, verticalInput);

        vectorMovement.Normalize();

        transform.Translate(vectorMovement * Time.deltaTime * speed);
    }

}
