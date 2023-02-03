using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableLight : MonoBehaviour
{
    public Camera myCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            myCamera.enabled = false;
        else if (Input.GetKeyDown(KeyCode.W))
            myCamera.enabled = true;
    }
}
