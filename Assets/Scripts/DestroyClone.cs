using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyClone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "fruit")
        {
            Destroy(other.gameObject);
            
        }    
    }
}
