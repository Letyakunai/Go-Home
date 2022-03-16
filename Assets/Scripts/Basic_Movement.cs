using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic_Movement : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody2D playerRigidBody;
    private SpriteRenderer spriteRenderer;

    [SerializeField]
    private float moveSpeed = 3.0f;

    [SerializeField]
    private float jumpForce = 400.0f;

    private float horizontalInput;
    private bool facingRight = true;
    private bool isJump = false;

    
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        Flip(horizontalInput);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isJump = true;
        }
    }

    private void FixedUpdate()
    {
        float horizontalMovement = horizontalInput * moveSpeed;
        playerRigidBody.velocity = new Vector2(horizontalMovement, playerRigidBody.velocity.y);

        if (isJump)
        {
            playerRigidBody.AddForce(new Vector2(0, jumpForce));
            isJump = false;
        }
    }

    private void Flip(float movement)
    {
        if(movement > 0 && !facingRight || movement < 0 && facingRight)
        {
            facingRight = !facingRight;
            spriteRenderer.flipX = !facingRight;
        }
    }

}
