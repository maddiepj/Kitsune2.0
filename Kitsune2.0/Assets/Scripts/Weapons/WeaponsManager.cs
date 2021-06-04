using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsManager : MonoBehaviour
{

    public GameObject kunai;
    public GameObject shuriken;
    public GameObject currentProjectile;
    public BasicKunai kunaiWeapon;
    public Shuriken shurikenWeapon;
    public GameObject player;
    public Transform throwPoint;
    public bool playerFacingRight;
    public Weapon currentWeapon;

    // Start is called before the first frame update
    void Start()
    {
        currentProjectile = shuriken;
        currentWeapon = shurikenWeapon;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            currentProjectile = shuriken;
        }

        if (Input.GetKeyDown("2"))
        {
            currentProjectile = kunai;
        }

        //Debug.Log("Current projectile is " + currentProjectile);

    }

    public GameObject getProjectile()
    {
        return currentProjectile;
    }

}