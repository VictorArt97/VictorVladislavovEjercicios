using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_3 : MonoBehaviour
{
   
     
    
   
    void Start()
    {
       float resultado =Convertir(3f, "Euro");
       
        Debug.Log("tu conversion es "+ resultado );

    }

    void Update()
    {
        
    }

    float Convertir(float cantidad, string moneda)
    {
        float resultado = -1;

        if(moneda == "Euro")
        {
            resultado =cantidad*1.11f;

        }
        else if(moneda == "Dolar")
        {
            resultado = cantidad * 0.9f;

        }
        return resultado;
        

    }


}
