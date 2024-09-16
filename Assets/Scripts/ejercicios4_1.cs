using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicios4_1 : MonoBehaviour
{
    [SerializeField] int vase;
    [SerializeField] int altura;
    [SerializeField] int radio;
    [SerializeField] int lado;

   
    void Start()
    {
        circulo();
        triangulo();
        cuadrado();

        
    }

    
    void Update()
    {
        
    }

    void circulo()
    {
        float resultado = (radio * radio)*3.14f;
        Debug.Log("Area del circulo = "+resultado);
    }
    
    void triangulo()
    {
        float resultado = (vase * altura)/2f;
        Debug.Log("Area del triangulo = " + resultado);
    }
    
    void cuadrado()
    {
        int resultado = lado*lado ;
        Debug.Log("Area del cuadrado = " + resultado);
    }

}
