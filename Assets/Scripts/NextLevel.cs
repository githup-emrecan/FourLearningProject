using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
   [SerializeField]
   int nextSceneLoad;

   private void Start() 
   {
       nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
   }


   public void clicked()
    {
        SceneManager.LoadScene(nextSceneLoad);
        
        if(nextSceneLoad > PlayerPrefs.GetInt("levetat"))
        {
           PlayerPrefs.SetInt("levelat",nextSceneLoad);
        }
       
    }

   
}
