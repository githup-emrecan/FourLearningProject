using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;


public class LevelSelection : MonoBehaviour
{
    [SerializeField]
    Button[] levelButtons;

    [SerializeField]
    public GameObject[] lockedImage;

    [SerializeField]
    GameObject[] back;

    [SerializeField]
    GameObject[] next;

    private bool StateBack = false;
    
     int levelat;

    private void Start() 
    {
        //PlayerPrefs.DeleteKey("levelat");
        levelat =PlayerPrefs.GetInt("levelat",2);
        int i;

        int locked = PlayerPrefs.GetInt("locked",2);
        
        //stateBackButton();
        next[0].SetActive(true);
        next[1].SetActive(false);
        next[2].SetActive(false);
        next[3].SetActive(false);
        next[4].SetActive(false);
        
        for(i = 0; i < levelButtons.Length; i++)
        {
            if(i + 2 > levelat && i + 2 > locked)
            {
                levelButtons[i].interactable = false;
                lockedImage[i].SetActive(true);

                if(levelat > 6)
                {
                    nextButton();
                }
                if(levelat > 11)
                {
                    nextButton2();
                }
                 if(levelat > 15)
                {
                    nextButton3();
                }
                  if(levelat > 21)
                {
                    nextButton4();
                }
                  if(levelat > 26)
                {
                    nextButton5();
                }


            }
        }
    
    }


    public void nextButton()
    {
        
        int i,k;
        for(i = 0; i < 5; i++)
        {
            levelButtons[i].GetComponent<RectTransform>().DOScale(0,1).SetEase(Ease.InQuad);
            
        }
        for(k = 5; k < 10; k++)
        {
            levelButtons[k].GetComponent<RectTransform>().DOScale(1,1).SetEase(Ease.InQuad);
        }
        next[0].SetActive(false);
        next[1].SetActive(true);
        back[0].SetActive(true);
        //StateBack = true;
        //stateBackButton();
        
        
    }

    public void nextButton2()
    {
        int i,k;
      
        for(i = 0; i < 10 ; i++)
        {
            levelButtons[i].GetComponent<RectTransform>().DOScale(0,1).SetEase(Ease.InQuad);
        }
        for(k = 10; k < 15; k++)
        {
            levelButtons[k].GetComponent<RectTransform>().DOScale(1,1).SetEase(Ease.InQuad);
        }
        next[0].SetActive(false);
        next[1].SetActive(false);
        next[2].SetActive(true);
        back[0].SetActive(false);
        back[1].SetActive(true);
        //StateBack = true;
        //stateBackButton();
        
        
    }

     public void nextButton3()
    {
        int i,k;
        for(i = 0; i < 15 ; i++)
        {
            levelButtons[i].GetComponent<RectTransform>().DOScale(0,1).SetEase(Ease.InQuad);
        }
        for(k = 15; k < 20; k++)
        {
            levelButtons[k].GetComponent<RectTransform>().DOScale(1,1).SetEase(Ease.InQuad);
        }
        next[2].SetActive(false);
        next[3].SetActive(true);
        back[1].SetActive(false);
        back[2].SetActive(true);
        //StateBack = true;
        //stateBackButton();
        
    }
     public void nextButton4()
    {
        int i,k;
        for(i = 0; i < 20 ; i++)
        {
            levelButtons[i].GetComponent<RectTransform>().DOScale(0,1).SetEase(Ease.InQuad);
        }
        for(k = 20; k < 25; k++)
        {
            levelButtons[k].GetComponent<RectTransform>().DOScale(1,1).SetEase(Ease.InQuad);
        }
        next[3].SetActive(false);
        next[4].SetActive(true);
        back[2].SetActive(false);
        back[3].SetActive(true);
        
        //stateBackButton();
       
    }
   public void nextButton5()
    {
        int i,k;
        for(i = 0; i < 25 ; i++)
        {
            levelButtons[i].GetComponent<RectTransform>().DOScale(0,1).SetEase(Ease.InQuad);
        }
        for(k = 25; k < 30; k++)
        {
            levelButtons[k].GetComponent<RectTransform>().DOScale(1,1).SetEase(Ease.InQuad);
        }
        back[3].SetActive(false);
        back[4].SetActive(true);
        //stateBackButton();
    }
    public void backButton()
    {
        int i,k;
        for(i = 0; i < 5; i++)
        {
            levelButtons[i].GetComponent<RectTransform>().DOScale(1,1).SetEase(Ease.InQuad);
            
        }
        for(k = 5; k < 10; k++)
        {
            levelButtons[k].GetComponent<RectTransform>().DOScale(0,1).SetEase(Ease.InQuad);
        }
        //StateBack = false;
        //stateBackButton();
    }
 public void backButton2()
    {
        int i,k;
        for(i = 5; i < 10 ; i++)
        {
            levelButtons[i].GetComponent<RectTransform>().DOScale(1,1).SetEase(Ease.InQuad);
        }
        for(k = 10; k < 15; k++)
        {
            levelButtons[k].GetComponent<RectTransform>().DOScale(0,1).SetEase(Ease.InQuad);
        }
        //StateBack = false;
        //stateBackButton();
        back[0].SetActive(false);
        back[1].SetActive(true);
       
    }
    public void backButton3()
    {
        int i,k;
        for(i = 10; i < 15 ; i++)
        {
            levelButtons[i].GetComponent<RectTransform>().DOScale(1,1).SetEase(Ease.InQuad);
        }
        for(k = 15; k < 20; k++)
        {
            levelButtons[k].GetComponent<RectTransform>().DOScale(0,1).SetEase(Ease.InQuad);
        }

        
        back[1].SetActive(false);
        back[2].SetActive(true);
        //StateBack = false;
        //stateBackButton();
    }
    public void backButton4()
    {
        int i,k;
        for(i = 15; i < 20 ; i++)
        {
            levelButtons[i].GetComponent<RectTransform>().DOScale(1,1).SetEase(Ease.InQuad);
        }
        for(k = 20; k < 25; k++)
        {
            levelButtons[k].GetComponent<RectTransform>().DOScale(0,1).SetEase(Ease.InQuad);
        }
         back[2].SetActive(false);
        back[3].SetActive(true);
        //StateBack = false;
        //stateBackButton();
    }
    public void backButton5()
    {
        int i,k;
        for(i = 20; i < 25 ; i++)
        {
            levelButtons[i].GetComponent<RectTransform>().DOScale(1,1).SetEase(Ease.InQuad);
        }
        for(k = 25; k < 30; k++)
        {
            levelButtons[k].GetComponent<RectTransform>().DOScale(0,1).SetEase(Ease.InQuad);
        }
        //StateBack = false;
        //stateBackButton();
         back[3].SetActive(false);
        back[4].SetActive(true);
    }
    public void backButton6()
    {
        int i,k;
        for(i = 5; i < 10 ; i++)
        {
            levelButtons[i].GetComponent<RectTransform>().DOScale(1,1).SetEase(Ease.InQuad);
        }
        for(k = 15; k < 20; k++)
        {
            levelButtons[k].GetComponent<RectTransform>().DOScale(0,1).SetEase(Ease.InQuad);
        }
          back[4].SetActive(false);
        back[5].SetActive(true);
        //StateBack = false;
        //stateBackButton();
    }
    public void stateBackButton()
    {
        if(StateBack == true)
        {
            back[0].GetComponent<RectTransform>().DOScale(1,1);
        }
        else
        {
            back[0].GetComponent<RectTransform>().DOScale(0,1);
        }
    }
}
