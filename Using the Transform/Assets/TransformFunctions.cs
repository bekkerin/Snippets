using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformFunctions : MonoBehaviour
{
    public GameObject myCube;
    public float movement;
    public float rotation;

    // Start is called before the first frame update
    void Start()
    {
        movement = 5f;
        rotation = 50f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
            myCube.transform.Translate(Vector3.left * movement * Time.deltaTime);
        else if (Input.GetKey(KeyCode.RightArrow))
            myCube.transform.Translate(Vector3.right * movement * Time.deltaTime);
        else if (Input.GetKey(KeyCode.UpArrow))
            myCube.transform.Translate(Vector3.up * movement * Time.deltaTime);
        else if (Input.GetKey(KeyCode.DownArrow))
            myCube.transform.Translate(Vector3.down * movement * Time.deltaTime);
        else if (Input.GetKey(KeyCode.Q))
            myCube.transform.Rotate(Vector3.up, rotation * Time.deltaTime);
        else if (Input.GetKey(KeyCode.W))
            myCube.transform.Rotate(Vector3.up, -rotation * Time.deltaTime);
    }
}
