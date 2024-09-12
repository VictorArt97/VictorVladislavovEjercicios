using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio2_6 : MonoBehaviour
{
    int puntos1 =3;
    int puntos2 =4;
    int puntos3 =5;
    void Start()
    {
        Debug.Log("Puntos1 = "+puntos1+"  Puntos2 = "+puntos2+"   Puntos3 = "+puntos3);
        Debug.Log("su media es = " + (puntos1+puntos2+puntos3)/3);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
