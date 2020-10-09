using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsManager : MonoBehaviour
{

    public GameObject kunai;
    public GameObject shuriken;
    public GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("1"))
        {
            projectile = shuriken;
        }

        if (Input.GetKeyDown("2"))
        {
            projectile = kunai;
        }

    }
}
