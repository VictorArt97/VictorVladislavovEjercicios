using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_5 : MonoBehaviour
{
    



    void Start()
    {
        float resultado = Circulo(7f);
        float resultadoFinal = Convertir(resultado,"Euro");


        
    }

    
    void Update()
    {
        
    }
    float Circulo(float radio)
    {
        float resultado = (radio * radio) * 3.14f;
        return resultado;
    }

    float Convertir(float cantidad, string moneda)
    {
        float resultadoFinal = -1;

        if (moneda == "Euro")
        {
            resultadoFinal = cantidad * 1.11f;

        }
        else if (moneda == "Dolar")
        {
            resultadoFinal = cantidad * 0.9f;

        }
        return resultadoFinal;


    }
}
