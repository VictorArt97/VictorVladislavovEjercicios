using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio2_2 : MonoBehaviour
{
    int vida=5;
    float exp = 10f;
    float resultadoSuma,resultadoResta;
    char carac='A';


    void Start()
    {
        Debug.Log("Vida = " + vida + " de vida");
        Debug.Log("Exp = " + exp + " de exp");

        resultadoSuma = vida + exp;
        resultadoResta = exp - vida;

        Debug.Log("resultado suma = "+resultadoSuma);
        Debug.Log("resultado resta = "+resultadoResta);

    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
}
