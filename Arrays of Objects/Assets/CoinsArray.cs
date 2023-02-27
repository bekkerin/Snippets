using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsArray : MonoBehaviour
{
    public GameObject[] coins; // have been tagged with "prize"
    public float movement = 5f;

    // Start is called before the first frame update
    void Start()
    {
        // load the array with coins
        coins = GameObject.FindGameObjectsWithTag("prize");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            for (int x = 0; x < coins.Length; x++)
            {

                coins[x].transform.Translate(Vector3.up * movement * Time.deltaTime);
            }
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            for(int x = 0; x < coins.Length; x++)
            {
                coins[x].transform.Translate(Vector3.down * movement * Time.deltaTime);
            }
        }
    }
}
