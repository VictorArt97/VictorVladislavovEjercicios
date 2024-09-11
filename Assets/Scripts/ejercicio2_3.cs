using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio2_3 : MonoBehaviour
{
    int vida = 5;
    float exp = 10;
    float resultadoMultiplicar, resultadoDivision, duplicacion, triplicacion;
    void Start()
    {
        resultadoMultiplicar = vida * exp;
        resultadoDivision = vida/exp;
        duplicacion = vida*2;
        triplicacion = exp*3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
