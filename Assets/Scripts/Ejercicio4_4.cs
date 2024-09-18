using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_4 : MonoBehaviour
{
    [SerializeField] float kmPorHora;
    float mPorSeg;

    void Start()
    {
        mPorSeg = kmPorHora * 3.6f;
        Debug.Log(kmPorHora + " Km/h son equivalentes a " + mPorSeg + " m/s");
    }

    
    void Update()
    {
        
    }
}
