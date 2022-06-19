using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragAndDrop : MonoBehaviour
{
   public GameObject[] animals;

   Vector2 pandaPos, rabbitPos, wolfPos, bearPos;

   public AudioSource source;
   public AudioClip correct,incorrect;

   public GameObject scPanel;

   bool pandaCorrect, rabbitCorrect, wolfCorrect, bearCorrect = false;


   private void Start() 
   {
        pandaPos = animals[0].transform.position;
        rabbitPos = animals[1].transform.position;
        wolfPos = animals[2].transform.position;
        bearPos = animals[3].transform.position;
   }

    public void DragPanda()
    {
        animals[0].transform.position = Input.mousePosition;
    }

    public void DragRabbit()
    {
        animals[1].transform.position = Input.mousePosition;
    }

    public void DragWolf()
    {
        animals[2].transform.position = Input.mousePosition;
    }

    public void DragBear()
    {
        animals[3].transform.position = Input.mousePosition;
    }

    public void DropPanda()
    {
        float Distance = Vector3.Distance(animals[0].transform.position,animals[4].transform.position);
        if(Distance < 100)
        {
            animals[0].transform.position = animals[4].transform.position;
            source.clip = correct;
            source.Play();
            pandaCorrect = true;
        }
        else
        {
            animals[0].transform.position = pandaPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DropRabbit()
    {
        float Distance = Vector3.Distance(animals[1].transform.position,animals[5].transform.position);
        if(Distance < 100)
        {
            animals[1].transform.position = animals[5].transform.position;
            source.clip = correct;
            source.Play();
            rabbitCorrect = true;
        }
        else
        {
            animals[1].transform.position = rabbitPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DropWolf()
    {
        float Distance = Vector3.Distance(animals[2].transform.position,animals[6].transform.position);
        if(Distance < 100)
        {
            animals[2].transform.position = animals[6].transform.position;
            source.clip = correct;
            source.Play();
            wolfCorrect = true;
        }
        else
        {
            animals[2].transform.position = wolfPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DropBear()
    {
        float Distance = Vector3.Distance(animals[3].transform.position,animals[7].transform.position);
        if(Distance < 100)
        {
            animals[3].transform.position = animals[7].transform.position;
            source.clip = correct;
            source.Play();
            bearCorrect = true;
        }
        else
        {
            animals[3].transform.position = bearPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    private void Update() 
    {
        if(pandaCorrect && rabbitCorrect && wolfCorrect && bearCorrect == true)
        {
            scPanel.SetActive(true);
        }    
    }

}
