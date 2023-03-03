using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this script is attached to the gameplay object
// first create a cylinder in the hierarchy, give it a color and attach the script. Drag it from the hierarchy to the assets to make it a prefab. Finally, delete the cylinder in the hierarchy.


public class CreateCylinders : MonoBehaviour
{
    public GameObject newCylinder;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // create a new cylinder at center and height of 5. quaternion is for rotation.
            Instantiate(newCylinder, new Vector3(0 ,5,0), Quaternion.identity);

        }

    }
}
