using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this script is attached to the gameplay object
// first create a cylinder in the hierarchy, give it a color and attach the script. Drag it from the hierarchy to the assets to make it a prefab. Finally, delete the cylinder in the hierarchy.


public class CreateCylinders : MonoBehaviour
{
    public GameObject newCylinder;
    private bool canceled = false;
    
    // Start is called before the first frame update
    void Start()
    {
        // create new cylinders with delay of 2 seconds repeating every 1 second using the SpawnCylinder method
        InvokeRepeating("SpawnCylinder",2,1);
    }

    void SpawnCylinder()
    {
        float x = Random.Range(-4.0f, 4.0f);
        float y = 5.0f; // start at height 5
        float z = Random.Range(-4.0f, 4.0f);
        Instantiate(newCylinder, new Vector3(x, y, z), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!canceled)
            {
                CancelInvoke();
                canceled = true;
            }
            else
            {
                InvokeRepeating("SpawnCylinder", 2, 1);
                canceled = false;
            }

                   
        }

    }
}
