using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] fruits;
    public float xBounds,yBound;

    public  int score;
    public Text scoreText;
    
    public Text DisplayName;

    private float startDelay = 1f;
    private float fruitSpawnTime = 2f;
    private float fruitTextTime = 7f;
    
 
    public int RandomFruit,RandomFruitName;

    public GameObject gameOverPanel;

     public GameObject SuccesOverPanel;
     
    public GameObject buttonRight,buttonLeft;
    CharacterMove cm;
    
  
   
    private void Start() 
    {
        InvokeRepeating("SpawnFruit",startDelay,fruitSpawnTime);
        InvokeRepeating("spawnText",startDelay,fruitTextTime);
        
        
        
    }
    private void Update() 
    {
        scoreText.text = score.ToString();
           
    }
   
    public void SpawnFruit()
    {
        
        float RandomX = Random.Range(-xBounds,xBounds);
        RandomFruit = Random.Range(0,fruits.Length-2);
        Vector2 spawnPos = new Vector2(RandomX,yBound);
        Instantiate(fruits[RandomFruit],spawnPos,fruits[RandomFruit].gameObject.transform.rotation);
    }
    public void spawnText()
    {
        RandomFruitName = Random.Range(0,fruits.Length-3); 
        DisplayName.text=fruits[RandomFruitName].name;
    }
    
    

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(RandomFruit == RandomFruitName)
        {
            Destroy(other.gameObject);
            score +=50;
                  if(score > 45)
            {
                SuccesOverPanel.SetActive(true); 
                CancelInvoke("SpawnFruit");
                CancelInvoke("spawnText");
                buttonLeft.SetActive(false);
                buttonRight.SetActive(false);
            } 
        
        }
        
        else
        {
            Destroy(other.gameObject);
            score -=10;
            if(score < 0)
            {
                gameOverPanel.SetActive(true);
                CancelInvoke("SpawnFruit");
                CancelInvoke("spawnText");
                buttonLeft.SetActive(false);
                buttonRight.SetActive(false);
                
            }  
          
        }
    }

}
