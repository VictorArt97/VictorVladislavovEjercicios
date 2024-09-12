using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicios2_8 : MonoBehaviour
{
    int puntosDeVida = 120;
    void Start()
    {
       puntosDeVida *= 3 / 100;
        Debug.Log("Tu vida se ha reducido a "+ puntosDeVida);
       puntosDeVida *= 6 / 100;
        Debug.Log("Tu vida se ha reducido a "+ puntosDeVida);
       puntosDeVida *= 9 / 100;
        Debug.Log("Tu vida se ha reducido a "+ puntosDeVida);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
