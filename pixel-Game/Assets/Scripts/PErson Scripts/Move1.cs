using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move1 : MonoBehaviour
{
    public float playerSpeed = 5f;
    private float currentSpeed = 0.0f;
    public Rigidbody2D rb;
    public   Camera cam;
    Vector2 movement;
    Vector2 mousePos;
    private Vector2 lastMovement = new Vector2();

    public List<KeyCode> upButton;
    public List<KeyCode> downButton;
    public List<KeyCode> leftButton;
    public List<KeyCode> rightButton;


    public Transform laser;

    // Как далеко от центра корабля будет появлятся лазер
    public float laserDistance = 0.2f;

    // Задержка между выстрелами (кулдаун)
    public float timeBetweenFires = 0.3f;

    // Счетчик задержки между выстрелами
    private float timeTilNextFire = 0.0f;

    // Кнопка, которая используется для выстрела
    public List<KeyCode> shootButton;

    Vector2 MoveIfPressed(List<KeyCode> keyList, Vector3 Movement)
    {
        // Проверяем кнопки из списка
        foreach (KeyCode element in keyList)
        {
            if (Input.GetKey(element))
            {

                return Movement;
            }
        }
        // Если кнопки не нажаты, то не двигаемся
        return Vector3.zero;
    }
    void Movement()
    {
        // Необходимое движение
        Vector2 movement = new Vector2();
        // Проверка нажатых клавиш
        movement += MoveIfPressed(upButton, Vector2.up);
        movement += MoveIfPressed(downButton, Vector2.down);
        movement += MoveIfPressed(leftButton, Vector2.left);
        movement += MoveIfPressed(rightButton, Vector2.right);
        // Если нажато несколько кнопок, обрабатываем это
        movement.Normalize();
        // Проверка нажатия кнопки
        if (movement.magnitude > 0)
        {
            // После нажатия двигаемся в этом направлении
            currentSpeed = playerSpeed;
            this.transform.Translate(movement * Time.deltaTime * playerSpeed, Space.World);
            lastMovement = movement;
        }
        else
        {
            // Если ничего не нажато
            this.transform.Translate(lastMovement * Time.deltaTime * currentSpeed, Space.World);
            // Замедление со временем
            currentSpeed *= 0.9f;
        }
    }
    // Start is called before the first frame update
    void Update()
    {
        Movement();
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        foreach (KeyCode element in shootButton)
        {
            if (Input.GetKey(element) && timeTilNextFire < 0)
            {
                timeTilNextFire = timeBetweenFires;
                ShootLaser();
                break;
            }
        }
        timeTilNextFire -= Time.deltaTime;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * playerSpeed * Time.fixedDeltaTime);
        Vector2 lookDir = mousePos - rb.position;
        float angel = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation= angel;
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
