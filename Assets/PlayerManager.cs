using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private Health _health;
    void Start()
    {
        _health = GetComponent<Health>();   
    }

   private void OnTriggerEnter2D(Collider2D collision)
    {
        _health.Damage(20);
    }
}
