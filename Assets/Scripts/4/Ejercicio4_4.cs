using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_4 : MonoBehaviour
{
   
    

    void Start()
    {
        float mPorSeg = Calculador(4);
        Debug.Log(" Tu conversión es equivalentes a " + mPorSeg + " m/s");
    }

    
    void Update()
    {
        
    }

    float Calculador(float kmPorHora)
    {
        float mPorSeg = kmPorHora * 3.6f;
        return mPorSeg;
    }
}
