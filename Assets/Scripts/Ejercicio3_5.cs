using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_5 : MonoBehaviour
{
    [SerializeField] float radio;
    float longitud;
    float area;

    
    void Start()
    {
        Debug.Log("longitud = " + longitud);
        Debug.Log("area = " + area);
        longitud = 2f * 3.14159f * radio;
        area = 3.14159f * radio * radio;

        Debug.Log("Longitud de la circunferencia  = " + longitud);
        Debug.Log("Area de la circunferencia = " + area);
        
    }

    

    void Update()
    {
        
    }
}
