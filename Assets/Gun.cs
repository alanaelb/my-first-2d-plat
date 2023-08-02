using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject BulletPreFab;

    void Start()
    {
        
    }

    
    void Update()
    {
       if (Input.GetMouseButtonDown(0))
        {

            Instantiate(BulletPreFab , transform.position, Quaternion.identity); 
        }
    }
}
