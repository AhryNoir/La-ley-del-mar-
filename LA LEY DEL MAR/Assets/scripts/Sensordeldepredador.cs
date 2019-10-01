using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sensordeldepredador : MonoBehaviour
{
    public bool Predatorturn, preyturn;
    public GameObject predator, presa, flecha;
    // Vector2 startposition, endposition;
    public float startpositionx, startpositiony, endpositionx, endpositiony, movimiento, contador;
    // Start is called before the first frame update
    void Start()
    {
        Predatorturn = true;
        preyturn = false;
        movimiento = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void readyprey()
    {
        //pulsas ready y empieza el turno de la presa
        // if (Predatorturn == true && preyturn == true )
        // {
        preyturn = true;
        contador = 7;
            startpositionx = presa.transform.position.x;
            startpositiony = presa.transform.position.y;
       // }
    }
    public void okprey()
    {
        //pulsas ok para finalizar el turno de la presa
       // if (Predatorturn == false && preyturn == true)
       // {
            preyturn = false;
            endpositionx = presa.transform.position.x;
            endpositiony = presa.transform.position.y;
       // }
    }
    public void predatorready()
    {
        // pulsas ready para empezar el turno del depredador
       // if (Predatorturn == false && preyturn == false)
       // {
            Vector2 margen = new Vector2(startpositionx - endpositionx, startpositiony - endpositiony);
        contador = 10;
            Predatorturn = true;
            Instantiate(flecha, predator.transform.position, Quaternion.LookRotation(margen, predator.transform.position));
       // }
    }
    public void predatorok()
    {
        //pulsas ok para finalizar el turno del depredador
       // if (Predatorturn == true && preyturn == false)
       // {
            Predatorturn = false;
       // }
    }
    public void up()
    {
        presa.transform.Translate(new Vector3(0, movimiento, 0));
        contador = contador - 1;
    }
    public void down()
    {
        presa.transform.Translate(new Vector3(0, -movimiento, 0));
        contador = contador - 1;
    }
    public void left()
    {
        presa.transform.Translate(new Vector3(-movimiento, 0, 0));
        contador = contador - 1;
    }
    public void right()
    {
        presa.transform.Translate(new Vector3(movimiento, 0, 0));
        contador = contador - 1;
    }
}
