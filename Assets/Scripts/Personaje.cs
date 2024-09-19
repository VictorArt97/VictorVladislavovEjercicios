using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    // COMO se define un personale 
    //Propiedades o atributos
    private string nombre;
    private float vida;
    private float altura;
    private float velocidad;

    public string Nombre { get => nombre; set => nombre = value; }    /// puente para poder usar un privado en otro sitio
    public float Vida { get => vida; set => vida = value; }
    public float Altura { get => altura; set => altura = value; }
    public float Velocidad { get => velocidad; set => velocidad = value; }

    // QUE es lo que hace un personaje
    // Funcionalidades 
    public void Atacar()
    {

    }

   public void Mover()
    {

    }

    void Saltar()
    {

    }

        
}
