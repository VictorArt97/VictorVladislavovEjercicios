using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicios4_3 : MonoBehaviour
{
    [SerializeField] float cantidad;
    [SerializeField] string tipo;
    float resultado;
   
    void Start()
    {
        if (tipo == "euro")
        {
            resultado = cantidad * 0.9f;
        }
    }

    void Update()
    {
        
    }

    
}
