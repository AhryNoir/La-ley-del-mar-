using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorerecap : MonoBehaviour
{
    public Text mejorpresa, mediocrepresa, peorpresa;
    public Text mejorpredator, mediocrepredator, peorpredator;
    // Start is called before the first frame update
    void Start()
    {
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
        
    }
}
