using UnityEngine;
using System.Collections;
public class CharacterControl : MonoBehaviour 
{
    Animator animator;
    CharacterController controller;
    public Canvas gameOver;
    private bool isHoldingJump = false;
    private float speedAcceleration = 0.1f;
    public float speed = 0.0f;
    public float jumpForce = 10.0f;
    public float maxJumpForce = 50.0f;
    public float jumpRate = 10f;
    Vector3 velocity;
    void Start () 
    {
        animator = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
    }
    bool grounded;
    void Update()
    {
        if(grounded!=controller.isGrounded) //checking whether the current state of being grounded is different from the previous state 
        {
            if(grounded)
            {
                animator.SetFloat("impact",controller.velocity.y);
            }
            grounded = controller.isGrounded; //change it to the current state
        }
        velocity = new Vector3(speed, controller.velocity.y,0);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isHoldingJump = true;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            isHoldingJump = false;
        }
        
        if (velocity.y <= 0 && grounded && isHoldingJump)
        {
            velocity +=  Vector3.up * Mathf.Min(jumpForce,maxJumpForce);
        }
        animator.SetBool("grounded",grounded);
        animator.SetFloat("velocityY",controller.velocity.y);
        speed += speedAcceleration * Time.deltaTime;

        if (transform.position.y <= -5.1)
        {
            gameOver.gameObject.SetActive(true);
        }
        
        if (isHoldingJump)
        {
            jumpForce += Time.fixedDeltaTime * jumpRate;
        }
        else
        {
            jumpForce = 10.0f;
        }
    }

    void FixedUpdate()
    {
        

        controller.Move((velocity+new Vector3(0,-1.0f,0))*Time.fixedDeltaTime);
    }
}

