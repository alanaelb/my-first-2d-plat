using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



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

}

