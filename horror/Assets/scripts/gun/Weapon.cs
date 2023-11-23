using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bullet;
    public Camera mainCamera;
    public Transform spawnbullet;
    public float shotforce;
    public float spreafed;

    void Update()
    {
        if (Input.GetMouseButtonDown(1 ))
        {
            Shoot();
        }

    }
    private void Shoot()
    {
        Ray ray = mainCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;
        Vector3 targetPoint;
        if (Physics.Raycast(ray,out  hit))

        {
            targetPoint = hit.point;

        }
        else
        {
            targetPoint = ray.GetPoint(75);

        }
        Vector3 dirWithoutSpread = targetPoint - spawnbullet.position;
        float x = Random.Range(-spreafed, spreafed);
        float y = Random.Range(-spreafed, spreafed);
        Vector3 dirWiSpread = dirWithoutSpread + new Vector3(x, y);

        GameObject currentBullet = Instantiate(bullet, spawnbullet.position, Quaternion.identity);
        currentBullet.transform.forward = dirWiSpread.normalized;
        currentBullet.GetComponent<Rigidbody>().AddForce(dirWiSpread.normalized * shotforce, ForceMode.Impulse);


    }
}
