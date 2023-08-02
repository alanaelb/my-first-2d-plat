using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private int _health = 100;
    private int _maxHealth = 100;

    public void Damage(int damage)
    {
        _health -= damage;

        if (_health <= 0)
        {
            //_health = 0;
            Destroy(gameObject);
        }
    }


    public void Heal(int heal)
    {
        _health = Mathf.Min(_maxHealth, _health + heal);
    }

}
