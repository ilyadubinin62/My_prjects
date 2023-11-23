using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hp : MonoBehaviour
{
    public float health = 3;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("bullet"))
        {
            deadgun bullet = collision.gameObject.GetComponent("deadgun") as deadgun;
            health -= bullet.damage;
        }
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    
}
