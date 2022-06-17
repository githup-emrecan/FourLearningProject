using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
   [SerializeField]
   private Transform BackGround;
   private float size = 9f;

   private void Update() 
   {
       if(transform.position.y >= BackGround.position.y + size)
       {
           BackGround.position = new Vector2(BackGround.position.x,transform.position.y + size);
       }
       else if(transform.position.y <= BackGround.position.y - size)
       {
           BackGround.position = new Vector2(BackGround.position.x,transform.position.y - size);
       }
   }
}
