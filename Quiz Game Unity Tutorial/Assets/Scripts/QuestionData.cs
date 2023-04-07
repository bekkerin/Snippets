using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]  // so we can edit them and displey the values in the Unity Inspector
public class QuestionData  //NOT A MONOBEHAVIOR, JUST A CLASS HOLDING DATA
{
    public string questionText;
    public AnswerData[] answers; // array of answers for the question
}
