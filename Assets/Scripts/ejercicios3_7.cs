using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicios3_7 : MonoBehaviour
{
   [SerializeField] int vase;
   [SerializeField] int altura;
   int area;

    void Start()
    {
        area = (vase * altura) / 2;

        Debug.Log("el area del cono/triangulo es = " + area);
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
