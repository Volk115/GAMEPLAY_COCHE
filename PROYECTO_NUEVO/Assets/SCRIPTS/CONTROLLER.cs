using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CONTROLLER : MonoBehaviour
{
    //velocidad hacia adelante
    private float speed = 15;
    //velocidad hacia los lados (girar/rotar)
    private float turnspeed = 100;

    private float horizontalInput;
    private float verticalInput;

    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //La velocidad del player sera constante hacia adeante (speed es la veloidad)
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        //velocidad lateral
        //transform.Translate(Vector3.right * Time.deltaTime * turnspeed * horizontalInput);

        //Rotacion
        transform.Rotate(Vector3.up, turnspeed * Time.deltaTime * horizontalInput);

    }
}
