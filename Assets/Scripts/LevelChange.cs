using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using UnityEngine.UI;

public class LevelChange : MonoBehaviour
{
    private void Start() 
    {
        Button b = gameObject.GetComponent<Button>();
        //b.onClick.AddListener(delegate() {this.button();});    
    }
   
    public void levelOne()
    {     
        SceneManager.LoadScene(2);       
    }

    public void levelTwo()
    {
        SceneManager.LoadScene(3);
    }

    public void levelThree()
    {
        SceneManager.LoadScene(4);
    }

    public void levelFour()
    {
        SceneManager.LoadScene(5);
    }

    public void levelFive()
    {
        SceneManager.LoadScene(6);
        
    }
    
    public void levelSix()
    {
        SceneManager.LoadScene(7);
    }

    public void levelSeven()
    {
         SceneManager.LoadScene(8);
    }

    public void levelEight()
    {
         SceneManager.LoadScene(9);
    }

    public void levelNine()
    {
         SceneManager.LoadScene(10);
    }

    public void levelTen()
    {
        Debug.Log("Oyun Bitti");
    }


    
}
