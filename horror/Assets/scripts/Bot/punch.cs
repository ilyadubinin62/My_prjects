using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class punch : MonoBehaviour
{
    public GameObject Player;
    public GameObject Bot;
    bool rastt;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "DeadZone")
        {
            Bot.GetComponent<Animator>().SetBool("rast", rastt);
        }
    }

        
    
}
