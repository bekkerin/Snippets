using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            GetComponent<Renderer>().material.color = Color.gray;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            GetComponent<Renderer>().material.color = Color.black;
        }
        else if(Input.GetKeyDown(KeyCode.D))
        {
            GetComponent<Renderer>().material.color = Color.cyan;
        }
    }
}
