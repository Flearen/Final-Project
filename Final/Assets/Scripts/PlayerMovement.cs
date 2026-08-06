using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    //Animator anim;
    Rigidbody2D rb2d;
    float horizontalInput ;
    //player movement
    public float moveSpeed = 10f;
    public float jumpSpeed = 5f;
     //variables for cheking if player is grounded
    public Transform GroundCheckPoint;

    public LayerMask GroundLayer;
    float groundCheckRadius = 0.2f;
    //reset player position
    public float gameOverHeight = -4f;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        //anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        float nextVelocityX = horizontalInput * moveSpeed;
        float nextVelocityY = rb2d.velocity.y;
        bool isGrounded = CheckGrounded();
        if(isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            nextVelocityY = jumpSpeed;
        }
        rb2d.velocity = new Vector2(nextVelocityX, nextVelocityY);
        //change player orientation based on input
        //if(horizontalInput < 0)
       // {
        //    transform.localScale = new Vector3(-1, 1, 1);
           
       // }
        //if(horizontalInput > 0)
        ///{
       //      transform.localScale = new Vector3(2,2,1);   
       // }
        //animation parameters
        //anim.SetFloat("Xspeed", Mathf.Abs(nextVelocityX));
        //anim.SetFloat("Yspeed", nextVelocityY);
        //anim.SetBool("Grounded", isGrounded);
        //Restrat if below certian height
        if(transform.position.y < gameOverHeight)
        {
            print("I died from falling to far");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            
        }
    }
    bool CheckGrounded()
    {
        return Physics2D.OverlapCircle(GroundCheckPoint.position, groundCheckRadius, GroundLayer);

    }
}
