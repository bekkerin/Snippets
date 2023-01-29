using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//this script is attached to the GameManager

public class ValueChange : MonoBehaviour
{
    public Button doubleButton;
    public Button halveButton;
    public Text numberText;
    private float theFloat;
    
    // Start is called before the first frame update
    void Start()
    {
        numberText.text = 100.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Halve()
    {
        float.TryParse(numberText.text,out theFloat);
        theFloat *= 0.5f;
        numberText.text = theFloat.ToString();

    }
    public void Double()
    {
        float.TryParse(numberText.text, out theFloat);
        theFloat *= 2.0f;
        numberText.text = theFloat.ToString();
    }
}
