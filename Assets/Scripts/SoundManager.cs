using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SoundManager : MonoBehaviour
{

    [SerializeField] Image soundOnIcon;
    [SerializeField] Image sounOffIcon;
    private bool muted = false;
    // Start is called before the first frame update
    void Start()
    {
        if(!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted",0);
            Load();
        }
        else
        {
           Load();    
        }
        UpdateButtonIcon();
        AudioListener.pause = muted;
    }
 
    public void onButtonPress()
    {
         if(muted == false)
         {
             muted=true;
             AudioListener.pause = true;
         }
         else
         {
             muted=false;
             AudioListener.pause =false;
         }
         Save();
         UpdateButtonIcon();
    }

     private void UpdateButtonIcon()
     {
         if(muted == false)
         {
             soundOnIcon.enabled = true;
             sounOffIcon.enabled = false;
         }
         else
         {
             soundOnIcon.enabled = false;
             sounOffIcon.enabled = true;
         }
     }

     private void Load()
         {
            muted = PlayerPrefs.GetInt("muted") == 1;
         }

     private void Save()
         {
           PlayerPrefs.SetInt("muted",muted ? 1 : 0);
         }

   

}
