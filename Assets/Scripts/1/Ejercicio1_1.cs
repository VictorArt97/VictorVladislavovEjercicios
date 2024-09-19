using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1_1 : MonoBehaviour
{
    /// Declarar variables 
    [SerializeField]int vida;     // el SerializeField 
    float porcentajeAcierto;   // el valor por defecto es un 0.0f 
    bool quemado;                 // el valor por defecto es False
    string mensaje,mensaje2,mensaje3;              // el valor por defecto es ""
    char solucionPuzzle;
   

    [SerializeField] bool carnetConducir;

    void Start()
    {
        //mensaje = "Hola Mundo ";
        //mensaje2 = "Este es el primer videojuego de victor "; 
        //mensaje3 = "Estoy aprendiendo C#"; 
        //Debug.Log(mensaje + mensaje2+mensaje3);
        //int resultadoRecogido =SumarDosNumeros(8, 2);   // asignale los numeros que vaya a sumar
        // HacerSupernena(2.4f, 4, "freddy fastbear", 3);


        // meter una estructura dentro de otra 
        //if(carnetConducir ==true)   //si se cumple la condicion se ejecuta el codigo  / se pone && para que se cumplan 2 al mismo tiempo 
        //{
        //    Debug.Log(" Puedes conducir porque tienes el carnet ");   // && tiene mas prioridad que el ||


        //}
        //else
        //{
        //    Debug.Log(" te jodes y bailas ");
        //}



        // Bucle infinito 
        // Bucle indeterminado---> no esta pensado para contar

        while (vida > 0) // bulce
        {
            Debug.Log(" Sigo vivo :D ");


        }

        // PARA desde i =0 , hasta i = 15 , de 1 en 1 
        for (int i = 0; i < 15; i++)
        {


        }

        //void Update()
        //{
        //   // Debug.Log("Ha pasado un frame");   //se repite por cada frame 

        //}

        //int SumarDosNumeros(int numero1 , int numero2)        // poniendo int en vez de void logras poder sacar datos de aqui
        //{
        //    int resultado = numero1 + numero2;
        //    return resultado;      // importante poner return para que funcione

        //}  


        ////void HacerSupernena(float asucar, int especias, string nombre, int flores)   // plantilla que funciona pero no tiene datos asociados
        ////{
        ////}




        //void restarDosNumeros()
        //{

        //}
        //void Atacar()
        //{

        //}

    }
}
