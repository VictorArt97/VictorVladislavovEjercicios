using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicios3_3 : MonoBehaviour
{
    [SerializeField] int numero1;
    int numero2; int numero3;   
    void Start()
    {
        numero2 = numero1 * 2; 
        numero3= numero1*3;

        Debug.Log("Numero por 2=  " + numero2);
        Debug.Log("Numero por 3=  " + numero3);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
