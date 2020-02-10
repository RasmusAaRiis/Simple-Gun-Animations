using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class GunController : MonoBehaviour
{
    public GameObject Gun;
    Animator animator;
    [Space]
    public int ammoCapacity = 7;
    int ammo;
    private void Start()
    {
        animator = GetComponent<Animator>();
        ammo = ammoCapacity;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            EquipGun();
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Reload();
        }

        animator.SetInteger("Ammo", ammo);
    }

    public void EquipGun()
    {

        Gun.SetActive(true);
        animator.enabled = true;
    }

    public void Shoot()
    {
        if(ammo >= 1) {
            animator.SetTrigger("Shoot");
            ammo--;
        }
    }

    public void Reload()
    {
        animator.SetTrigger("Reload");
    }

    public void ReloadDone()
    {
        ammo = ammoCapacity;
    }
}
