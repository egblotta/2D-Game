using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemigoController : MonoBehaviour {

    private SpriteRenderer enemigoRender;   //Se crea un SpriteRenderer para manipular el sprite del personaje

    public float velocidad = 3;    //velocidad a la que se mueve el sprite
    public bool mirandoDerecha;   //verifica si se mueve a la derecha
    public int limiteIzquierdo;
    public int limiteDerecho; 
    

    void Start()
    {
        mirandoDerecha = true;
    }

    void Update()
    {
        // movimiento automatico del enemigo
        if (transform.position.x > limiteDerecho && mirandoDerecha)
            Flip();
            
        if (transform.position.x < limiteIzquierdo && !mirandoDerecha)
            Flip(); 

        if(mirandoDerecha)
            transform.position = new Vector2(transform.position.x + velocidad * Time.deltaTime, transform.position.y);
        
        else       
            transform.position = new Vector2(transform.position.x - velocidad * Time.deltaTime, transform.position.y);
    }

    //gira el sprite
    public void Flip()
    {
        var s = transform.localScale;
        s.x *= -1;
        transform.localScale = s;
        mirandoDerecha = !mirandoDerecha;
    }

}
