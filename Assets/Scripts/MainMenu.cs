using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject settingsPanel;
    [SerializeField]
    private GameObject AccountPanel;

   
    public void playButton()
    {
        SceneManager.LoadScene("Character");
        
    }

    public void settingsButton()
    {
        settingsPanel.GetComponent<RectTransform>().DOScale(1,0.5f).SetEase(Ease.InQuad);
     
    }

    public void quitSettingsPanel()
    {
        settingsPanel.GetComponent<RectTransform>().DOScale(0,0.5f).SetEase(Ease.OutQuad);
    }
    
    public void AccountButton()
    {
       settingsPanel.GetComponent<RectTransform>().DOScale(0,1f);
       AccountPanel.GetComponent<RectTransform>().DOScale(1,1f);
    }

    public void quitAccountsPanel()
    {
        AccountPanel.GetComponent<RectTransform>().DOScale(0,1f);
        settingsPanel.GetComponent<RectTransform>().DOScale(1,1f);

    }

    public void quitButton()
    {
        Application.Quit();
    }
}
