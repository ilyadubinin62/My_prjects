using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    public GameObject Player;
    public GameObject Ragdoll;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "DeadZone" ) 
        {
            Player.SetActive(false);
            Ragdoll.SetActive(true);
            Instantiate(Ragdoll, transform.position, transform.rotation);
        } 
    }









}
