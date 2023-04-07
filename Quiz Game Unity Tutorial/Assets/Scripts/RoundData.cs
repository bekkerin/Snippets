using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] // so we can edit them and displey the values in the Unity Inspector
public class RoundData  //NOT A MONOBEHAVIOR, JUST A CLASS HOLDING DATA
{
    public string name; // name of the round
    public int timeLimitInSeconds;
    public int pointsAddedForCorrectAnswer;
    public QuestionData[] questions; // array of question and answers data
}
