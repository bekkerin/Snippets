using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
    }
}
