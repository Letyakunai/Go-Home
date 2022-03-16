using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic_Movement : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody2D playerRigidBody;
    private SpriteRenderer spriteRenderer;

    [Header("Movement")]
    [SerializeField]
    private float moveSpeed = 3.0f;

    [SerializeField]
    private float jumpForce = 400.0f;

    [Header("Ground")]
    [SerializeField]
    private Transform groundPoint;
    [SerializeField]
    private float groundRadius = 0.2f;
    [SerializeField]
    private LayerMask groundLayers;

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

        Debug.Log(isGrounded());
        if (isJump && isGrounded())
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

    private bool isGrounded()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(groundPoint.position, groundRadius, groundLayers);
        for(int i = 0; i < colliders.Length; i++)
            if(colliders[i].gameObject != gameObject)
            {
                return true;
            }
            return false;
        }
    }