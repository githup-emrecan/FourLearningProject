using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LanswerScript : MonoBehaviour
{
 
public bool isCorrect =false;
public LesQuizManager quizmanager;
public Color startcolor;

private void Start() {
    startcolor = GetComponent<Image>().color;
}
public void Answer()
{
    if(isCorrect) {
        GetComponent<Image>().color = Color.green;
        Debug.Log("CorrectAnswers");
    
        quizmanager.correct();
    }
    else{
        GetComponent<Image>().color = Color.red;
        Debug.Log("WrongAnswers");
        quizmanager.Wrong();
    }
}

}
