using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableCube : MonoBehaviour
{
    public GameObject myCube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            myCube.SetActive(false);
        else if (Input.GetKeyDown(KeyCode.S))
            myCube.SetActive(true);

    }
}
