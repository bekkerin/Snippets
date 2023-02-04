using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallSize : MonoBehaviour
{
    public GameObject playerSphere;
    public Dropdown playerSize;
    private float size = 1.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ChangeSize()
    {
        switch(playerSize.value)
        {
            case 1:
                size = 1.0f;
                break;
            case 2:
                size = 2.0f;
                break;
            case 3:
                size = 3.0f;
                break;
            default:
                size = 1.0f;
                break;
        }

        // scale by the magnification
        playerSphere.transform.localScale = new Vector3(size,size,size);
        // adjust vertical position so ball does not end up in or above the plane
        playerSphere.transform.localPosition = new Vector3(playerSphere.transform.localPosition.x, 0.5f * size, playerSphere.transform.localPosition.z);
    }
}
