using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrowGrenade : MonoBehaviour
{
    public float throwForce = 500;
    public GameObject grenadePrefap;
   



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Throw();
        }
    }


    public void Throw()
    {
        GameObject newGrenade = Instantiate(grenadePrefap,transform.position,transform.rotation);

        newGrenade.GetComponent<Rigidbody>().AddForce(transform.forward * throwForce);   
           
    }
}
