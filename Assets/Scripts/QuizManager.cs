using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    [SerializeField] int score;
    [SerializeField] Text scoreText;
   public List<QuestionAndAnswers> QandA;
   public GameObject[] options;
   public int currentQuestion;

   public Text QuestionText;
   public GameObject questionPanel;
   //public GameObject question;
   
   

    private void Start() 
    {
        generateQuestion();
        scoreText.text = score.ToString();
        score = 0;
        
    }

    public void Correct()
    {
        QandA.RemoveAt(currentQuestion);
        //question.SetActive(false);
        questionPanel.SetActive(false);
        generateQuestion();
    }

    

    public void generateQuestion()
    {
        
        currentQuestion = Random.Range(0,QandA.Count);
        QuestionText.text = QandA[currentQuestion].Question;
        setAnswers();
        
        
       
    }

    void setAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<Answer>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Image>().sprite = QandA[currentQuestion].Answers[i];

            if(QandA[currentQuestion].CorrecetAnswer == i+1)
            {
                options[i].GetComponent<Answer>().isCorrect = true;
                
                if(options[i].GetComponent<Answer>().isCorrect == true)
                {
                    score += 5;
                    
                    if(score == 20)
                    {
                        SceneManager.LoadScene("level5");
                    }
                }
                
                

            }
            else
            {
                options[i].GetComponent<Answer>().isCorrect = false;
            }

        }
    }


}
