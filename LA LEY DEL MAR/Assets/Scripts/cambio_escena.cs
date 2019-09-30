using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambio_escena : MonoBehaviour {

    public Button tutorial, jugar_tuto, jugar_inicio;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void juego() {

        SceneManager.LoadScene("SampleScene");
        jugar_tuto.interactable = false;

    }

    public void juego1()
    {

        SceneManager.LoadScene("SampleScene");
        jugar_inicio.interactable = false;

    }

    public void escenatutorial()
    {

        SceneManager.LoadScene("escena_tutorial");
        tutorial.interactable = false;

    }


}
