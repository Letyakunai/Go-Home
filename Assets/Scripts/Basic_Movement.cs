using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic_Movement : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody2D playerRigidBody;
    private SpriteRenderer spriteRenderer;

    public float moveSpeed = 3.0f;

    private float horizontalInput;
    private bool facingRight = true;

    
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        Flip(horizontalInput);
    }

    private void FixedUpdate()
    {
        float horizontalMovement = horizontalInput * moveSpeed;
        playerRigidBody.velocity = new Vector2(horizontalMovement, playerRigidBody.velocity.y);
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
