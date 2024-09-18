using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_2 : MonoBehaviour
{
    [SerializeField] string nombre;
    [SerializeField] string apellido1;
    [SerializeField] string apellido2;
    [SerializeField] int edad ;
    
    void Start()
    {
        ConstruirNombre();


    }

    void Update()
    {
        
    }
    void ConstruirNombre()
    {
        Debug.Log("La persona se llama "+ nombre+" "+apellido1+" "+apellido2+" y tiene "+edad+" años.");

    }
}
