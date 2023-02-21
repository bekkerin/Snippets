using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this script is attached to the gameplay object
// first create a cylinder in the hierarchy, give it a color and attach the script. Drag it from the hierarchy to the assets to make it a prefab. Finally, delete the cylinder in the hierarchy.
// for the sound, add an audio source in the Start function. In update, play the audio source. In the scene, add an audio source component to the cylinder and set the audioclip to an audioclip in the Assets folder.


public class CreateCylinders : MonoBehaviour
{
    public GameObject newCylinder;
    private AudioSource sources; // ADDED
    
    // Start is called before the first frame update
    void Start()
    {
        sources = GetComponent<AudioSource>(); //ADDED  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // create a new cylinder at center and height of 5. quaternion is for rotation.
            Instantiate(newCylinder, new Vector3(0 ,5,0), Quaternion.identity);
            sources.Play();

        }

    }
}
