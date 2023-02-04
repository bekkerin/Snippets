using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject playerCapsule;
    public float movement = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() //  runs automatically for the cylinder
    {
        if(playerCapsule.transform.position.x >= 4.0f)
        {
            movement = -movement; // was positive to right, now turns negative to left
        }
        else if (playerCapsule.transform.position.x <= -4.0f)
        {
            movement = -movement; // was negative to left, now turns positive to right
        }
        playerCapsule.transform.Translate(movement * Time.deltaTime * Vector3.right);
    }
}
