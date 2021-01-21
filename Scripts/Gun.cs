using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
public Camera fpscam;
public ParticleSystem MuzzleFlash;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1"))
        {
            shoot();

        }
    }

    void shoot()
    {
        MuzzleFlash.Play();

        RaycastHit hit;
        if(Physics.Raycast(fpscam.transform.position, fpscam.transform.forward, out hit)){
            Debug.Log(hit.transform.name);


            Target target = hit.transform.GetComponent<Target>();
            if(target != null){
                target.takeDamage(damage);
            }

        }
    }
}
