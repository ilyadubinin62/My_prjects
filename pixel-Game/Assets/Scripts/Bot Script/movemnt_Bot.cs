using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movemnt_Bot : MonoBehaviour
{
    private Transform Player;

    public float move = 5f;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 delta = Player.position - transform.position;
        delta.Normalize();
        float MoveSpeed = move * Time.deltaTime;
        transform.position = transform.position + (delta * MoveSpeed);
        
    }
}
