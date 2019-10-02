﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sensordeldepredador : MonoBehaviour
{
    public bool Predatorturn, preyturn;
    public GameObject predator, presa, flecha;
    // Vector2 startposition, endposition;
    public float startpositionx, startpositiony, endpositionx, endpositiony, movimiento, contador;
    public GameObject startprey, endprey, startpredator, endpredator;
    Quaternion objetivo;
    // Start is called before the first frame update
    void Start()
    {
        Predatorturn = false;
        preyturn = false;
        movimiento = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D vision = Physics2D.Raycast(presa.transform.position, predator.transform.position - presa.transform.position);
        Vector3 recorrido = transform.TransformDirection(predator.transform.position - presa.transform.position);
        Debug.DrawRay(presa.transform.position, recorrido, Color.red);
        if(preyturn == true)
        {
            predator.GetComponent<SpriteRenderer>().enabled = true;
            if (vision.collider != null)
            {
               if(vision.collider.tag == "wall")
                {
                    predator.GetComponent<SpriteRenderer>().enabled = false;
                }
                else
                {
                    predator.GetComponent<SpriteRenderer>().enabled = true;
                }
            }
        }
       


    }
    public void readyprey()
    {
        //pulsas ready y empieza el turno de la presa
        // if (Predatorturn == true && preyturn == true )
        // {
        preyturn = true;
            startpositionx = presa.transform.position.x;
            startpositiony = presa.transform.position.y;
        contador = 7;

        endprey.SetActive(true);
        startprey.SetActive(false);
       
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
        startpredator.SetActive(true);
        endprey.SetActive(false);
      
    }
    public void predatorready()
    {
        // pulsas ready para empezar el turno del depredador
       // if (Predatorturn == false && preyturn == false)
       // {
            Vector2 margen = new Vector2(startpositionx - endpositionx, startpositiony - endpositiony);
        contador = 10;
        //Vector3 direccion = transform.TransformDirection(margen - predator.transform.position);
        objetivo = Quaternion.LookRotation(predator.transform.position, margen);
            Predatorturn = true;
        Instantiate(flecha, predator.transform.position, objetivo);
      //  flecha.transform.rotation = Quaternion.Slerp(transform.rotation, objetivo, 180 * Time.deltaTime);
        endpredator.SetActive(true);
        startpredator.SetActive(false);
       

        // }
    }
    public void predatorok()
    {
        //pulsas ok para finalizar el turno del depredador
        // if (Predatorturn == true && preyturn == false)
        // {
        Predatorturn = false;
        startprey.SetActive(true);
        endpredator.SetActive(false);


        // }
    }
    public void up()
    {

        if (contador > 0)
        {
            if (preyturn == true)
            {
                presa.transform.Translate(new Vector3(0, movimiento, 0));
                contador = contador - 1;
            }
            if (Predatorturn == true)
            {
                predator.transform.Translate(new Vector3(0, movimiento, 0));
                contador = contador - 1;
            }

        }
    }
    public void down()
    {

        if (contador > 0)
        {
            if (preyturn == true)
            {
                presa.transform.Translate(new Vector3(0, -movimiento, 0));
                contador = contador - 1;
            }
            if (Predatorturn == true)
            {
                predator.transform.Translate(new Vector3(0, -movimiento, 0));
                contador = contador - 1;
            }
        }
    }
    public void left()
    {
       
        if (contador > 0)
        {
            if (preyturn == true)
            {
                presa.transform.Translate(new Vector3(-movimiento, 0, 0));
                contador = contador - 1;
            }
            if (Predatorturn == true)
            {
                predator.transform.Translate(new Vector3(-movimiento, 0, 0));
                contador = contador - 1;
            }
        }      
    }
    public void right()
    {
        if (contador > 0)
        {
            if (preyturn == true)
            {
                presa.transform.Translate(new Vector3(movimiento, 0, 0));
                contador = contador - 1;
            }
            if (Predatorturn == true)
            {
                predator.transform.Translate(new Vector3(movimiento, 0, 0));
                contador = contador - 1;
            }

        }
    }  
    
}