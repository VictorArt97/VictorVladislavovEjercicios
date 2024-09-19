using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_4 : MonoBehaviour
{
    [SerializeField] int EXP;
    int LVL;
    void Start()
    {
        LVL = 32 + (9* EXP/5);
        Debug.Log(" Tu nivel segun la experiencia es = " + LVL);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
