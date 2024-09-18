using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Ejercicio5_1 : MonoBehaviour
{
    [SerializeField] int vida1;
    [SerializeField] int vida2;

    void Start()
    {
        if (vida1 == vida2)
        {
            Debug.Log(" La batalla esta reñida , ambos tienen la misma vida ");
        }
        else if (vida1 > vida2) 
        { 
            Debug.Log(" va ganando el jugador 1");
        }
        else if (vida1 < vida2) 
        { 
            Debug.Log(" va ganando el jugador 2");
        }
           
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
