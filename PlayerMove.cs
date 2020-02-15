using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float speed;
    public float jumpForce;
    private float moveInput;
   

    private Rigidbody2D rb;

    private bool facingRight = true;

    private bool isGrounded;
    public Transform groundCheck; //the area that checks if the object is in contact with a collider.
    public float checkRadius;
    public LayerMask whatisGround;


    private int Jumps;
    public int moreJumps;

    AudioSource mJump; // assigns the audio to the 'mJump' value
    


    void Start()
    {
        Jumps = moreJumps;
        rb = GetComponent<Rigidbody2D>();
        mJump = GetComponents<AudioSource>()[1];
        mJump.playOnAwake = false; // when the player jumps the sound within the audio source is played.
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatisGround);

        moveInput = Input.GetAxis("Horizontal");
        Debug.Log(moveInput);
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if (facingRight == false && moveInput > 0)
        {
            Flip();
        }
        else if (facingRight == true && moveInput < 0)
        {
            Flip();
        } // flips the 'good guy' when travelling in different directions.
    }

    void Update()
    {
        if(isGrounded == true)
        {
          Jumps = moreJumps;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && Jumps > 0)
        {
            rb.velocity = Vector2.up * jumpForce;
            Jumps--;
            mJump.Play(); // the actual sound is played when the up arrow is pressed.
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && Jumps == 0 & isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpForce;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
            Application.LoadLevel("Menu"); // although this is a warning, it is not important as this is what calls 'Menu'

        if (Input.GetKeyDown(KeyCode.R))
            Application.LoadLevel("Scroll"); // although this is a warning, it is not important as this is what calls 'Scroll'



    }



    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;

    }
}