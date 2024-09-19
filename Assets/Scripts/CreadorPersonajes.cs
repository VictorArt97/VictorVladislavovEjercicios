using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreadorPersonajes : MonoBehaviour
{
    Personaje link;
    [SerializeField]Personaje Mario;       // para poder editarlo y asignarle un script / mas especifico que usar el GameObject
    
    void Start()
    {
        link.Nombre = "Me llamo zelda lol";   /// Los datos solo se le asignan a link
        link.Mover();     /// los datos solo se le asignan a Link
        
    }


}
