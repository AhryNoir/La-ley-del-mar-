using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sensordeldepredador : MonoBehaviour
{

    public bool Predatorturn, preyturn, gameover;
    public GameObject predator, presa, flecha, predatorender, presarender, lightrender, fondo;
    
    // Vector2 startposition, endposition;
    public float startpositionx, startpositiony, endpositionx, endpositiony, movimiento, contador, turn;
    public GameObject uparrow, downarrow, leftarrow, rightarrow;
    public GameObject startprey, endprey, startpredator, endpredator;
  
    // Start is called before the first frame update
    void Start()
    {
        Predatorturn = false;
        preyturn = false;
        movimiento = 0.75f;
        turn = 0f;
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D visionpredator = Physics2D.Raycast(presa.transform.position, predator.transform.position - presa.transform.position);
        Vector3 recorrido = transform.TransformDirection(predator.transform.position - presa.transform.position);
        Debug.DrawRay(presa.transform.position, recorrido, Color.red);
        RaycastHit2D checkuppresa = Physics2D.Raycast(new Vector2(presa.transform.position.x, presa.transform.position.y + 0.75f), new Vector2(presa.transform.position.x, presa.transform.position.y + 1), 1);
        RaycastHit2D checkdownpresa = Physics2D.Raycast(new Vector2(presa.transform.position.x, presa.transform.position.y - 0.75f), new Vector2(presa.transform.position.x, presa.transform.position.y - 1),-1);
        Vector3 bua = transform.TransformDirection(new Vector2(presa.transform.position.x, presa.transform.position.y - 0.75f) - new Vector2(presa.transform.position.x, presa.transform.position.y - 1));
        Debug.DrawRay(new Vector2(presa.transform.position.x, presa.transform.position.y - 0.75f), bua, Color.red);
        RaycastHit2D checkrightpresa = Physics2D.Raycast(presa.transform.position, new Vector2(presa.transform.position.x + 1, presa.transform.position.y));
        RaycastHit2D checkleftpresa = Physics2D.Raycast(presa.transform.position, new Vector2(presa.transform.position.x - 1, presa.transform.position.y));
        if (preyturn == true)
        {
            presarender.GetComponent<SpriteRenderer>().enabled = true;
            predatorender.GetComponent<SpriteRenderer>().enabled = false;
            lightrender.GetComponent<SpriteRenderer>().enabled = false;

          if (checkdownpresa.collider != null)
                {
                    if (checkdownpresa.collider.tag == "wall")
                    {
                        downarrow.SetActive(false);
                    }else
                    {
                        downarrow.SetActive(true);
                    }
                }
       }
        if(Predatorturn == true)
        {
            presarender.GetComponent<SpriteRenderer>().enabled = false;
            predatorender.GetComponent<SpriteRenderer>().enabled = true;
            lightrender.GetComponent<SpriteRenderer>().enabled = true;

        }
        if(preyturn == false && Predatorturn == false)
        {
            presarender.GetComponent<SpriteRenderer>().enabled = false;
            predatorender.GetComponent<SpriteRenderer>().enabled = false;
            lightrender.GetComponent<SpriteRenderer>().enabled = false;           
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
        turn = turn + 1;

        endprey.SetActive(true);
        startprey.SetActive(false);
        fondo.GetComponent<Image>().enabled = false;
       
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
        fondo.GetComponent<Image>().enabled = true;

    }
    public void predatorready()
    {
        // pulsas ready para empezar el turno del depredador
       // if (Predatorturn == false && preyturn == false)
       // {
            Vector2 margen = new Vector2((startpositionx + endpositionx)/2, (startpositiony + endpositiony)/2);
        contador = 10;
        //Vector3 direccion = transform.TransformDirection(margen - predator.transform.position);
      
            Predatorturn = true;
        Instantiate(flecha, margen, Quaternion.identity);
      
        endpredator.SetActive(true);
        startpredator.SetActive(false);
        fondo.GetComponent<Image>().enabled = false;

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
        fondo.GetComponent<Image>().enabled = true;

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
