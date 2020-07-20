using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class UIManager : MonoBehaviour {

    public GameObject Menu;
    public GameObject SettingsPanel;

    private Animator menuAnim;
    private Animator settingsPanelAnim;

    private void Awake() {
        menuAnim = Menu.GetComponent<Animator>();
        settingsPanelAnim = SettingsPanel.GetComponent<Animator>();
    }

    //sacar el menu principal y traer menu de opciones
    public void Settings() {
        SettingsPanel.SetActive(true);
        menuAnim.SetBool("Close", true);    // parametros para activar las animaciones
        settingsPanelAnim.SetBool("Open", true);
    }
    //carga el primer nivel
    public void PlayScene() {
        SceneManager.LoadScene("Escenario");
        vidas.lives = 3;
    }

    //cierra el juego
    public void QuitGame() {
        Application.Quit();
    }

    //vuelve al menu principal
    public void Volver() {
        SceneManager.LoadScene("Menu");
    }

    //Si apreta escape vuelve al menu principal
    public void Update() {        
        if(Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
