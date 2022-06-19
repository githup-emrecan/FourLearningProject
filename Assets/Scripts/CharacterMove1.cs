using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CharacterMove1 : MonoBehaviour
{
    private Rigidbody2D rb;
    private float HorizontalMove;
    private bool moveLeft,moveRight;
    private float xBound = 3f;
    private bool onGround;
    private float dirX;

    Animator anim;

    public float speed = 5f;
    

    public GameObject[] players;
    



    private void Start() 
    {
        if(PlayerPrefs.GetInt("selectedcharacter") == 0)
        {
            players[0].SetActive(true);
            players[1].SetActive(false);
        }
        else
        {
            players[1].SetActive(true);
            players[0].SetActive(false);
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
