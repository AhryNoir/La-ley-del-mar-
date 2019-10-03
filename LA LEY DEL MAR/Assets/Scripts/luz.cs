using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class luz : MonoBehaviour {
    public float duration = 1.0f;
   

    public float timer;
    
	// Use this for initialization
	void Start () {
      
        
      
        
    }
	
	// Update is called once per frame
	void Update () {

        if (timer >= 2f)
        {
    
            Destroy(this.gameObject);
        }
        float phi = Time.time / duration * 2 * Mathf.PI;
       

       timer += Time.deltaTime;



	}
 

}
