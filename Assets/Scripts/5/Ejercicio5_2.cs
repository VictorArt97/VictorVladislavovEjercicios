using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_2 : MonoBehaviour
{
    [SerializeField] int numero1;
    [SerializeField] int numero2;
    void Start()
    {
        if (numero1 < 3 && numero2 < 3)
        {
            Debug.Log(" es menor de 3 :D");
        }
        else
        { 
            Debug.Log(" Me da que uno de los 2 es mayor master : (");
        
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
