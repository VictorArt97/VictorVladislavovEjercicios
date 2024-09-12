using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio2_4 : MonoBehaviour
{
    int vidas= 4;
    void Start()
    {
        vidas += 77;
        Debug.Log(vidas);
        vidas /= 3;
        Debug.Log(vidas);
        vidas *= 4;
        Debug.Log(vidas);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
