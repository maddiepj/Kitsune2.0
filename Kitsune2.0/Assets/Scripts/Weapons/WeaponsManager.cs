using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsManager : MonoBehaviour
{

    public GameObject kunai;
    //public GameObject shuriken;
    public GameObject currentProjectile;
    public GameObject player;
    public Transform throwPoint;

    // Start is called before the first frame update
    void Start()
    {
        currentProjectile = kunai;
    }

    // Update is called once per frame
    void Update()
    {

        //if (Input.GetKeyDown("1"))
        //{
        //    currentProjectile = shuriken;
        //}

        if (Input.GetKeyDown("2"))
        {
            currentProjectile = kunai;
        }

    }

    //public string getWeapon()
    //{
    //    if (currentProjectile != null)
    //    {
    //        Debug.Log("Current weapon is " + currentProjectile);
    //        return currentProjectile;
    //    }
    //    else
    //    {
    //        Debug.Log("You somehow don't have a weapon selected. You should not be seeing this message.");
    //        return null;
    //    }
    

}
