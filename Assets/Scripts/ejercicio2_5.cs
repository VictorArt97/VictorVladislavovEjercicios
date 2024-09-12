using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio2_5 : MonoBehaviour
{
    int vidasPlayer1=5;
    int vidasPlayer2=10;
    int vidasPlayer2Respaldo=10;
    int vidasPlayer3=12;
    int vidasPlayer4 = 14;
    void Start()
    {
       vidasPlayer2 = vidasPlayer3;
        Debug.Log("Ahora el player 2 tiene: " + vidasPlayer2);

       Debug.Log(vidasPlayer3 = vidasPlayer1);
       Debug.Log(vidasPlayer1 = vidasPlayer4);
       Debug.Log(vidasPlayer4 = vidasPlayer2Respaldo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
