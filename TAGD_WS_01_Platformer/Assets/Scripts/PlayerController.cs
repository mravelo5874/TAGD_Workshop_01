using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // variables
    private Rigidbody2D rb;
    public float moveSpeed;
    public Vector2 jumpHeight;
    private bool facingRight = true;
    private float moveInput;

    // this gets called once at the beginning of the game
    void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }

    // this gets called multiple times a frame
    void FixedUpdate(){
        // move the player 
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        // flip the player 
        if (facingRight == false && moveInput > 0) {
            Flip();
        } else if (facingRight == true && moveInput < 0) {
            Flip();
        }
    }
    
    void Update (){
        // makes player jump when you press space
        if (Input.GetKeyDown(KeyCode.Space)) {
            rb.AddForce(jumpHeight, ForceMode2D.Impulse);
        }
    }
    
    // custom function that flips the player vertically
    void Flip() {
        facingRight = !facingRight;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }
}
