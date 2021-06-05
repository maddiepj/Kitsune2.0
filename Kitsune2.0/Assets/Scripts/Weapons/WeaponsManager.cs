using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsManager : MonoBehaviour
{

    public Weapon currentProjectile;
    public BasicKunai kunaiWeapon;
    public Shuriken shurikenWeapon;
    public GameObject player;
    public Transform throwPoint;
    public bool playerFacingRight;
    public Weapon currentWeapon;
    private int selectedProjectile = 1;

    // Start is called before the first frame update
    void Start()
    {
        selectedProjectile = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            selectedProjectile = 1;
        }

        if (Input.GetKeyDown("2"))
        {
            selectedProjectile = 2;
        }

        Debug.Log("WeaponsManager says selectedProjectile is " + selectedProjectile);

    }

    public Weapon getProjectile()
    {
        if (selectedProjectile == 1)
        {
            return shurikenWeapon;

        }
        else if (selectedProjectile == 2)
        {
            return kunaiWeapon;
        }
        else
        {
            Debug.Log("You don't have a projectile selected, this should never happen. selectedProjectile: " + selectedProjectile);
            return null;
        }
    }


    public int getSelectedProjectile()
    {
        return selectedProjectile;
    }

}