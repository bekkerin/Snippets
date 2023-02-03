using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    // the capsule has a rigidbody so we can add force and a collider so it can detect mouse clicks
    // the script is attached to the cylinder.

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        GetComponent<Rigidbody>().AddForce(transform.right * 400f);
    }
}
