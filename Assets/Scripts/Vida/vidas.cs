using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vidas : MonoBehaviour
{

    public static int lives = 3;
    public string liveString;

    public Text TextLive;
    public static vidas Vidas;
    
    //setea una clase como estatica
    void awake()
    {
        Vidas = this;
    }

    //Usado como inicializador
    void Start()
    {
    }
    
    //Suma el texto Vidas con el 3,2,1,0
    void Update()
    {
        TextLive.text = liveString + lives.ToString();  
    }

    //suma una vida
    public static void sumar()
    {
        lives += 1;
    }

    //resta las vidas
    public static void restar()
    {
        lives -= 1;
    }

}


