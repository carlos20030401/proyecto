using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractions : MonoBehaviour

{

    public Transform startPosition;



    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("GunAmmo"))


        {
            GameManager.instance.gunAmmo += other.gameObject.GetComponent<AmmoBox>().ammo;

            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("DeadFloor"))
        {
            GameManager.instance.LoseHealth(50);

            GetComponent<CharacterController>().enabled = false;

            gameObject.transform.position = startPosition.position;

            GetComponent<CharacterController>().enabled = true;

        }




    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("EnemyBullet"))
        {
            GameManager.instance.LoseHealth(5);
        }
    }

}
