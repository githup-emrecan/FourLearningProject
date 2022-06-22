using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;


public class Lesson9 : MonoBehaviour
{
    [SerializeField]
     private Sprite[] images; //resimleri için array

    [SerializeField]
     private Image imageContainer;  // image source değiştirmek için

   [SerializeField]
   private AudioClip[] FruitEnSounds; // ses kayıtları için

    [SerializeField]
   private AudioClip[] FruitTrSounds; // ses kayıtları için
 
   private AudioSource  myAudioSource;

   public  static int ImageCount =0 ;

    
    [SerializeField]
    private GameObject LessonNextButton;

    [SerializeField]
    private GameObject LessonBackButton;

  [SerializeField]
    private GameObject LessonEnAudioButton;
     
     public string[] Entext = { "Drum","flute","Guitar", "Band", "Violin", "Piona", "Bell", "Singer"}; // ingilizce Textler
     public string[] Trtext = {"Bateri","Fülüt","Gitar","Müzik Grubu", "Keman", "Piyona", "Zil", "Şarkıcı"};  // Türkçe Textler

    [SerializeField]
     private  Text displayEnText;  // ingilizce text göstermek için

    [SerializeField]
     private  Text displayTRText;  // türkçe text göstermek için 

  
   

    // Start is called before the first frame update
    void Start()
    { 
       LessonNextButton.GetComponent<Button>().interactable = false;
      StartCoroutine(WaitingFunction());
      
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
   if(ImageCount == images.Length-1) {
         SceneManager.LoadScene("MuzikQuiz");
      }
     ImageCount= ImageCount+1;
    ShowInArray(ImageCount);
     LessonNextButton.GetComponent<Button>().interactable = false;
      StartCoroutine(WaitingFunction());
 if(ImageCount >=1)
    {
       LessonBackButton.GetComponent<RectTransform>().DOScale(1,1f);
    }
 }

public void ShowEnSound()
 { 
   ShowSound(ImageCount);
 }

public void ShowTrSound()
 { 
   ShowSound2(ImageCount);
 }

public void ShowSound(int indexx)
 { 
        AudioClip sound = FruitEnSounds[indexx];
         myAudioSource.PlayOneShot(sound);
 }

public void ShowSound2(int indexx)
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
  
IEnumerator WaitingFunction()
 {
   yield return new WaitForSeconds(3);
   LessonNextButton.GetComponent<Button>().interactable = true;
 }


}
