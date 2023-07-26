using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 10; 
    public bool isMovingRight = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Starting point
    // Direction, Speed
    // Vector, Behaviour

    void Update()
    {
        if (isMovingRight)
        {
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
        }
        else
        {
            transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime;
        }
        if (transform.position.x >= 10)
        {
            isMovingRight = false;
        }
        if (transform.position.y <= -10)
        {

            isMovingRight = true;
        }




    }





}
