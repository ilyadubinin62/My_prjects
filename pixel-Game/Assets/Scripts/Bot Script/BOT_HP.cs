using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOT_HP : MonoBehaviour
{
    public int health = 20;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.name.Contains("laser"))      
        {
            LaserScript laser = collision.gameObject.GetComponent("LaserScript") as LaserScript;
            health -= laser.damage;
        }
        if ( health <= 0)
        {
            Destroy(this.gameObject);
        }

        
    }
 
}
