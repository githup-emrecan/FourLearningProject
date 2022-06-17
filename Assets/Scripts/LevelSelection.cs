using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class LevelSelection : MonoBehaviour
{
    [SerializeField]
    Button[] levelButtons;

    [SerializeField]
    public GameObject[] lockedImage;

    [SerializeField]
    Button back;

    private bool StateBack = false;
    

    private void Start() 
    {
       // PlayerPrefs.DeleteKey("levelat");
        int levelat =PlayerPrefs.GetInt("levelat",2);
        int i;

        int locked = PlayerPrefs.GetInt("locked",2);
        
        stateBackButton();
        
        for(i = 0; i < levelButtons.Length; i++)
        {
            if(i + 2 > levelat && i + 2 > locked)
            {
                levelButtons[i].interactable = false;
                lockedImage[i].SetActive(true);

                if(levelat > 6 )
                {
                    nextButton();
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
        
        StateBack = true;
        stateBackButton();
        
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
        StateBack = false;
        stateBackButton();
    }

    public void stateBackButton()
    {
        if(StateBack == true)
        {
            back.GetComponent<RectTransform>().DOScale(1,1);
        }
        else
        {
            back.GetComponent<RectTransform>().DOScale(0,1);
        }
    }
}
