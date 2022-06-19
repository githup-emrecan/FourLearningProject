using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PanelRouting : MonoBehaviour
{


     LevelChange levelChange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Retrty()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
}

   public void MainRetry()
{
   // levelChange.levelFive();
    SceneManager.LoadScene("Character");
}


}
