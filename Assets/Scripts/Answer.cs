using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Answer : MonoBehaviour
{
    public bool isCorrect = false;
    public GameObject[] heart;
    public QuizManager quizManager;
    public GameObject gameOverPanel;
    private int live = 0;

   
    public void _Answer()
    {
        
        if(isCorrect)
        {
            Debug.Log("Doğru");
            quizManager.Correct();
        }
        else
        {
            Debug.Log("Yanlış");
            heart[live].SetActive(false);
            live += 1;
            if(live == 3)
            {
                gameOverPanel.SetActive(true);
            }
            
            
        
        }

    }

}
