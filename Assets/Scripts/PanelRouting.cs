using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PanelRouting : MonoBehaviour
{


    LevelChange levelChange;
    public void Retrty()
    {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

   public void MainRetry()
    {
     SceneManager.LoadScene("Character");
    }

    public void NextMeyve()
    {
        SceneManager.LoadScene("MeyvelerOyun");
    }

     public void NextRenkler()
    {
        SceneManager.LoadScene("RenklerOyun");
    }
    public void NextAile()
    {
        SceneManager.LoadScene("AileOyun");
    }
    public void NextDuygular()
    {
        SceneManager.LoadScene("DuygularOyun");
    }
    public void NextHayvanlar()
    {
        SceneManager.LoadScene("HayvanlarOyun");
    }
    public void NextAnatomi()
    {
        SceneManager.LoadScene("AnatomiOyun");
    }
    public void NextMobilya()
    {
        SceneManager.LoadScene("MobilyaOyun");
    }
    public void NextUlasım()
    {
        SceneManager.LoadScene("UlasımOyun");
    }
    public void NextMuzik()
    {
        SceneManager.LoadScene("MuzikOyun");
    }
     public void NextHavaDurumu()
    {
        SceneManager.LoadScene("HavaDurumuOyun");
    }


}
