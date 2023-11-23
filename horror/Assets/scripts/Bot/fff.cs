using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class fff : MonoBehaviour
{
    public GameObject Enemy;
    public float timer;
    private bool yes;
    public float newtimer;

    // Start is called before the first frame update
    void Start()
    {
        newtimer = timer;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Enemy.gameObject.GetComponent<NavMeshAgent>().enabled = true;
            Enemy.GetComponent<Animator>().SetTrigger("Run");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
