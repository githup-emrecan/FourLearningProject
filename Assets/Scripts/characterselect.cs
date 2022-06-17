using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class characterselect : MonoBehaviour
{
    
    [SerializeField] private GameObject PanelAccount ;
 
 
    [SerializeField] private  Image girlIcon;

    [SerializeField] private Image boyIcon;

    [SerializeField] private InputField input_field;

    [SerializeField] private GameObject displayText;

    //[SerializeField] private GameObject Placeholder;
    
  // boy 0 girl 1
    public  bool selectedcharacter = false; 
    public  string C_name;



   void Start()
   {
      
        if(!PlayerPrefs.HasKey("selectedcharacter"))
        {
            PlayerPrefs.SetInt("selectedcharacter",0);
            Load();
            LoadName();
        }
        else
        { 
           Load();    
           LoadName();
        }
        UpdateCharacterIcon();
   }
   
   
     public void BoyonButtonPress()
    {  
        if(selectedcharacter==true){
            selectedcharacter=false;
        }
         selectedcharacter = false;
         UpdateCharacterIcon();
         save();
        // PanelAccount.GetComponent<RectTransform>().DOScale(0,1f);
    }
    
    public void GirlonButtonPress()
    {   
        if(selectedcharacter==true)
        {
            selectedcharacter=false;
        }
         selectedcharacter = true;
         UpdateCharacterIcon();
         save();
        
    }


    public void UpdateCharacterIcon()
    {
        if(selectedcharacter == false)
         {
           boyIcon.enabled=true;
           girlIcon.enabled=false;
         }
         else 
         {
           boyIcon.enabled = false;
           girlIcon.enabled = true;
         }
    }
  
    public void ButtonCharacterName()
    {
    
      C_name = input_field.text;
      ShowCharacterName();
     saveName();
    
      PanelAccount.GetComponent<RectTransform>().DOScale(0,1f);
    }
     
    public void ShowCharacterName()
    {
      displayText.GetComponent<Text>().text = C_name;
    }
    
    public void save()
    {
      PlayerPrefs.SetInt("selectedcharacter" , selectedcharacter ? 1 : 0);
    //  PlayerPrefs.SetString("C_name",C_name);
    
    }


    public void Load()
    {
       selectedcharacter=PlayerPrefs.GetInt("selectedcharacter") == 1;
      // displayText.GetComponent<Text>().text =PlayerPrefs.GetString("C_name");
     //  input_field.text = PlayerPrefs.GetString("C_name");
  
    }


    public void saveName()
    {
      PlayerPrefs.SetString("C_name",C_name);
    }

    public void LoadName()
    {
      displayText.GetComponent<Text>().text =PlayerPrefs.GetString("C_name");
       input_field.text = PlayerPrefs.GetString("C_name");
    }
    

}
