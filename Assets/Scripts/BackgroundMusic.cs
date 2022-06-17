using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
   
  private static BackgroundMusic backgrounMusic;

   void Awake()
   {
      if(backgrounMusic == null)
      {
           backgrounMusic=this;
           DontDestroyOnLoad(backgrounMusic);
      }

      else
      {
          Destroy(gameObject);
      }

   }

}
