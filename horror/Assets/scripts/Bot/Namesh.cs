using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Namesh : MonoBehaviour
{
    public Transform target;
    private NavMeshAgent agent;
   
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = target.position;
       
    }
    /*
    public void Attacke(float attackerange)
    {
        agent.SetDestination(target.position);
        float distance = Vector3.Distance(agent.transform.position, target.position);
        loat distance = Vector3.Distance(enemy.transform.position, Player.position);
        enemy.SetDestination(Player.position);
        if (distance < attackerange)
        {


            nav.SetFloat("Blend", 1);

        }
    }
   */
}
