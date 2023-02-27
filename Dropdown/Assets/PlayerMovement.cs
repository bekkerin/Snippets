// this script is attached to the GameManager

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject PlayerCapsule;
    private float movement = 2.0f; // base speed

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update() //  runs automatically for the cylinder
    {
        if (PlayerCapsule.transform.position.x >= 4.0f) // rightmost of plane is 4.0
        {
            movement = -movement; // was positive to right, now turns negative to left
        }
        else if (PlayerCapsule.transform.position.x <= -4.0f) // left most of plane is -4.0
        {
            movement = -movement; // was negative to left, now turns positive to right
        }
        PlayerCapsule.transform.Translate(SpeedSelect.speed * movement * Time.deltaTime * Vector3.right);
    }
}
