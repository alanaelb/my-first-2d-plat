using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private bool _isJumpInput = false; 
    private bool _isGrounded = false;   
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
       if (Input.GetKeyUp(KeyCode.Space))
        {
            _isJumpInput=true;
        }
    }
    void FixedUpdate()
    {

        if (_isJumpInput && _isGrounded)
        {
            _rigidbody.AddForce(Vector2.up * 200f);
        }
        _isJumpInput = false; 

        if (Input.GetKey(KeyCode.RightArrow))
        {
            _rigidbody.AddForce(Vector2.right * 600f * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _rigidbody.AddForce(Vector2.left * 600f * Time.deltaTime);
        }
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody2D playerRB = GetComponent<Rigidbody2D>();
            playerRB.AddForce(Vector2.up * 200f);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Rigidbody2D playerRB = GetComponent<Rigidbody2D>();
            playerRB.AddForce(Vector2.left * 200f);
        }
       
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Rigidbody2D playerRB = GetComponent<Rigidbody2D>();
            playerRB.AddForce(Vector2.right * 200f);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        _isGrounded = true; 
    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        _isGrounded = false; 
    }
}

