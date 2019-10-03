using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Sensordeldepredador contador;
    public NewBehaviourScript finish;
    public float nturn;
   
    public float lapresa, unapresa, victima;
    public float eldepredador, undepredador, pardillo;
    // Start is called before the first frame update
    void Start()
    {

        lapresa = 8;
        unapresa = 7;
        victima = 6;
        eldepredador = 6;
        undepredador = 7;
        pardillo = 8;
       
    }

    // Update is called once per frame
    void Update()
    {
        nturn = contador.turn;
        if(finish.gameover == true)
        {   
        if(nturn >= lapresa)
        {
            lapresa = nturn;
            PlayerPrefs.SetFloat("bestpresa", lapresa);
        }
        if(nturn < lapresa && nturn >= unapresa)
        {
            unapresa = nturn;
            PlayerPrefs.SetFloat("presa", unapresa);
        }
        if(nturn < unapresa && nturn >= victima)
        {
            victima = nturn;
            PlayerPrefs.SetFloat("worstpresa", victima);
        }
        if(nturn <= eldepredador)
        {
            eldepredador = nturn;
            PlayerPrefs.SetFloat("bestpredator", eldepredador);
        }
        if(nturn > eldepredador && nturn <= undepredador)
        {
            undepredador = nturn;
            PlayerPrefs.SetFloat("predator", undepredador);
        }
        if(nturn > undepredador && nturn <= pardillo)
        {
            pardillo = nturn;
            PlayerPrefs.SetFloat("worstpredator", pardillo);
        }
        }

    }
}
