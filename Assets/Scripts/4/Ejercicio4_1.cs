using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{
    
    

   
    void Start()
    {
        float resultado = Circulo(3f);
        Debug.Log("Resultado circulo "+resultado);


        float resultado1 =triangulo(4,5);
        Debug.Log("Resultado circulo "+resultado);
        
        float resultado2 =cuadrado(6);
        Debug.Log("Resultado circulo "+resultado);


        
    }

    
    void Update()
    {
        
    }

    float Circulo(float radio)
    {
        float resultado = (radio * radio)*3.14f;
        return resultado;
    }
    
    float triangulo(int vase, int altura)
    {
        float resultado1 = (vase * altura)/2f;
        Debug.Log("Area del triangulo = " + resultado1);
        return resultado1 ;
    }
    
    float cuadrado(int lado)
    {
        int resultado2 = lado*lado ;
        Debug.Log("Area del cuadrado = " + resultado2);
        return resultado2 ;
    }

}
