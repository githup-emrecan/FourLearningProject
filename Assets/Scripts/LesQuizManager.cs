using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LesQuizManager : MonoBehaviour
{
  
  public List<LesQuestionAnswer> QandA ;
  public GameObject[] Options;
  public int CurrentQuestion;
  public Text QuestionText;
  
  public GameObject QuizPanel;
  
  public GameObject BGPanell;
  
  public Text Scoretxt;
  public int score;


   private void Start() 
   {

    BGPanell.SetActive(false);
     CreateQuestion();
   }
    
    public void correct()
    {
        score +=1;
        QandA.RemoveAt(CurrentQuestion);
    
        CreateQuestion();
        

    }
    public void Wrong()
    {
        QandA.RemoveAt(CurrentQuestion);
        CreateQuestion();
    }

void Gameover()
  {
     BGPanell.SetActive(true);
     QuizPanel.SetActive(false);
     Scoretxt.text = (score*10).ToString();
  }

public void Retrty()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
}

   void CreateQuestion()
    {
        if(QandA.Count > 0) {
             CurrentQuestion = Random.Range(0,QandA.Count);
      QuestionText.text = QandA[CurrentQuestion].Question;
      SetAnswers();
        }
       else{
        Debug.Log("Out of Questions");
        Gameover();
       }
    
    }

    void SetAnswers()
    {
        for(int i = 0; i < Options.Length; i++) {
            Options[i].GetComponent<LanswerScript>().isCorrect = false;
            Options[i].transform.GetChild(0).GetComponent<Image>().sprite =QandA[CurrentQuestion].Answers[i];

            if(QandA[CurrentQuestion].CorrectAnswers == i+1) {
               Options[i].GetComponent<LanswerScript>().isCorrect = true;
            }
        }
    }
}
