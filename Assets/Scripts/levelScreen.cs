using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelScreen : MonoBehaviour
{

   // private characterselect C_select;
    // Start is called before the first frame update
     [SerializeField] private  Image L_Girl;
     [SerializeField] private  Image L_Boy;
     [SerializeField] private  Text displayName;
    void Start()
    {
      GetCharacter();
      GetCharacterName();
    }
 
    public void GetCharacter()
    {
        if(PlayerPrefs.GetInt("selectedcharacter") == 0)
        {
            L_Boy.enabled=true;
            L_Girl.enabled=false;
        }
        else
        {
            L_Boy.enabled = false;
            L_Girl.enabled = true;
        }
    }

    public void GetCharacterName()
    {
          displayName.text = PlayerPrefs.GetString("C_name");
    }
    public void BackScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
