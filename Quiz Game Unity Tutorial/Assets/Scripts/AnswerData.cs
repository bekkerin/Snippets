using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] // so we can edit them and displey the values in the Unity Inspector
public class AnswerData //NOT A MONOBEHAVIOR, JUST A CLASS HOLDING DATA
{
    public string answerText;
    public bool isCorrect; // whether or not this answer for this question is correct
}
