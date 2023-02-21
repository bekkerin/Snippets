using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this script is attached to the cylinder 

public class Lifetime : MonoBehaviour
{
    public GameObject cylinder;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            Destroy(cylinder);
        }

    }
}
