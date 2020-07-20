using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour {

    public static int score=0;  //variable estatica del puntaje para que en todas las clases el valor sea el mismo
    public string ScoreString;  //variable para asignar el texto que se muestra en pantalla

    public Text TextScore;  //variable de tipo Text para insertarle el texto que se muestra en pantalla del juego
    public static Puntaje puntaje;  //la clase se hace publica y estática para poder acceder a ella desde otra clase

    void Awake() {
        puntaje = this;
    }

    //Usado como inicializador
	void Start () {
	}

	//Al texto que se muestra en pantalla se le suma el nombre y el puntaje (modificado por el script de moneda)
	void Update ()
    {
        TextScore.text = ScoreString + score.ToString();
    }

}
