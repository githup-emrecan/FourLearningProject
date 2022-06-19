using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CharacterMove : MonoBehaviour
{
    private Rigidbody2D rb;
    private float HorizontalMove;
    private bool moveLeft,moveRight;
    private float xBound = 3f;
    private bool onGround;
    private float dirX;

    Animator anim;

    public float speed = 5f;
    public  GameObject panel;
    public GameObject[] question;

    public GameObject[] players;
    
    public GameObject[] cameras;



    private void Start() 
    {
        if(PlayerPrefs.GetInt("selectedcharacter") == 0)
        {
            players[0].SetActive(true);
            players[1].SetActive(false);
            cameras[0].SetActive(true);
            cameras[1].SetActive(false);
            
        }
        else
        {
            players[1].SetActive(true);
            players[0].SetActive(false);
            cameras[1].SetActive(true);
            cameras[0].SetActive(false);
        }
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        moveLeft = false;
        moveRight = false;
        
        
    }

    private void Update() 
    {
        InvizibleWall();
        MovementPlayer();
        SetAnimationState();
            
    }

     private void InvizibleWall()
    {
        if(transform.position.x < -xBound)
        {
            transform.position = new Vector3(-xBound,transform.position.y,transform.position.z);
        }

        if(transform.position.x > xBound)
        {
            transform.position = new Vector3(xBound,transform.position.y,transform.position.z);
        }
    }

    

    private void MovementPlayer()
    {
        if(moveLeft)
        {
            HorizontalMove = -speed;
            
            
        }
        else if(moveRight)
        {
            HorizontalMove = speed;
            
        }
        else
        {
            HorizontalMove = 0;
        }
    }
    public void jumpButton()
    {
        if(onGround)
        {
            float jumpVelocity = 27f;
            rb.velocity = Vector2.up * jumpVelocity;
            onGround = false;
        }
        
    }

    

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.tag == "platform")
        {
            onGround = true;
        }
        if(other.gameObject.tag == "question")
        {
            panel.SetActive(true);
            question[0].SetActive(false);
            
        }
        if(other.gameObject.tag == "question1")
        {
            panel.SetActive(true);
            question[1].SetActive(false);
        }
        if(other.gameObject.tag == "question2")
        {
            panel.SetActive(true);
            question[2].SetActive(false);
        }    
        if(other.gameObject.tag == "question3")
        {
            panel.SetActive(true);
            question[3].SetActive(false);
        }    
        if(other.gameObject.tag == "question4")
        {
            panel.SetActive(true);
            question[4].SetActive(false);
        }    
        if(other.gameObject.tag == "question5")
        {
            panel.SetActive(true);
            question[5].SetActive(false);
        }        
       
    }

    


    private void FixedUpdate() 
    {
        
        rb.velocity = new Vector2(HorizontalMove,rb.velocity.y);    
    }

    public void PointerDownLeft()
    {
        moveLeft = true;
        transform.rotation = Quaternion.Euler(0,180,0);
        
    }
    public void PointerUpLeft()
    {
        moveLeft = false;
    }

    public void PointerDownRight()
    {
        moveRight = true;
        transform.rotation = Quaternion.Euler(0,0,0);
    }
    public void PointerUpRight()
    {
        moveRight = false;
    }

   void SetAnimationState()
	{
		if (dirX == 0) {
			anim.SetBool ("isWalking", false);
			
		}

		if (rb.velocity.y == 0) {
			anim.SetBool ("isJumping", false);
		}

		if (moveLeft &&rb.velocity.y == 0)
        {
            anim.SetBool ("isWalking", true);
        }
			
        if (moveRight &&rb.velocity.y == 0)
        {
            anim.SetBool ("isWalking", true);
        }

		if (rb.velocity.y > 0)
        {
            anim.SetBool ("isJumping", true);
        }
			
		if (rb.velocity.y < 0) {
			anim.SetBool ("isJumping", false);
		}
	}
}
