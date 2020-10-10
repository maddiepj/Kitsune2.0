using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerThrow : MonoBehaviour
{
    public WeaponsManager weaponMgr;
    public GameObject weapon;
    public Transform throwPoint;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject projectile = Instantiate(weaponMgr.currentProjectile, throwPoint.position, throwPoint.rotation);
            Weapon newWeapon = projectile.GetComponent<Weapon>();
            newWeapon.Throw();
        }
    }

}
