using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flechacontroller : MonoBehaviour
{
    public float timer;
    Quaternion rotacion;
    // Start is called before the first frame update
    void Start()
    {

      //  transform.RotateAroundLocal(, 180);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 2f)
        {
            Destroy(this.gameObject);
        }
    }
}
