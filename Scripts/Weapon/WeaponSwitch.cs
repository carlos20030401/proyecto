using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{

    public GameObject[] weapons;

    public int selectedWeappn = 0;

    void Start() 
    {
        SelectWeapon();
    }


    void Update()
    {
        int previousWeapon = selectedWeappn;

        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if (selectedWeappn >= weapons.Length - 1)
            {
                selectedWeappn = 0;
            }
            else
            {
                selectedWeappn++;
            }
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if (selectedWeappn <= 0)
            {
                selectedWeappn = weapons.Length - 1;
            }
            else
            {
                selectedWeappn--;
            }
        }
        if (previousWeapon != selectedWeappn)
        {
            SelectWeapon();

        }
    }



    void SelectWeapon() 


    {
        int i = 0;
        foreach (Transform weapon in transform)
        {
            if (weapon.gameObject.layer == LayerMask.NameToLayer("Weapon"))
            {
                if (i == selectedWeappn)
                {
                    weapon.gameObject.SetActive(true);
                }
                else
                {
                    weapon.gameObject.SetActive(false);
                }
                i++;
            }
        }
    }


}
