using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Vision : MonoBehaviour
{
    //переменная в которую перетащим бота
    public GameObject Enemy;
    //переменная для таймера ,то есть сколько надо бежать
    //боту когда мы вышли с его тригера
    public float timer ;
    //переключатель для таймеров
    public bool pereklychatel = false;
    //новый таймер(timer) который будет меняться с таймером (timer)
    public float newtimer;
    //переменная для того  чтобы использовать навмешагенти бота
    private NavMeshAgent enemy;
    //переменная которая позваляет вызывать параметры для нашей анимации
    private Animator nav;
    public Transform Player;
    private float attackerange = 2f;


    void Start()
    {

        Player = Player.gameObject.GetComponent<Transform>();
        //благодаря этой строке мы можем вызывать навмешагент не через 
        //это большое колличество слов ,а через 1 слово enemy
        enemy = Enemy.gameObject.GetComponent<NavMeshAgent>();
        //getcomponent это штука которая обращается
        //к компонентам объеккта их инспектора
        Enemy.gameObject.GetComponent<NavMeshAgent>().enabled = false;
        Enemy.gameObject.GetComponent<Namesh>().enabled = false;
        //переменная которая хранит анимациии у Enemy то есть  у бота
        nav = Enemy.GetComponent<Animator>();
        newtimer = timer;
    }
    private void OnTriggerStay(Collider other)
    {
        
        if (other.tag == "Player")
        {
            //включаем его компоненты которые были отклбчены на старте
            Enemy.gameObject.GetComponent<Namesh>().enabled = true;
            Enemy.gameObject.GetComponent<NavMeshAgent>().enabled = true;
            //чтобы бот мог бегать
            nav.SetFloat("speed", enemy.velocity.magnitude / enemy.speed);
        }
       
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            
            nav.SetFloat("speed", enemy.velocity.magnitude / enemy.speed);
            pereklychatel = true;
           
        }

    }
    void Update()
    {
        if (pereklychatel == true)
        {
            //включаем таймер
            timer -= Time.deltaTime;
        }
        if (timer <= 0)
        {
            Enemy.gameObject.GetComponent<NavMeshAgent>().enabled = false;
            Enemy.gameObject.GetComponent<Namesh>().enabled = false;
            pereklychatel = false;
            timer = newtimer;
            nav.SetFloat("speed", enemy.velocity.magnitude  );

        }
       
            enemy.SetDestination(Player.position);
            float distance = Vector3.Distance(enemy.transform.position, Player.position);
            enemy.SetDestination(Player.position);
            if (distance < attackerange)
            {
            enemy.speed = 0f;
            nav.SetBool("punch" , true);
            }
        if (distance >7 )
        {
            nav.SetBool("punch", false);
            enemy.speed =  3.5f;
        }

    }

}
