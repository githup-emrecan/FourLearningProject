using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Lesson1 : MonoBehaviour
{
    [SerializeField]
     private Sprite[] images; //resimleri için array

    [SerializeField]
     private Image imageContainer;  // image source değiştirmek için

   [SerializeField]
   private AudioClip[] FruitTrSounds;

   private AudioSource  myAudioSource;

   public  static int ImageCount =0 ;

    
    [SerializeField]
    private GameObject LessonNextButton;

    [SerializeField]
    private GameObject LessonBackButton;

  [SerializeField]
    private GameObject LessonEnAudioButton;
     
     public string[] Entext = { "Apple","Banana","Orange", "strawberry"}; // ingilizce Textler
     public string[] Trtext = {"Elma","Muz","Portakal","Çilek"};  // Türkçe Textler

    [SerializeField]
     private  Text displayEnText;  // ingilizce text göstermek için

    [SerializeField]
     private  Text displayTRText;  // türkçe text göstermek için 

  
   

    // Start is called before the first frame update
    void Start()
    { 

      
        if(ImageCount==0)
        {
           LessonBackButton.GetComponent<RectTransform>().DOScale(0,1f);
        }
        ShowInArray(ImageCount);
        myAudioSource  = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void ShowInArray (int index)
   {
      if(images.Length >= index)
      {
         imageContainer.sprite = images[index];
         displayTRText.text=Trtext[index];
         displayEnText.text =Entext[index];
       
      }
      else 
      {
         
      }
   }
   

 public void ArrayCountIncrease()
 { 
     ImageCount= ImageCount+1;
    ShowInArray(ImageCount);

 if(ImageCount >=1)
    {
       LessonBackButton.GetComponent<RectTransform>().DOScale(1,1f);
    }
 }

public void ShowEnSound()
 { 
   ShowSound(ImageCount);
 }



public void ShowSound(int indexx)
 { 
        AudioClip sound = FruitTrSounds[indexx];
         myAudioSource.PlayOneShot(sound);
   
 }




 public void ArrayCountDecrease()
 {
    
    ImageCount=ImageCount-1;
    
    ShowInArray(ImageCount);

    if(ImageCount<1)
    {
        LessonBackButton.GetComponent<RectTransform>().DOScale(0,1f);
    }
 }
  



}
