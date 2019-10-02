using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Sensordeldepredador contador;
    public float nturn;
    public Text mejorpresa, mediocrepresa, peorpresa;
    public Text mejorpredator, mediocrepredator, peorpredator;
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
        mejorpresa.text = PlayerPrefs.GetFloat("bestpresa", 8).ToString();
        mediocrepresa.text = PlayerPrefs.GetFloat("presa", 7).ToString();
        peorpresa.text = PlayerPrefs.GetFloat("worstpresa", 6).ToString();
        mejorpredator.text = PlayerPrefs.GetFloat("bestpredator", 6).ToString();
        mediocrepredator.text = PlayerPrefs.GetFloat("predator", 7).ToString();
        peorpredator.text = PlayerPrefs.GetFloat("worstpredator", 8).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        nturn = contador.turn;
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
