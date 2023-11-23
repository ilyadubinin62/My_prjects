using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class strelb : MonoBehaviour
{
    public Transform Bot;
    public float attackerange =5f;
     public  Transform player;
    public Transform laser;
    public float laserDistance = 2f;
   

    // Задержка между выстрелами (кулдаун)
    public float timeBetweenFires = 4f;


    // Счетчик задержки между выстрелами
    private float timeTilNextFire = 0.0f;
  
    void Update()
    {
        if (Vector2.Distance(player.position,Bot.position ) <= attackerange && timeTilNextFire < 0)
        {
            ShootLaser();
            timeTilNextFire = timeBetweenFires;
        }
        timeTilNextFire -= Time.deltaTime;

    }
    void ShootLaser()
    {
        // Высчитываем позицию корабля
        float posX = this.transform.position.x +
            (Mathf.Cos((transform.localEulerAngles.z - 90) *
                        Mathf.Deg2Rad) * -laserDistance);
        float posY = this.transform.position.y +
            (Mathf.Sin((transform.localEulerAngles.z - 90) *
                        Mathf.Deg2Rad) * -laserDistance);
        // Создаём лазер на этой позиции
        Instantiate(laser, new Vector3(posX, posY, 0), this.transform.rotation);
       
    }
}
