using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            anim.SetTrigger("MakeRed");
        else if (Input.GetKeyDown(KeyCode.W))
            anim.SetTrigger("MakeWhite");
        else if (Input.GetKeyDown(KeyCode.B))
            anim.SetTrigger("MakeBlack");
        else if (Input.GetKeyDown(KeyCode.G))
            anim.SetTrigger("MakeGreen");
        else if (Input.GetKeyDown(KeyCode.U))
            anim.SetTrigger("MakeBlue");
    }
}
