using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambio_escena : MonoBehaviour {

    public Button tutorial, jugar_tuto, jugar_inicio, inicio_m, replay_m, replay_v, inicio_v, tutorial_m, tutorial_v;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void juego() {

        SceneManager.LoadScene("campo de pruebas");
        jugar_tuto.interactable = false;

    }

    public void juego1()
    {

        SceneManager.LoadScene("campo de pruebas");
        jugar_inicio.interactable = false;

    }

    public void escenatutorial()
    {

        SceneManager.LoadScene("escena_tutorial");
        tutorial.interactable = false;

    }

    public void juego_muerte()
    {

        SceneManager.LoadScene("campo de pruebas");
        replay_m.interactable = false;

    }

    public void juego_victoria()
    {

        SceneManager.LoadScene("campo de pruebas");
        replay_v.interactable = false;

    }

    public void inicio_muerte()
    {

        SceneManager.LoadScene("logo_inicio");
        inicio_m.interactable = false;

    }
    public void inicio_victoria()
    {

        SceneManager.LoadScene("logo_inicio");
        inicio_v.interactable = false;

    }
    public void escenatutorial_m()
    {

        SceneManager.LoadScene("escena_tutorial");
        tutorial.interactable = false;

    }
    public void escenatutorial_v()
    {

        SceneManager.LoadScene("escena_tutorial");
        tutorial.interactable = false;

    }



}
