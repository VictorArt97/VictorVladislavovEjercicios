using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1_1 : MonoBehaviour
{
    /// Declarar variables 
    int vida;     // el valor por defecto es un 0 
    float porcentajeAcierto;   // el valor por defecto es un 0.0f 
    bool quemado;                 // el valor por defecto es False
    string mensaje,mensaje2,mensaje3;              // el valor por defecto es ""
    char solucionPuzzle;

    void Start()
    {
        mensaje = "Hola Mundo ";
        mensaje2 = "Este es el primer videojuego de victor "; 
        mensaje3 = "Estoy aprendiendo C#"; 
        Debug.Log(mensaje + mensaje2+mensaje3);
      




    }

  
    void Update()
    {
        Debug.Log("Ha pasado un frame");   //se repite por cada frame 
    }
}
