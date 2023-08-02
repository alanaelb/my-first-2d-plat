using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//camelCasing - always starts with lower case 
//PascalCasing - always starts with upper case

public class Health : MonoBehaviour
{
    public TMP_Text healthText; 
    
    private int _health = 100;
    private int _maxHealth = 100;

    public void DisplayHealth()
    {
        if (healthText != null)
        {
            healthText.text = "Health: " + _health;
        }
       
    }

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
