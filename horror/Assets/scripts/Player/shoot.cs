using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject Player;
    public GameObject shot;
    void Start()
    {
        shot.SetActive(false);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Player.GetComponent<Animator>().SetTrigger("shot");
            shot.SetActive(true);
        }

        if (Input.GetMouseButtonUp(0))
        {
            Player.GetComponent<Animator>().SetTrigger("idle");
            shot.SetActive(false);
        }
    }
}
