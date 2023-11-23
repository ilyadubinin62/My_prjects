using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterphisics : MonoBehaviour
{
    public float upMaxSpeed = 1.15f;
    public float upSpeed = 1f;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.layer == 4)
        {
            float dif = (other.transform.position.y - transform.position.y) * upSpeed;
            rb.AddForce(new Vector3(0f, Mathf.Clamp((Mathf.Abs(Physics.gravity.y) * dif), 0, Mathf.Abs(Physics.gravity.y) * upMaxSpeed), 0f), ForceMode.Acceleration);
            rb.drag = 0.99f;
            rb.angularDrag = 0.8f;

        }   
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 4)
        {
            rb.drag = 0f;
            rb.angularDrag = 0f;
        } 
    }
}
